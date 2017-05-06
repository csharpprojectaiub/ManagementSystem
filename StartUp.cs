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
using MetroFramework;
namespace ManagementSystem
{

    public partial class StartUp : Form
    {
        const string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=EshopStore;Integrated Security=True;Pooling=False";
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd;
        SqlDataReader dataReader;
        string username;
        public StartUp()
        {
            InitializeComponent();


        }

        private void btnSignUpChange_Click(object sender, EventArgs e)
        {

            panelSignUp.Visible = true;
            panelSignIn.Visible = false;



        }

        private void btnSignInChange_Click(object sender, EventArgs e)
        {
            panelSignIn.Visible = true;
            panelSignUp.Visible = false;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string firstName = txtFieldFirstName.text;
            string lastName = txtFieldLastName.text;
             username = txtFieldUserName.text;
            string password = txtFieldPassword.text;
            string contactNumber = txtFieldContactNumber.text;
            con.Open();
            try
            {

            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
             username = txtFieldLoginUserName.text;
            string uspassword = txtFieldLoginPassword.text;
            if (username == "" || uspassword == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }
           
            con.Open();
            try
            {
                string sql = "select *from Members where username='"+username+"' and password = '"+uspassword+"' ";
                cmd = new SqlCommand(sql, con);
                SqlDataReader dataReader;
                dataReader = cmd.ExecuteReader();
                int count = 0;
                while (dataReader.Read())
                {
                    count += 1;
                }
                if(count==1)
                {
                    this.Hide();
    
                    MainPage mainpage = new MainPage(username);
                    mainpage.Show();
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
            catch(Exception ex)
            {
                
            }
            finally
            {
                con.Close();
    
            }
        }

        private void txtFieldLoginUserName_MouseClick(object sender, MouseEventArgs e)
        {
            txtFieldLoginUserName.text = "";
        }
    }
}


    