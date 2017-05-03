using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementSystem
{
    public partial class StartUp : Form
    {
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

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            MainPage mainpage = new MainPage();
            mainpage.Show();
            Visible = false;
            MessageBox.Show("Helloe");
            MessageBox.Show("Hello");
          

        }
    }
}
