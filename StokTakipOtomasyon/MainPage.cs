using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipOtomasyon
{
    public partial class MainPage : Form
    {
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

        private void lbl_resetPassword_Click(object sender, EventArgs e)
        {
            ResetPassword resetPassword = new ResetPassword();
            resetPassword.Show();
        }


        private void mainPage_buttonSignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
        }

        private void mainPage_buttonLogin_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        
    }
}
