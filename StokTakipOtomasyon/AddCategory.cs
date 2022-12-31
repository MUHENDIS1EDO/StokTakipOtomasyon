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
    public partial class AddCategory : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=EXALOYD\\SQLEXPRESS;Initial Catalog=StokTakipOtomasyonu;Integrated Security=True");
        public AddCategory()
        {
            InitializeComponent();
        }

        private void AddCategory_buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("Are you sure you want to exit?", "exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (x == DialogResult.Yes)
                this.Close();
        }
        bool durum;
        private void BlockAgain()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from tbl_Category", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (AddCategory_textboxCategory.Text == read["Category"].ToString() || AddCategory_textboxCategory.Text == "")
                    durum = false;
            }
            baglanti.Close();
        }

        private void AddCategory_buttonAdd_Click(object sender, EventArgs e)
        {
            BlockAgain();
            if (durum == true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into tbl_Category(Category) values ('" + AddCategory_textboxCategory.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Category Successfully Added!");
            }
            else
                MessageBox.Show("There is already a category!", "Warning",MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            AddCategory_textboxCategory.Text = "";
        }
        

        private void AddCategory_Load(object sender, EventArgs e)
        {

        }
    }
}
