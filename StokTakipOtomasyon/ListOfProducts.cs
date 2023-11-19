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
    public partial class ListOfProducts : Form
    {
        public ListOfProducts()
        {
            InitializeComponent();
        }

        private void homePage_buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("Are you sure you want to exit?", "exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (x == DialogResult.Yes)
                Application.Exit();
        }
        
        
        SqlConnection baglanti = new SqlConnection("Data Source=EXALOYD\\SQLEXPRESS;Initial Catalog=StokTakipOtomasyonu;Integrated Security=True");
        DataSet daset = new DataSet();
        private void GetCategory()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from tbl_Category", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                ListOfProducts_comboboxCategory.Items.Add(read["Category"].ToString());
            }
            baglanti.Close();
        }
        
        private void ListOfProducts_Load(object sender, EventArgs e)
        {
            ListOfProducts_labelWelcomeEmail.Text = MainPage.publicEmail;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from tbl_Users where Email like '" + ListOfProducts_labelWelcomeEmail.Text + "'", baglanti);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                ListOfProducts_labelWelcomeEmail.Text = reader["Email"].ToString();
                ListOfProducts_labelWelcomeUserType.Text = reader["UserType"].ToString();
                ListOfProducts_labelWelcomeName.Text = reader["Name"].ToString();
            }
            baglanti.Close();
            GetProduct();
            GetCategory();
        }

        private void GetProduct()
        {
            if (ListOfProducts_labelWelcomeUserType.Text == "Admin")
            {
                baglanti.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from tbl_Product", baglanti);
                adapter.Fill(daset, "tbl_Product");
                dataGridView3.DataSource = daset.Tables["tbl_Product"];
                baglanti.Close();
            }
            else
            {
                baglanti.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from tbl_Product where Brand like'" + ListOfProducts_labelWelcomeName.Text + "'", baglanti);
                adapter.Fill(daset, "tbl_Product");
                dataGridView3.DataSource = daset.Tables["tbl_Product"];
                baglanti.Close();
            }

        }
        private void Cleaner()
        {
            ListOfProducts_textboxStockCode.Text = "";
            ListOfProducts_textboxStockName.Text = "";
            ListOfProducts_textboxStock.Text = "";
            ListOfProducts_textboxSalePrice.Text = "";
            ListOfProducts_textboxPurchasePrice.Text = "";
        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ListOfProducts_textboxStockCode.Text = dataGridView3.CurrentRow.Cells["StockCode"].Value.ToString();
            ListOfProducts_comboboxCategory.Text = dataGridView3.CurrentRow.Cells["Category"].Value.ToString();
            ListOfProducts_comboboxBrand.Text = dataGridView3.CurrentRow.Cells["Brand"].Value.ToString();
            ListOfProducts_textboxStockName.Text = dataGridView3.CurrentRow.Cells["ProductName"].Value.ToString();
            ListOfProducts_textboxStock.Text = dataGridView3.CurrentRow.Cells["Stock"].Value.ToString();
            ListOfProducts_textboxSalePrice.Text = dataGridView3.CurrentRow.Cells["SalePrice"].Value.ToString();
            ListOfProducts_textboxPurchasePrice.Text = dataGridView3.CurrentRow.Cells["PurchasePrice"].Value.ToString();
        }
        

        private void ListOfProducts_buttonUpdate_Click(object sender, EventArgs e)
        {
            if (int.Parse(ListOfProducts_textboxStock.Text) < 0)
                MessageBox.Show("Enter a valid stock quantity!");
            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update tbl_Product set ProductName=@ProductName, Stock=@Stock ," +
                    "SalePrice=@SalePrice, PurchasePrice=@PurchasePrice where StockCode=@StockCode", baglanti);
                komut.Parameters.AddWithValue("@StockCode", ListOfProducts_textboxStockCode.Text);
                komut.Parameters.AddWithValue("@ProductName", ListOfProducts_textboxStockName.Text);
                komut.Parameters.AddWithValue("@Stock", int.Parse(ListOfProducts_textboxStock.Text));
                komut.Parameters.AddWithValue("@SalePrice", double.Parse(ListOfProducts_textboxSalePrice.Text));
                komut.Parameters.AddWithValue("@PurchasePrice", double.Parse(ListOfProducts_textboxPurchasePrice.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();
                daset.Tables["tbl_Product"].Clear();
                GetProduct();
                MessageBox.Show("Successfully Updated!");
            }
            
            Cleaner();
        }

        private void ListOfProducts_buttonUpdateCatAndBra_Click(object sender, EventArgs e)
        {
            if (ListOfProducts_textboxStockCode.Text != "")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update tbl_Product set Category=@Category, Brand=@Brand where StockCode=@StockCode", baglanti);
                komut.Parameters.AddWithValue("@StockCode", ListOfProducts_textboxStockCode.Text);
                komut.Parameters.AddWithValue("@Category", ListOfProducts_comboboxCategory.Text);
                komut.Parameters.AddWithValue("@Brand", ListOfProducts_comboboxBrand.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Successfully Updated!");
                daset.Tables["tbl_Product"].Clear();
                GetProduct();
                Cleaner();
            }
            else
                MessageBox.Show("Stock Code Not Selected!","Warning",MessageBoxButtons.RetryCancel,MessageBoxIcon.Warning);
            ListOfProducts_comboboxCategory.SelectedIndex = -1;
            ListOfProducts_comboboxBrand.SelectedIndex = -1;
        }

        private void ListOfProducts_comboboxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListOfProducts_comboboxBrand.Items.Clear();
            ListOfProducts_comboboxBrand.Text = "";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from tbl_Brand where Category='" + ListOfProducts_comboboxCategory.SelectedItem + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                ListOfProducts_comboboxBrand.Items.Add(read["Brand"].ToString());
            }
            baglanti.Close();
        }

        private void ListOfProducts_buttonDelete_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from tbl_Product where StockCode='" + dataGridView3.CurrentRow.Cells[0].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Succesfull!");
            daset.Tables["tbl_Product"].Clear();
            GetProduct();
            Cleaner();
        }

        private void ListOfProducts_textboxSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            baglanti.Open();
            SqlDataAdapter adptr = new SqlDataAdapter("select * from tbl_Product where StockCode like '%" + ListOfProducts_textboxSearch.Text + "%'", baglanti);
            adptr.Fill(table);
            dataGridView3.DataSource = table;
            baglanti.Close();
        }

        private void ListOfProducts_buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListOfProducts_textboxStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ListOfProducts_textboxStockCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
