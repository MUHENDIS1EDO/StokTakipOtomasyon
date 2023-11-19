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
using System.Net.Mail;

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
            SignUp_textboxName.Text = "";
            SignUp_textboxLastName.Text = "";
            SignUp_textboxEmail.Text = "";
            SignUp_textboxPassword.Text = "";
            SignUp_comboboxGender.Text = "";

        }

        private void SignUp_buttonSignUp_Click(object sender, EventArgs e)
        {
            if (SignUp_textboxName.Text == "" || SignUp_textboxEmail.Text == "" || SignUp_textboxPassword.Text == "")
                MessageBox.Show("Please Fill All Fields");
            else
            {
                baglanti.Open();
                SqlCommand userControl = new SqlCommand("sp_UserControl", baglanti);
                userControl.CommandType = CommandType.StoredProcedure;
                userControl.Parameters.Add("Email", SqlDbType.NVarChar, 50).Value = SignUp_textboxEmail.Text;
                SqlDataReader reader = userControl.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("baska mail gir bu mecvut");
                }
                else
                {
                    SendMail();
                }
                baglanti.Close();

            }
        }
        Random rnd = new Random();
        int number;
        MailMessage mailMessage = new MailMessage();

        void SendMail()
        {
            number = rnd.Next(100000, 999999);
            mailMessage.From = new MailAddress("ceza_klas@hotmail.com");
            mailMessage.To.Add(SignUp_textboxEmail.Text);
            mailMessage.Subject = "Kayıt Ol ";
            mailMessage.Body = "Doğrulama Kodunuz : " + number;
            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new System.Net.NetworkCredential("ceza_klas@hotmail.com", "erdem1526yildiz");
            smtp.Host = "smtp.outlook.com"; //smtp.gmail.com
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.Send(mailMessage);
            MessageBox.Show("Lütfen Mail Adresinizi Kontrol Ediniz.");
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

        private void SignUp_textboxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        

        private void resetPassword_buttonVerify_Click(object sender, EventArgs e)
        {
            if (int.Parse(SignUp_verify.Text) == int.Parse(number.ToString()))
            {


                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into tbl_Users(Name,LastName,UserType,Email,Password,Gender) values(@Name,@LastName,@UserType,@Email,@Password,@Gender)", baglanti);
                //komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Name",SignUp_textboxName.Text);
                komut.Parameters.AddWithValue("@LastName",SignUp_textboxLastName.Text);
                komut.Parameters.AddWithValue("@UserType", SignUp_textboxUserType.Text);
                komut.Parameters.AddWithValue("@Email",SignUp_textboxEmail.Text);
                komut.Parameters.AddWithValue("@Password",SignUp_textboxPassword.Text);
                komut.Parameters.AddWithValue("@Gender",SignUp_comboboxGender.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Succesfull");
                this.Close();
            }
            else
            {
                MessageBox.Show("Kodlar uyusmadi");
            }
        }
    }
}
