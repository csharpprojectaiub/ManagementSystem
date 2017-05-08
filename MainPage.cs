using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace ManagementSystem
{
    public partial class MainPage : Form
    {
        string username;
        const string connectionString = @"Data Source = (localdb)\mssqllocaldb;Initial Catalog = EshopStore; Integrated Security = True; Pooling=False";
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd;
        SqlDataReader dataReader;
        SqlDataAdapter dataAdapter;
        Timer t = new Timer();
        List<order> orders = new List<order>();
        string categoryList;


        public MainPage(string username)
        {
            InitializeComponent();
            this.username = username;
            btnLoginName.Text = "Logged in As" +" "+ username;
        }

        private void lblCategoryLabel_Click(object sender, EventArgs e)
        {

        }

        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuSeparator2_Load(object sender, EventArgs e)
        {

        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shopData.Hardware' table. You can move, or remove it, as needed.
            this.hardwareTableAdapter.Fill(this.shopData.Hardware);


            timer1.Start();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHardware_Click(object sender, EventArgs e)
        {
            panelHarawareData.Visible = true;
           
            List<ShopItems> hardware = new List<ShopItems>();
            using (con = new SqlConnection(connectionString)) {
                using (cmd = new SqlCommand("SELECT * FROM Hardware", con)) {
                    con.Open();
                    using (dataReader = cmd.ExecuteReader()) {
                        while (dataReader.Read()) {
                             ShopItems hardwareItem = new ShopItems();
                            hardwareItem.id = dataReader.GetInt32(0);
                            hardwareItem.product_name = dataReader.GetString(1);
                            hardwareItem.price = dataReader.GetInt32(2);
                            hardwareItem.Availability = dataReader.GetInt32(3);
                            hardwareItem.Status = dataReader.GetString(4);
                            hardware.Add(hardwareItem);
                        }
                    }
                }
            }
            
        }

        private void btnMobiledevice_Click(object sender, EventArgs e)
        {
           // panelMobileDevice.Visible = true;
          
        }

        private void btnGames_Click(object sender, EventArgs e)
        {


        }

        private void userPanel_Click(object sender, EventArgs e)
        {

        }

        private void panleMain_Paint(object sender, PaintEventArgs e)
        {

        }



        private void btnProfileName_Load(object sender, EventArgs e)
        {



        }

        private void btnProfileName_Click(object sender, EventArgs e)
        {


        }

        private void lblTimer_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("T");
        }

        private void label2_Enter(object sender, EventArgs e)
        {

        }

        private void btnLoginName_Click(object sender, EventArgs e)
        {
            
        }

        private void itemDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void seacrchToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.hardwareTableAdapter.Seacrch(this.shopData.Hardware, productnameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void productnameToolStripTextBox_Click(object sender, EventArgs e)
        {

        }

        private void panelHarawareData_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            this.hardwareBindingSource1.RemoveCurrent();
        }

        private void btnAddToCart_Click_1(object sender, EventArgs e)
        {

            categoryList = comboCategory.SelectedItem.ToString();
            string productId = txtproductId.Text;
            string quantity = txtproductQuantity.Text;
            int productQuantity = Convert.ToInt32(quantity);
            string sql = "select productname,productprice from " + categoryList + " where id='" + productId + "' ";
            using (con = new SqlConnection(connectionString))
            {
                using (cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    using (dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            order orderItem = new order();
                           orderItem.Productname = dataReader.GetString(0);
                            orderItem.price = dataReader.GetInt32(1)*productQuantity;
                            orderItem.buyerName = username;
                            orderItem.categoryName = comboCategory.SelectedItem.ToString();
                             orders.Add(orderItem);
                        }
                    }
                }
            }
            //cmd = new SqlCommand(sql, con);
            //con.Open();

            //using (dataReader = cmd.ExecuteReader())
            //{

            //    while (dataReader.Read())
            //    {
            //        order orderItem = new order();
            //        orderItem.Productname = dataReader.GetString(0);
            //        orderItem.price = dataReader.GetInt32(1);
            //        orders.Add(orderItem);
            //    }
            //}

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
            buyGrid.DataSource = orders;

            buyGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            buyGrid.Visible = true;
            string prname = orders[0].Productname;//product name of the first row of the grid view
            int price = orders[0].price;//price name of the first row of the grid view
            string prname1 = orders[0].categoryName;//product name of the second row of the grid view
            string price1 = orders[0].buyerName;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string sql = "INSERT INTO Orders(productName,price,category,BuyerName)   values('" + prname + "','"+price+"','"+categoryList+"','"+username+"')";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
       
            MessageBox.Show("Order Complete");
        }
    }
}
   