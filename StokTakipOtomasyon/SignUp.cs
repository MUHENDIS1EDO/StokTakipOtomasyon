using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StokTakipOtomasyon
{
    public partial class SignUp : Form
    {

        SqlConnection baglanti = new SqlConnection("Data Source=EXALOYD\\SQLEXPRESS;Initial Catalog=StokTakipOtomasyonu;Integrated Security=True");
        public SignUp()
        {
            InitializeComponent();
        }
        private void Cleaner() 
        {
            SignUp_textboxUserName.Text = "";
            SignUp_textboxName.Text = "";
            SignUp_textboxLastName.Text = "";
            SignUp_comboboxUserType.Text = "";
            SignUp_textboxEmail.Text = "";
            SignUp_textboxPassword.Text = "";
            SignUp_comboboxGender.Text = "";

        }

        private void SignUp_buttonSignUp_Click(object sender, EventArgs e)
        {
            if (SignUp_textboxUserName.Text == "" || SignUp_textboxName.Text == "" || SignUp_textboxLastName.Text == "" ||
                SignUp_comboboxUserType.Text == "" || SignUp_textboxEmail.Text == "" || SignUp_textboxPassword.Text == "" ||
                SignUp_comboboxGender.Text == "")
                MessageBox.Show("Flease Fill All Fields");
            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into tbl_Users(UserName,Name,LastName,UserType,Email,Password,Gender) " +
                    " values(@UserName,@Name,@LastName,@UserType,@Email,@Password,@Gender)", baglanti);
                komut.Parameters.AddWithValue("@UserName", SignUp_textboxUserName.Text);
                komut.Parameters.AddWithValue("@Name", SignUp_textboxName.Text);
                komut.Parameters.AddWithValue("@LastName", SignUp_textboxLastName.Text);
                komut.Parameters.AddWithValue("@UserType", SignUp_comboboxUserType.Text);
                komut.Parameters.AddWithValue("@Email", SignUp_textboxEmail.Text);
                komut.Parameters.AddWithValue("@Password", SignUp_textboxPassword.Text);
                komut.Parameters.AddWithValue("@Gender", SignUp_comboboxGender.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Succesfull!");
                Cleaner();
                this.Close();
            }
        }

        private void SignUp_buttonHideShow_Click(object sender, EventArgs e)
        {
            if (SignUp_textboxPassword.PasswordChar == '*')
            {
                SignUp_textboxPassword.PasswordChar = '\0';
                SignUp_buttonHideShow.Text = "HIDE";

            }
            else if (SignUp_textboxPassword.PasswordChar == '\0')
            {
                SignUp_textboxPassword.PasswordChar = '*';
                SignUp_buttonHideShow.Text = "SHOW";
            }
        }

        private void SignUp_buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("Are you sure you want to exit?", "exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (x == DialogResult.Yes)
                this.Close();
        }
    }
}
