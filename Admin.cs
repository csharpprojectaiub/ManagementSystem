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

namespace ManagementSystem
{
    public partial class Admin : MetroFramework.Forms.MetroForm
    {
        const string connectionString = @"Data Source = (localdb)\mssqllocaldb;Initial Catalog = EshopStore; Integrated Security = True; Pooling=False";
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd;
        SqlDataReader dataReader;
        SqlDataAdapter dataAdapter;
      
        public Admin(string username)
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shopData.MobileDevice' table. You can move, or remove it, as needed.
            this.mobileDeviceTableAdapter.Fill(this.shopData.MobileDevice);
            // TODO: This line of code loads data into the 'shopData.Hardware' table. You can move, or remove it, as needed.
            this.hardwareTableAdapter.Fill(this.shopData.Hardware);
            // TODO: This line of code loads data into the 'shopData.Games' table. You can move, or remove it, as needed.
            this.gamesTableAdapter.Fill(this.shopData.Games);
            // TODO: This line of code loads data into the 'shopData.Games' table. You can move, or remove it, as needed.
            this.gamesTableAdapter.Fill(this.shopData.Games);
            // TODO: This line of code loads data into the 'shopData.Accessories' table. You can move, or remove it, as needed.
            this.accessoriesTableAdapter.Fill(this.shopData.Accessories);
            // TODO: This line of code loads data into the 'shopData.Laptops' table. You can move, or remove it, as needed.
            this.laptopsTableAdapter.Fill(this.shopData.Laptops);
            // TODO: This line of code loads data into the 'shopData.Members' table. You can move, or remove it, as needed.
            this.membersTableAdapter.Fill(this.shopData.Members);

        }

        private void btnUserControl_Click(object sender, EventArgs e)
        {
            panelUserControl.Visible = true;
            panelAddProduct.Visible = false;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            panelAdduser.Visible = true;
            PanelRemoveUser.Visible = false;
            panelRemoveProduct.Visible = false;
            membersMetroGrid.Visible = false;
        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            PanelRemoveUser.Visible = true;
            panelAdduser.Visible = false;
            membersMetroGrid.Visible = true;
            
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string firstName = txtfirstName.Text;
            string lastName = txtlastname.Text;
            string username = txtusername.Text;
            string password = txtpassword.Text;
            string contactNumber = txtContactNumber.Text;
            if (firstName == "" || lastName == "" || username == "" || password == "" || contactNumber == "")
            {
                MessageBox.Show("Field not be empty");
            }
            else if (username == "admin" || username == "ADMIN")
            {
                MessageBox.Show("sorry Can not Sign Up as admin");
            }
            else
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                string sql = "INSERT INTO Members(firstname,lastname,username,password,contactnumber)   values('" + firstName + "','" + lastName + "','" + username + "','" + password + "','" + contactNumber + "')";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registered");
               


            }
        }

        private void membersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.membersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shopData);

        }

        private void Removeuser_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string sql = "Delete from Members where id='"+txtRemoveUSerId.Text+"'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("User Removed");
        }

        private void txtRemoveUSerId_Click(object sender, EventArgs e)
        {
            txtRemoveUSerId.Text = "";
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            panelAddProduct.Visible = true;
            panelAdduser.Visible = false;
            panelRemoveProduct.Visible = false;
        }

        private void btnAddProuct_Click(object sender, EventArgs e)
        {
            string productName = txtProductName.Text;
            string productPrice = txtproductPrice.Text;
            string productInStock = txtProductInStock.Text;
            string categoryList = comboCategory.SelectedItem.ToString();
            string productstatus = comboAvailable.SelectedItem.ToString();
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string sql = "INSERT INTO "+categoryList+" (productname,productprice,productavailable,productStatus) values ('" + productName + "','" + productPrice + "','" + productInStock + "','" + productstatus + "')";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Product Added");
           
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            panelRemoveProduct.Visible = true;
            panelAddProduct.Visible = false;
            panelAdduser.Visible = false;
           
        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RemoveCategoryList.SelectedItem.ToString() == "Accessories")
            {
                accessoriesMetroGrid.Visible = true;
                gamesMetroGrid.Visible = false;
                hardwareMetroGrid.Visible = false;
                laptopsMetroGrid.Visible = false;
                mobileDeviceMetroGrid.Visible = false;
            }
            else if (RemoveCategoryList.SelectedItem.ToString() == "Games") {
                accessoriesMetroGrid.Visible = false;
                gamesMetroGrid.Visible = true;
                hardwareMetroGrid.Visible = false;
                laptopsMetroGrid.Visible = false;
                mobileDeviceMetroGrid.Visible = false;
            }
            else if (RemoveCategoryList.SelectedItem.ToString() == "Hardware") {
                accessoriesMetroGrid.Visible = false;
                gamesMetroGrid.Visible = false;
                hardwareMetroGrid.Visible = true;
                laptopsMetroGrid.Visible = false;
                mobileDeviceMetroGrid.Visible = false;
            }
            else if (RemoveCategoryList.SelectedItem.ToString() == "Laptops") {
                accessoriesMetroGrid.Visible = false;
                gamesMetroGrid.Visible = false;
                hardwareMetroGrid.Visible = false;
                laptopsMetroGrid.Visible = true;
                mobileDeviceMetroGrid.Visible = false;
            }
            else if (RemoveCategoryList.SelectedItem.ToString() == "MobileDevice") {
                accessoriesMetroGrid.Visible = false;
                gamesMetroGrid.Visible = false;
                hardwareMetroGrid.Visible = false;
                laptopsMetroGrid.Visible = false;
                mobileDeviceMetroGrid.Visible = true;
            }
            else
            {
                MessageBox.Show("Not Available");
            }
        }
    }
}






