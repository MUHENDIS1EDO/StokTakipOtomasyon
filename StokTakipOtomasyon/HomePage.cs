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
        }

        private void homePage_buttonLissOfProduct_Click(object sender, EventArgs e)
        {
            AddProducts addProducts = new AddProducts();
            addProducts.ShowDialog();
        }

        private void homePage_buttonCategory_Click(object sender, EventArgs e)
        {
            AddCategory category = new AddCategory();
            category.ShowDialog();
        }

        private void homePage_buttonBrand_Click(object sender, EventArgs e)
        {
            AddBrand addBrand = new AddBrand();
            addBrand.ShowDialog();
        }

        private void homePage_buttonListOfProduct_Click(object sender, EventArgs e)
        {
            ListOfProducts listOfProducts = new ListOfProducts();
            listOfProducts.ShowDialog();
        }
    }
}
