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
    public partial class ListingOfSales : Form
    {
        public ListingOfSales()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=EXALOYD\\SQLEXPRESS;Initial Catalog=StokTakipOtomasyonu;Integrated Security=True");
        DataSet daset = new DataSet();

        private void ListingOfSales_buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Users_buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("Are you sure you want to exit?", "exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (x == DialogResult.Yes)
                Application.Exit();
        }
        

        private void ListingOfSales_Load(object sender, EventArgs e)
        {
            this.tbl_StatusSaleTableAdapter.Fill(this.stokTakipOtomasyonuDataSet11.tbl_StatusSale);
            this.tbl_StatusProductTableAdapter.Fill(this.stokTakipOtomasyonuDataSet10.tbl_StatusProduct);
            this.tbl_StatusTableAdapter2.Fill(this.stokTakipOtomasyonuDataSet7.tbl_Status);
            this.tbl_SaleTableAdapter.Fill(this.stokTakipOtomasyonuDataSet4.tbl_Sale);
        }

        private void ListingOfSale_buttonDeleteAllSale_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("Are you sure you want to delete all order history?", "delete all", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (x == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from tbl_StatusSale ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("All order history has been deleted!");
                GetListingOfSaleStatus();
            }
        }
        private void GetListingOfSaleStatus()
        {
            baglanti.Open();
            SqlDataAdapter adapter4 = new SqlDataAdapter("select * from tbl_StatusSale", baglanti);
            adapter4.Fill(daset, "tbl_StatusSale");
            dataGridView4.DataSource = daset.Tables["tbl_StatusSale"];
            baglanti.Close();
        }
        private void ListingOfSales_buttonDeleteAll_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("Are you sure you want to delete all order history?", "delete all", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (x == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from tbl_Sale ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("All order history has been deleted!");
                GetListingOfSale();
            }
            
        }

        private void GetListingOfSale()
        {
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from tbl_Sale", baglanti);
            adapter.Fill(daset, "tbl_Sale");
            dataGridView1.DataSource = daset.Tables["tbl_Sale"];
            baglanti.Close();
        }

        private void ListingOfSale_buttonDeleteAllProduct_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("Are you sure you want to delete all order history?", "delete all", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (x == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from tbl_StatusProduct ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("All order history has been deleted!");
                GetListingOfSaleProduct();
            }

        }
        private void GetListingOfSaleProduct()
        {
            baglanti.Open();
            SqlDataAdapter adapter2 = new SqlDataAdapter("select * from tbl_StatusProduct", baglanti);
            adapter2.Fill(daset, "tbl_StatusProduct");
            dataGridView3.DataSource = daset.Tables["tbl_StatusProduct"];
            baglanti.Close();
        }

        private void ListingOfSale_buttonDeleteAllUser_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("Are you sure you want to delete all order history?", "delete all", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (x == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from tbl_Status ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("All order history has been deleted!");
                GetListingOfSaleUser();
            }
        }
        private void GetListingOfSaleUser()
        {
            baglanti.Open();
            SqlDataAdapter adapter3 = new SqlDataAdapter("select * from tbl_Status", baglanti);
            adapter3.Fill(daset, "tbl_Status");
            dataGridView2.DataSource = daset.Tables["tbl_Status"];
            baglanti.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
