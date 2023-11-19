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
            AddProducts_labelWelcomeEmail.Text = MainPage.publicEmail;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from tbl_Users where Email like '" + AddProducts_labelWelcomeEmail.Text + "'", baglanti);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                AddProducts_labelWelcomeUserType.Text = reader["UserType"].ToString();
                AddProducts_labelWelcomeEmail.Text = reader["Email"].ToString();
                AddProducts_labelWelcomeName.Text = reader["Name"].ToString();
            }
            baglanti.Close();
            GetCategory();
        }

        private void comboboxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AddProducts_labelWelcomeUserType.Text == "Seller")
            {
                comboboxBrand.Items.Clear();
                comboboxBrand.Text = "";
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from tbl_Brand where Category='" + comboboxCategory.SelectedItem + "' and Brand='" + AddProducts_labelWelcomeName.Text + "'", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    comboboxBrand.Items.Add(read["Brand"].ToString());
                }
                baglanti.Close();
            }
            else
            {
                comboboxBrand.Items.Clear();
                comboboxBrand.Text = "";
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("select * from tbl_Brand where Category='" + comboboxCategory.SelectedItem + "'", baglanti);
                SqlDataReader read2 = komut2.ExecuteReader();
                while (read2.Read())
                {
                    comboboxBrand.Items.Add(read2["Brand"].ToString());
                }
                baglanti.Close();
            }
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
        private void AddProducts_buttonAddNew_Click(object sender, EventArgs e)
        {
            BlockAgain();

            if (durum==true)
            {
                if (textboxStockCode.Text == "" || comboboxCategory.Text == "" || comboboxBrand.Text == "" || textboxPurchasePrice.Text == ""
                    || textboxProductName.Text == "" || textboxStock.Text == "" || textboxSalePrice.Text == "")
                    MessageBox.Show("Please Fill All Fields");
                else
                {
                    if (int.Parse(textboxStock.Text) < 0)
                        MessageBox.Show("Enter a valid stock quantity!");

                    else
                    {
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("insert into tbl_Product(StockCode,Category,Brand,ProductName,Stock,SalePrice,PurchasePrice,Time)" +
                            " values(@StockCode,@Category,@Brand,@ProductName,@Stock,@SalePrice,@PurchasePrice,@Time)", baglanti);
                        komut.Parameters.AddWithValue("@StockCode", textboxStockCode.Text);
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
                }
            }
            else
                MessageBox.Show("There is already a product!", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            comboboxBrand.Items.Clear();
            Cleaner();
        }
        private void Cleaner2()
        {
            Categorytextbox.Text = "";
            Brandtextbox.Text = "";
            ProductNametextbox.Text = "";
            Stocktextbox.Text = "";
            SalePricetextbox.Text = "";
            PurchasePricetextbox.Text = "";
        }

        private void StockCodetextbox_TextChanged(object sender, EventArgs e)
        {
            bool durum = false;
            if (StockCodetextbox.Text == "")
                Cleaner2();

            if (AddProducts_labelWelcomeUserType.Text == "Seller")
            {
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("select * from tbl_Product where StockCode like '" + StockCodetextbox.Text + "' and Brand='"+ AddProducts_labelWelcomeName .Text+ "'", baglanti);
                SqlDataReader read2 = komut2.ExecuteReader();
                while (read2.Read())
                {
                    Categorytextbox.Text = read2["Category"].ToString();
                    Brandtextbox.Text = read2["Brand"].ToString();
                    ProductNametextbox.Text = read2["ProductName"].ToString();
                    lblTotalStock.Text = read2["Stock"].ToString();
                    SalePricetextbox.Text = read2["SalePrice"].ToString();
                    PurchasePricetextbox.Text = read2["PurchasePrice"].ToString();
                    if (Brandtextbox.Text == read2["Brand"].ToString())
                    {
                        durum = true;
                    }
                }
                baglanti.Close();
                if (durum==false)
                {
                    Cleaner2();
                }
            }
            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from tbl_Product where StockCode like '" + StockCodetextbox.Text + "'", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    Categorytextbox.Text = read["Category"].ToString();
                    Brandtextbox.Text = read["Brand"].ToString();
                    ProductNametextbox.Text = read["ProductName"].ToString();
                    lblTotalStock.Text = read["Stock"].ToString();
                    SalePricetextbox.Text = read["SalePrice"].ToString();
                    PurchasePricetextbox.Text = read["PurchasePrice"].ToString();
                }
                baglanti.Close();
            }
        }
        private void AddProducts_buttonAddExisting_Click(object sender, EventArgs e)
        {
            if (StockCodetextbox.Text == "" || Brandtextbox.Text == "" || Stocktextbox.Text == "" )
                MessageBox.Show("Please Fill All Fields");
            else
            {
                if (int.Parse(Stocktextbox.Text)<0)
                {
                    MessageBox.Show("Enter a valid stock quantity!");
                }
                else
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("update tbl_Product set Stock='" + int.Parse(Stocktextbox.Text) + "' where StockCode='" + StockCodetextbox.Text + "'", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    Cleaner2();
                    lblTotalStock.Text = "";
                    MessageBox.Show("Successfully Updated!");
                }
            }
        }

        private void textboxStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
