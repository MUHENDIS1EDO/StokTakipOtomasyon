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
    public partial class MainPage : Form
    {
        public static string publicEmail;

        SqlConnection baglanti = new SqlConnection("Data Source=EXALOYD\\SQLEXPRESS;Initial Catalog=StokTakipOtomasyonu;Integrated Security=True");
        public MainPage()
        {
            InitializeComponent();
        }

        
        private void mainPage_buttonExit_Click_1(object sender, EventArgs e)
        {
            
            DialogResult x = MessageBox.Show("Are you sure you want to exit?", "exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (x == DialogResult.Yes)
                //Environment.Exit(0);
                Application.Exit();

        }

        private void button_hideShow_Click(object sender, EventArgs e)
        {
            if (mainPage_textboxPassword.PasswordChar == '*')
            {
                mainPage_textboxPassword.PasswordChar = '\0';
                mainPage_buttonHideShow.Text = "HIDE";

            }
            else if (mainPage_textboxPassword.PasswordChar == '\0')
            {
                mainPage_textboxPassword.PasswordChar = '*';
                mainPage_buttonHideShow.Text = "SHOW";
            }
        }

        


        private void mainPage_buttonSignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
        }

        private void mainPage_buttonLogin_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("sp_UserLogin", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.Add("@Email", SqlDbType.VarChar, 50).Value = mainPage_textboxEmail.Text;
            komut.Parameters.Add("@Sifre", SqlDbType.VarChar, 50).Value = mainPage_textboxPassword.Text;
            SqlDataReader reader = komut.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Login Succesfully");
                publicEmail = mainPage_textboxEmail.Text;
                HomePage homePage = new HomePage();
                homePage.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Check your email or password!");

            baglanti.Close();
        }

        private void mainPage_textboxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void mainPage_textboxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void lbl_resetPassword_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();
            changePassword.ShowDialog();
        }
    }
}
