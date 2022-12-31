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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StokTakipOtomasyon
{

    public partial class AddProducts : Form
    {
        public AddProducts()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=EXALOYD\\SQLEXPRESS;Initial Catalog=StokTakipOtomasyonu;Integrated Security=True");


        private void AddProducts_buttonExit_Click(object sender, EventArgs e)
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
            SqlCommand komut = new SqlCommand("select * from tbl_Product", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (textboxStockCode.Text == read["StockCode"].ToString() || textboxStockCode.Text== "")
                    durum = false;
            }
            baglanti.Close();
        }
        private void GetCategory()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from tbl_Category", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboboxCategory.Items.Add(read["Category"].ToString());
            }
            baglanti.Close();
        }

        private void AddProducts_Load(object sender, EventArgs e)
        {
            GetCategory();
        }

        private void comboboxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboboxBrand.Items.Clear();
            comboboxBrand.Text="";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from tbl_Brand where Category='"+comboboxCategory.SelectedItem+"'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboboxBrand.Items.Add(read["Brand"].ToString());
            }
            baglanti.Close();
        }
        private void Cleaner()
        {
            textboxStockCode.Text = "";
            comboboxCategory.SelectedIndex = -1;
            comboboxBrand.SelectedIndex = -1;
            textboxProductName.Text = "";
            textboxStock.Text = "";
            textboxSalePrice.Text = "";
            textboxPurchasePrice.Text = "";

        }

        private void AddProducts_buttonAddNew_Click(object sender, EventArgs e)
        {
            BlockAgain();
            if (durum==true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into tbl_Product(StockCode,Category,Brand,ProductName,Stock,SalePrice,PurchasePrice,Time)" +
                    " values(@StockCode,@Category,@Brand,@ProductName,@Stock,@SalePrice,@PurchasePrice,@Time)", baglanti);
                komut.Parameters.AddWithValue("@StockCode",textboxStockCode.Text);
                komut.Parameters.AddWithValue("@Category", comboboxCategory.Text);
                komut.Parameters.AddWithValue("@Brand", comboboxBrand.Text);
                komut.Parameters.AddWithValue("@ProductName", textboxProductName.Text);
                komut.Parameters.AddWithValue("@Stock", textboxStock.Text);
                komut.Parameters.AddWithValue("@SalePrice", double.Parse(textboxSalePrice.Text));
                komut.Parameters.AddWithValue("@PurchasePrice", double.Parse(textboxPurchasePrice.Text));
                komut.Parameters.AddWithValue("@Time", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Product Successfully Added!");
            }
            else
                MessageBox.Show("There is already a product!", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            comboboxBrand.Items.Clear();
            Cleaner();
        }
        private void Cleaner2()
        {
            StockCodetextbox.Text = "";
            Categorycombobox.SelectedIndex = -1;
            Brandcombobox.SelectedIndex = -1;
            ProductNametextbox.Text = "";
            Stocktextbox.Text = "";
            SalePricetextbox.Text = "";
            PurchasePricetextbox.Text = "";

        }

        private void StockCodetextbox_TextChanged(object sender, EventArgs e)
        {
            if (StockCodetextbox.Text == "")
            {
                Cleaner2();

            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from tbl_Product where StockCode like '"+StockCodetextbox.Text+"'",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                Categorycombobox.Text = read["Category"].ToString();
                Brandcombobox.Text = read["Brand"].ToString();
                ProductNametextbox.Text = read["ProductName"].ToString();
                lblTotalStock.Text = read["Stock"].ToString();
                SalePricetextbox.Text = read["SalePrice"].ToString();
                PurchasePricetextbox.Text = read["PurchasePrice"].ToString();
            }
            baglanti.Close();
        }

        private void AddProducts_buttonAddExisting_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update tbl_Product set Stock=Stock+'"+int.Parse(Stocktextbox.Text)+"' where StockCode='"+StockCodetextbox.Text+"'",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Cleaner2();
            lblTotalStock.Text = "";
            MessageBox.Show("guncellendi");
        }
    }
}
