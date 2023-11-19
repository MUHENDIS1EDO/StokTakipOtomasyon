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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=EXALOYD\\SQLEXPRESS;Initial Catalog=StokTakipOtomasyonu;Integrated Security=True");
        DataSet daset =  new DataSet();

        
        private void homePage_buttonLogOut_Click_1(object sender, EventArgs e)
        {
            DialogResult logOut = new DialogResult();
            logOut = MessageBox.Show("Are you sure you want to exit?", "log out",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (logOut == DialogResult.Yes)
            {

                MainPage mainPage = new MainPage();
                mainPage.ShowDialog();

                this.Hide();
            }
        }

        private void homePage_buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("Are you sure you want to exit?", "exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (x == DialogResult.Yes)
                //Environment.Exit(0);
                Application.Exit();
        }

        private void homePage_buttonListOfCustomer_Click(object sender, EventArgs e)
        {
            Users Users = new Users();
            Users.ShowDialog();
            Reefresh();
        }

        //private void homePage_buttonLissOfProduct_Click(object sender, EventArgs e)
        //{
        //    AddProducts addProducts = new AddProducts();
        //    addProducts.ShowDialog();
        //    daset.Tables["tbl_Product"].Clear();
        //    GetProduct();
        //}
        private void homePage_buttonListSales_Click(object sender, EventArgs e)
        {
            ListingOfSales listingOfSales = new ListingOfSales();
            listingOfSales.ShowDialog();
            Reefresh();
        }
        private void homePage_buttonCategory_Click(object sender, EventArgs e)
        {
            AddCategory category = new AddCategory();
            category.ShowDialog();
            Reefresh();
        }

        private void homePage_buttonBrand_Click(object sender, EventArgs e)
        {
            AddBrand addBrand = new AddBrand();
            addBrand.ShowDialog();
            Reefresh();
        }

        private void homePage_buttonListOfProduct_Click(object sender, EventArgs e)
        {
            ListOfProducts listOfProducts = new ListOfProducts();
            listOfProducts.ShowDialog();
            daset.Tables["tbl_Product"].Clear();
            GetProduct();
            Reefresh();
        }
        private void ListOfCart()
        {
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from tbl_Cart", baglanti);
            adapter.Fill(daset, "tbl_Cart");
            dataGridView1.DataSource = daset.Tables["tbl_Cart"];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            baglanti.Close();
        }
        private void GetProduct()
        {
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from tbl_Product", baglanti);
            adapter.Fill(daset, "tbl_Product");
            dataGridView2.DataSource = daset.Tables["tbl_Product"];
            baglanti.Close();
        }
        private void Calculate()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select sum(TotalPrice) from tbl_Cart",baglanti);
                homePage_labelTotal.Text = komut.ExecuteScalar() + " TL";
                baglanti.Close();
            }
            catch (Exception)
            {

                ;
            }
        }
        private void Reefresh()
        {
            if (homePage_labelWelcomeUserType.Text == "Seller")
            {
                homePage_buttonListSales.Visible = false;
                homePage_buttonListOfCustomer.Visible = false;
            }
            else if (homePage_labelWelcomeUserType.Text == "Customer")
            {
                homePage_buttonListOfCustomer.Visible = false;
                homePage_buttonAddProduct.Visible = false;
                homePage_buttonBrand.Visible= false;
                homePage_buttonCategory.Visible= false;
                homePage_buttonListOfCustomer.Visible= false;
                homePage_buttonListOfProduct.Visible= false;
                homePage_buttonListSales.Visible= false;
            }
            else
                homePage_labelWelcomeEmail.Visible = false;
        }
        public virtual void Refresh()
        {
            this.Controls.Clear();
            this.InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            homePage_labelWelcomeEmail.Visible = false;
            homePage_labelWelcomeUserId.Visible = false;
            homePage_labelWelcomeUserType.Visible = false;
            homePage_labelWelcomeEmail.Text = MainPage.publicEmail;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from tbl_Users where Email like '" + homePage_labelWelcomeEmail.Text+ "'", baglanti);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                homePage_labelWelcomeUserType.Text = reader["UserType"].ToString();
                homePage_labelWelcomeUserId.Text = reader["UserId"].ToString();
                homePage_labelWelcomeName.Text= reader["Name"].ToString();
                homePage_labelWelcomeLastName.Text= reader["LastName"].ToString();
            }
            baglanti.Close();
            Reefresh();
            Calculate();
            GetProduct();
            ListOfCart();
        }

        private void homePage_textboxStockCode_TextChanged(object sender, EventArgs e)
        {
            if (homePage_textboxStockCode.Text == "")
            {
                homePage_textboxStockName.Text = "";
                homePage_textboxStock.Text = "";
                homePage_textboxPurchasePrice.Text = "";
                homePage_textboxTotalPrice.Text = "";
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from tbl_Product where StockCode like '"+homePage_textboxStockCode.Text+"'",baglanti);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                homePage_textboxStockName.Text = reader["ProductName"].ToString();
                homePage_textboxTotalStock.Text = reader["Stock"].ToString();
                homePage_textboxPurchasePrice.Text = reader["SalePrice"].ToString();
                homePage_textboxTotalPrice.Text = reader["PurchasePrice"].ToString();
            }
            baglanti.Close();
        }
        bool durum;
        private void ControlStockCode()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from tbl_Cart",baglanti);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                if (homePage_textboxStockCode.Text == reader["StockCode"].ToString())
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }
        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            homePage_textboxStockCode.Text = dataGridView2.CurrentRow.Cells["StockCode"].Value.ToString();
            homePage_textboxStockName.Text = dataGridView2.CurrentRow.Cells["ProductName"].Value.ToString();
            homePage_textboxTotalStock.Text = dataGridView2.CurrentRow.Cells["Stock"].Value.ToString();
            homePage_textboxPurchasePrice.Text = dataGridView2.CurrentRow.Cells["PurchasePrice"].Value.ToString();
        }
        private void homePage_buttonAdd_Click(object sender, EventArgs e)
        {

            ControlStockCode();
            if (durum == true)
            {
                if (homePage_textboxStockCode.Text == "" )
                    MessageBox.Show("Please choose an product!");
                else if (homePage_textboxStock.Text == "")
                    MessageBox.Show("Enter a valid stock quantity!");
                else if (int.Parse(homePage_textboxStock.Text) > int.Parse(homePage_textboxTotalStock.Text))
                    MessageBox.Show("Enter a valid stock quantity!");
                else if (int.Parse(homePage_textboxStock.Text) == 0)
                    MessageBox.Show("The product is out of stock.");
                else
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("insert into tbl_Cart(Email,StockCode,ProductName,Stock,PurchasePrice,TotalPrice,Time) " +
                        "values(@Email,@StockCode,@ProductName,@Stock,@PurchasePrice,@TotalPrice,@Time)", baglanti);
                    komut.Parameters.AddWithValue("@Email", homePage_labelWelcomeEmail.Text);
                    komut.Parameters.AddWithValue("@StockCode", homePage_textboxStockCode.Text);
                    komut.Parameters.AddWithValue("@ProductName", homePage_textboxStockName.Text);
                    komut.Parameters.AddWithValue("@Stock", int.Parse(homePage_textboxStock.Text));
                    komut.Parameters.AddWithValue("@PurchasePrice", double.Parse(homePage_textboxPurchasePrice.Text));
                    komut.Parameters.AddWithValue("@TotalPrice", double.Parse(homePage_textboxTotalPrice.Text));
                    komut.Parameters.AddWithValue("@Time", DateTime.Now.ToString());
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                }

            }
            else
            {
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update tbl_Cart set Stock='" + int.Parse(homePage_textboxStock.Text) + "' +Stock where StockCode='" + homePage_textboxStockCode.Text + "'", baglanti);
                komut2.ExecuteNonQuery();
                SqlCommand komut3 = new SqlCommand("update tbl_Cart set TotalPrice=Stock*PurchasePrice where StockCode='" + homePage_textboxStockCode.Text + "'", baglanti);
                komut3.ExecuteNonQuery();
                baglanti.Close();
            }
            daset.Tables["tbl_Cart"].Clear();
            ListOfCart();
            Calculate();
            homePage_textboxStockCode.Text = "";
            homePage_textboxStockName.Text = "";
            homePage_textboxStock.Text = "";
            homePage_textboxPurchasePrice.Text = "";
            homePage_textboxTotalPrice.Text = "";
            homePage_textboxTotalStock.Text = "";
        }

        private void homePage_textboxStock_TextChanged(object sender, EventArgs e)
        {
            try
            {
                homePage_textboxTotalPrice.Text = (double.Parse(homePage_textboxStock.Text) * double.Parse(homePage_textboxPurchasePrice.Text)).ToString();
            }
            catch (Exception)
            {
                ;
            }
        }

        private void homePage_textboxPurchasePrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                homePage_textboxTotalPrice.Text = (double.Parse(homePage_textboxStock.Text) * double.Parse(homePage_textboxPurchasePrice.Text)).ToString();
            }
            catch (Exception)
            {
                ;
            }
        }

        private void homePage_buttonDelete_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from tbl_Cart where StockCode='"
                + dataGridView1.CurrentRow.Cells["StockCode"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("The product was deleted from the cart!");
            daset.Tables["tbl_Cart"].Clear();
            ListOfCart();
            Calculate();
        }

        private void homePage_buttonSaleCancel_Click(object sender, EventArgs e)
        {
            DialogResult logOut = new DialogResult();
            logOut = MessageBox.Show("Are you sure you want to delete Cart?", "delete Cart", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (logOut == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from tbl_Cart ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("All items in cart have been deleted.");
                daset.Tables["tbl_Cart"].Clear();
                ListOfCart();
                Calculate();
            }
        }

        private void homePage_buttonSale_Click(object sender, EventArgs e)
        {

            DialogResult confimCart = new DialogResult();
            confimCart = MessageBox.Show("Do you confirm cart?", "confirm cart", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (confimCart == DialogResult.Yes)
            {
                //baglanti.Open();
                //SqlCommand komut4 = new SqlCommand("select StockCode,Stock from tbl_Product", baglanti);
                //SqlDataReader read = komut4.ExecuteReader();
                //while (read.Read())
                //{
                //    for (int j = 0; j < dataGridView1.Rows.Count-1; j++)
                //    {

                //        if (read[0].ToString() == dataGridView1.Rows[j].Cells[2].Value.ToString())
                //        {
                //            if (Convert.ToInt32(read[1].ToString())> Convert.ToInt32(dataGridView1.Rows[j].Cells[4].Value.ToString()))
                //            {
                //                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                //                {
                //                    MessageBox.Show("Test");
                //                    //baglanti.Open();
                //                    //SqlCommand komut = new SqlCommand("insert into tbl_Sale(Email,StockCode,ProductName,Stock,PurchasePrice,TotalPrice,Time) " +
                //                    //    "values(@Email,@StockCode,@ProductName,@Stock,@PurchasePrice,@TotalPrice,@Time)", baglanti);
                //                    //komut.Parameters.AddWithValue("@Email", homePage_labelWelcomeEmail.Text);
                //                    //komut.Parameters.AddWithValue("@StockCode", dataGridView1.Rows[i].Cells["StockCode"].Value.ToString());
                //                    //komut.Parameters.AddWithValue("@ProductName", dataGridView1.Rows[i].Cells["ProductName"].Value.ToString());
                //                    //komut.Parameters.AddWithValue("@Stock", int.Parse(dataGridView1.Rows[i].Cells["Stock"].Value.ToString()));
                //                    //komut.Parameters.AddWithValue("@PurchasePrice", double.Parse(dataGridView1.Rows[i].Cells["PurchasePrice"].Value.ToString()));
                //                    //komut.Parameters.AddWithValue("@TotalPrice", double.Parse(dataGridView1.Rows[i].Cells["TotalPrice"].Value.ToString()));
                //                    //komut.Parameters.AddWithValue("@Time", DateTime.Now.ToString());
                //                    //komut.ExecuteNonQuery();
                //                    //baglanti.Close();
                //                    //baglanti.Open();
                //                    //SqlCommand komut2 = new SqlCommand("update tbl_Product set Stock=Stock-'" + int.Parse(dataGridView1.Rows[i].Cells["Stock"].Value.ToString()) + "' " +
                //                    //    "where StockCode='" + dataGridView1.Rows[i].Cells["StockCode"].Value.ToString() + "'", baglanti);
                //                    //komut2.ExecuteNonQuery();
                //                    //baglanti.Close();
                //                }
                //                MessageBox.Show("Your order is complete.");
                //            }
                //            else
                //            {
                //                MessageBox.Show("You have exceeded the amount of the product!");
                //            }
                //        }
                //    }

                //}
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("insert into tbl_Sale(Email,StockCode,ProductName,Stock,PurchasePrice,TotalPrice,Time) " +
                        "values(@Email,@StockCode,@ProductName,@Stock,@PurchasePrice,@TotalPrice,@Time)", baglanti);
                    komut.Parameters.AddWithValue("@Email", homePage_labelWelcomeEmail.Text);
                    komut.Parameters.AddWithValue("@StockCode", dataGridView1.Rows[i].Cells["StockCode"].Value.ToString());
                    komut.Parameters.AddWithValue("@ProductName", dataGridView1.Rows[i].Cells["ProductName"].Value.ToString());
                    komut.Parameters.AddWithValue("@Stock", int.Parse(dataGridView1.Rows[i].Cells["Stock"].Value.ToString()));
                    komut.Parameters.AddWithValue("@PurchasePrice", double.Parse(dataGridView1.Rows[i].Cells["PurchasePrice"].Value.ToString()));
                    komut.Parameters.AddWithValue("@TotalPrice", double.Parse(dataGridView1.Rows[i].Cells["TotalPrice"].Value.ToString()));
                    komut.Parameters.AddWithValue("@Time", DateTime.Now.ToString());
                    komut.ExecuteNonQuery();
                    SqlCommand komut2 = new SqlCommand("update tbl_Product set Stock=Stock-'" + int.Parse(dataGridView1.Rows[i].Cells["Stock"].Value.ToString()) + "' " +
                        "where StockCode='" + dataGridView1.Rows[i].Cells["StockCode"].Value.ToString() + "'", baglanti);
                    komut2.ExecuteNonQuery();
                    baglanti.Close();
                }
                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("delete from tbl_Cart ", baglanti);
                komut3.ExecuteNonQuery();
                baglanti.Close();
                daset.Tables["tbl_Cart"].Clear();
                daset.Tables["tbl_Product"].Clear();
                ListOfCart();
                GetProduct();
                Calculate();
            }
        }

        private void homePage_textboxStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void homePage_buttonAddProduct_Click(object sender, EventArgs e)
        {
            AddProducts addProducts = new AddProducts();
            addProducts.ShowDialog();
            daset.Tables["tbl_Product"].Clear();
            GetProduct();
        }
    }
}
