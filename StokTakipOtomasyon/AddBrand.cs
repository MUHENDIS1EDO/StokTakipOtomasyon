using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StokTakipOtomasyon
{
    public partial class AddBrand : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=EXALOYD\\SQLEXPRESS;Initial Catalog=StokTakipOtomasyonu;Integrated Security=True");

        public AddBrand()
        {
            InitializeComponent();
        }

        private void AddBrand_buttonExit_Click(object sender, EventArgs e)
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
            SqlCommand komut = new SqlCommand("select * from tbl_Brand", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (AddBrand_comboboxCategory.Text ==read["Category"].ToString() && AddBrand_textboxBrand.Text == read["Brand"].ToString() || AddBrand_comboboxCategory.Text=="" || AddBrand_textboxBrand.Text == "")
                    durum = false;
            }
            baglanti.Close();
        }
        private void AddBrand_buttonAdd_Click(object sender, EventArgs e)
        {
            BlockAgain();
            if (durum == true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into tbl_Brand(Category,Brand) values ('" + AddBrand_comboboxCategory.Text + "','" + AddBrand_textboxBrand.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                AddBrand_textboxBrand.Text = "";
                AddBrand_comboboxCategory.SelectedIndex = -1;
                MessageBox.Show("Brand Successfully Added!");
            }
            else
                MessageBox.Show("There is already a brand!", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            AddBrand_textboxBrand.Text = "";
            AddBrand_comboboxCategory.SelectedIndex = -1;
            
        }

        private void AddBrand_Load(object sender, EventArgs e)
        {
            GetCategory();
        }

        private void GetCategory()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from tbl_Category", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                AddBrand_comboboxCategory.Items.Add(read["Category"].ToString());
            }
            baglanti.Close();
        }
    }
}
