using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StokTakipOtomasyon
{
    public partial class Users : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=EXALOYD\\SQLEXPRESS;Initial Catalog=StokTakipOtomasyonu;Integrated Security=True");
        DataSet daset = new DataSet();
        public Users()
        {
            InitializeComponent();
        }

        private void Users_buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("Are you sure you want to exit?", "exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (x == DialogResult.Yes)
                Application.Exit();
        }

        private void Users_buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CallUsers()
        {
            this.tbl_UsersTableAdapter.Fill(this.stokTakipOtomasyonuDataSet1.tbl_Users);
        }

        private void ListOfUsers()
        {
            baglanti.Open();
            SqlDataAdapter adptr = new SqlDataAdapter("select * from tbl_Users",baglanti);
            adptr.Fill(daset, "users");
            dataGridView1.DataSource = daset.Tables["tbl_Users"];
            baglanti.Close(); 

           
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Users_textboxUserId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Users_textboxUserName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Users_textboxName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Users_textboxLastName.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            Users_comboboxUserType.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            Users_textboxEmail.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            Users_textboxPassword.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            Users_comboboxGender.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }
        
        private void Cleaner()
        {
            Users_textboxUserId.Text = "";
            Users_textboxUserName.Text = "";
            Users_textboxName.Text = "";
            Users_textboxLastName.Text = "";
            Users_textboxEmail.Text = "";
            Users_textboxPassword.Text = "";
            Users_comboboxGender.SelectedIndex = -1;
            Users_comboboxUserType.SelectedIndex = -1;
        }
        private void Users_buttonUpdate_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update tbl_Users set UserName=@UserName,Name=@Name,LastName=@LastName,UserType=@UserType,Email=@Email,Password=@Password,Gender=@Gender where UserId=@UserId", baglanti);
            komut.Parameters.AddWithValue("@UserId", Users_textboxUserId.Text);
            komut.Parameters.AddWithValue("@UserName", Users_textboxUserName.Text);
            komut.Parameters.AddWithValue("@Name", Users_textboxName.Text);
            komut.Parameters.AddWithValue("@LastName", Users_textboxLastName.Text);
            komut.Parameters.AddWithValue("@UserType", Users_comboboxUserType.Text);
            komut.Parameters.AddWithValue("@Email", Users_textboxEmail.Text);
            komut.Parameters.AddWithValue("@Password", Users_textboxPassword.Text);
            komut.Parameters.AddWithValue("@Gender", Users_comboboxGender.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            CallUsers();
            MessageBox.Show("Succesfull!");
            Cleaner();
            
        }

        private void Users_buttonDelete_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from tbl_Users where UserId='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Succesfull!");
            CallUsers();
            Cleaner();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stokTakipOtomasyonuDataSet1.tbl_Users' table. You can move, or remove it, as needed.
            this.tbl_UsersTableAdapter.Fill(this.stokTakipOtomasyonuDataSet1.tbl_Users);
            
        }

        private void Searchbox_TextChanged(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            baglanti.Open();
            SqlDataAdapter adptr = new SqlDataAdapter("select * from tbl_Users where UserId like '%"+Searchbox.Text+"%'", baglanti);
            adptr.Fill(table);
            dataGridView1.DataSource = table;
            baglanti.Close();
        }

        private void Users_buttonAddCustomer_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
            CallUsers();
        }

        
    }
}
