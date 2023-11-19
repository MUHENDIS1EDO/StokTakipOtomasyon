using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipOtomasyon
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=EXALOYD\\SQLEXPRESS;Initial Catalog=StokTakipOtomasyonu;Integrated Security=True");


        private void changePassword_buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("Are you sure you want to exit?", "exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (x == DialogResult.Yes)
                this.Close();
        }
        Random rnd = new Random();
        int number;
        MailMessage mailMessage = new MailMessage();
        void SendMail()
        {
            number = rnd.Next(100000, 999999);
            mailMessage.From = new MailAddress("ceza_klas@hotmail.com");
            mailMessage.To.Add(changePassword_textBoxEmail.Text);
            mailMessage.Subject = "Kayıt Ol ";
            mailMessage.Body = "Doğrulama Kodunuz : " + number;
            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new System.Net.NetworkCredential("ceza_klas@hotmail.com", "erdem1526yildiz");
            smtp.Host = "smtp.outlook.com"; //smtp.gmail.com
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.Send(mailMessage);
            MessageBox.Show("Check Your Mail!");
        }

        private void changePassword_buttonSend_Click(object sender, EventArgs e)
        {
            if (changePassword_textBoxEmail.Text != "")
            {
                baglanti.Open();
                SqlCommand userControl = new SqlCommand("sp_UserControl", baglanti);
                userControl.CommandType = CommandType.StoredProcedure;
                userControl.Parameters.Add("Email", SqlDbType.NVarChar, 50).Value = changePassword_textBoxEmail.Text;
                SqlDataReader reader = userControl.ExecuteReader();
                if (reader.Read())
                {
                    SendMail();

                }
                else
                {
                    MessageBox.Show("Check Your Mail!");

                }
                baglanti.Close();
            }
        }
        private void changePassword_buttonChange_Click(object sender, EventArgs e)
        {
            if (changePassword_textBoxPassword1.Text != "" || changePassword_textBoxEmail.Text != "" || changePassword_textBoxPassword2.Text != "")
            {
                if (changePassword_textBoxPassword1.Text == changePassword_textBoxPassword2.Text && int.Parse(changePassword_textBoxVerify.Text) == int.Parse(number.ToString()))
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("sp_PasswordUpdate", baglanti);
                    komut.CommandType = CommandType.StoredProcedure;
                    komut.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = changePassword_textBoxEmail.Text;
                    komut.Parameters.Add("@Password", SqlDbType.NVarChar, 50).Value = changePassword_textBoxPassword1.Text;
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Your password changed!");
                    this.Close();
                }
                else
                    MessageBox.Show("Enter The Same Passwords!", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Please Fill All Fields");


        }

    }
}
