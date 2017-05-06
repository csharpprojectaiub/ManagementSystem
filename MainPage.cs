using System;
using System.Windows.Forms;


namespace ManagementSystem
{
    public partial class MainPage : Form
    {
        string username;
       
        public MainPage(string username)
        {
            InitializeComponent();
            this.username = username;
            
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
            // TODO: This line of code loads data into the 'shopDataSet.Members' table. You can move, or remove it, as needed.
           

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


        }

        private void btnMobiledevice_Click(object sender, EventArgs e)
        {

        }

        private void btnGames_Click(object sender, EventArgs e)
        {
           

        }

        private void userPanel_Click(object sender, EventArgs e)
        {
          
        }

        

        private void userNameButton_Click(object sender, EventArgs e)
        {
            userNameButton.ButtonText = username;
        }

        private void userNameButton_Load_1(object sender, EventArgs e)
        {
            userNameButton.ButtonText = username;
        }

        private void userNameButton_Click_1(object sender, EventArgs e)
        {
            userNameButton.ButtonText = username;
        }
    }
}