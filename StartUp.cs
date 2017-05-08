using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ManagementSystem
{

    public partial class StartUp : Form
    {
        const string connectionString = @"Data Source = (localdb)\mssqllocaldb;Initial Catalog = EshopStore; Integrated Security = True; Pooling=False";
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd;
        SqlDataReader dataReader;
        SqlDataAdapter dataAdapter;
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
            if (firstName == "" || lastName == "" || username == "" || password == "" || contactNumber == "")
            {
                MessageBox.Show("Field not be empty");
            }
            else if(username=="admin"||username=="ADMIN")
            {
                MessageBox.Show("sorry Can not Sign Up as admin");
            }
            else {
                SqlConnection con = new SqlConnection(connectionString);
            con.Open( );
            string sql = "INSERT INTO Members(firstname,lastname,username,password,contactnumber)   values('" + firstName + "','"+lastName+"','"+username+"','"+password+"','"+contactNumber+"')";
            SqlCommand cmd = new SqlCommand(sql,con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Registered");
                panelSignUp.Visible = false;
                panelSignIn.Visible = true;
                

        }
        }



        private void btnSignIn_Click(object sender, EventArgs e)
        {
             username = txtFieldLoginUserName.text;
            string password = txtFieldLoginPassword.text;
            if (username == "" || password == "")
            {
                MessageBox.Show("Username/password can not be empty");
                    return;
            }
           
            con.Open();
            if (username == "admin")
            {
                try
                {
                    string sql = "select *from Members where username='" + username + "' and password = '" + password + "' ";
                    cmd = new SqlCommand(sql, con);

                    dataReader = cmd.ExecuteReader();
                    int count = 0;
                    while (dataReader.Read())
                    {
                        count += 1;
                    }
                    if (count == 1)
                    {
                        this.Hide();

                        Admin admin = new Admin(username);
                        admin.Show();
                    }
                    else
                    {
                        MessageBox.Show("error");
                    }
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    con.Close();

                }
            }
            else
            {
                try
                {
                    string sql = "select *from Members where username='" + username + "' and password = '" + password + "' ";
                    cmd = new SqlCommand(sql, con);

                    dataReader = cmd.ExecuteReader();
                    int count = 0;
                    while (dataReader.Read())
                    {
                        count += 1;
                    }
                    if (count == 1)
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
                catch (Exception ex)
                {

                }
                finally
                {
                    con.Close();

                }
            }
        }

        private void txtFieldLoginUserName_MouseClick(object sender, MouseEventArgs e)
        {
            txtFieldLoginUserName.text = "";
        }

        private void txtFieldLoginUserName_OnTextChange(object sender, EventArgs e)
        {

        }

        private void txtFieldLoginUserName_Enter(object sender, EventArgs e)
        {
            txtFieldLoginUserName.text = "";
        }

        private void txtFieldLoginPassword_Enter(object sender, EventArgs e)
        {
            txtFieldLoginPassword.text = "";
        }

        private void txtFieldFirstName_Enter(object sender, EventArgs e)
        {
            txtFieldFirstName.text = "";
        }

        private void txtFieldLastName_OnTextChange(object sender, EventArgs e)
        {
            txtFieldLastName.text = "";
        }

        private void txtFieldUserName_Enter(object sender, EventArgs e)
        {
            txtFieldUserName.text = "";
        }

        private void txtFieldPassword_Enter(object sender, EventArgs e)
        {
            txtFieldPassword.text = "";
        }

        private void txtFieldContactNumber_Enter(object sender, EventArgs e)
        {
            txtFieldContactNumber.text = "";
        }

        private void txtFieldLastName_Enter(object sender, EventArgs e)
        {
            txtFieldLastName.text = "";
        }
    }
}


    