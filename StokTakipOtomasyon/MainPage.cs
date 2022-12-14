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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textbox_email_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textbox_password_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button_hideShow_Click(object sender, EventArgs e)
        {
            if (textbox_password.PasswordChar == '*')
            {
                textbox_password.PasswordChar = '\0';
                button_hideShow.Text = "HIDE";

            }
            else if (textbox_password.PasswordChar == '\0')
            {
                textbox_password.PasswordChar = '*';
                button_hideShow.Text = "SHOW";
            }
        }
    }
}
