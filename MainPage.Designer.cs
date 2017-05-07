namespace ManagementSystem
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.doubleBitmapControl1 = new BunifuAnimatorNS.DoubleBitmapControl();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnGames = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAccessories = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMonitor = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLaptop = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMobiledevice = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHardware = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblCategoryLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.userNameButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.membersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopDataSet = new ManagementSystem.ShopDataSet();
            this.membersTableAdapter = new ManagementSystem.ShopDataSetTableAdapters.MembersTableAdapter();
            this.panleMain = new System.Windows.Forms.Panel();
            this.paneluserDropDown = new System.Windows.Forms.Panel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.picboxClose = new System.Windows.Forms.PictureBox();
            this.closeAnimator = new BunifuAnimatorNS.Animator(this.components);
            this.panelSidebar.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).BeginInit();
            this.panleMain.SuspendLayout();
            this.paneluserDropDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // doubleBitmapControl1
            // 
            this.closeAnimator.SetDecoration(this.doubleBitmapControl1, BunifuAnimatorNS.DecorationType.None);
            this.doubleBitmapControl1.Location = new System.Drawing.Point(784, 490);
            this.doubleBitmapControl1.Margin = new System.Windows.Forms.Padding(2);
            this.doubleBitmapControl1.Name = "doubleBitmapControl1";
            this.doubleBitmapControl1.Size = new System.Drawing.Size(56, 19);
            this.doubleBitmapControl1.TabIndex = 0;
            this.doubleBitmapControl1.Text = "doubleBitmapControl1";
            this.doubleBitmapControl1.Visible = false;
            // 
            // panelSidebar
            // 
            this.panelSidebar.Controls.Add(this.bunifuSeparator3);
            this.panelSidebar.Controls.Add(this.btnGames);
            this.panelSidebar.Controls.Add(this.btnAccessories);
            this.panelSidebar.Controls.Add(this.btnMonitor);
            this.panelSidebar.Controls.Add(this.btnLaptop);
            this.panelSidebar.Controls.Add(this.btnMobiledevice);
            this.panelSidebar.Controls.Add(this.btnHardware);
            this.panelSidebar.Controls.Add(this.bunifuSeparator1);
            this.panelSidebar.Controls.Add(this.lblCategoryLabel);
            this.closeAnimator.SetDecoration(this.panelSidebar, BunifuAnimatorNS.DecorationType.None);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(2);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(179, 700);
            this.panelSidebar.TabIndex = 1;
            this.panelSidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.closeAnimator.SetDecoration(this.bunifuSeparator3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator3.LineThickness = 3;
            this.bunifuSeparator3.Location = new System.Drawing.Point(154, 72);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(22, 664);
            this.bunifuSeparator3.TabIndex = 0;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = true;
            // 
            // btnGames
            // 
            this.btnGames.Activecolor = System.Drawing.Color.Teal;
            this.btnGames.BackColor = System.Drawing.Color.Teal;
            this.btnGames.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGames.BorderRadius = 0;
            this.btnGames.ButtonText = "Games";
            this.btnGames.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeAnimator.SetDecoration(this.btnGames, BunifuAnimatorNS.DecorationType.None);
            this.btnGames.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGames.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGames.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGames.Iconimage")));
            this.btnGames.Iconimage_right = null;
            this.btnGames.Iconimage_right_Selected = null;
            this.btnGames.Iconimage_Selected = null;
            this.btnGames.IconZoom = 90D;
            this.btnGames.IsTab = false;
            this.btnGames.Location = new System.Drawing.Point(4, 434);
            this.btnGames.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGames.Name = "btnGames";
            this.btnGames.Normalcolor = System.Drawing.Color.Teal;
            this.btnGames.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnGames.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGames.selected = false;
            this.btnGames.Size = new System.Drawing.Size(159, 47);
            this.btnGames.TabIndex = 1;
            this.btnGames.Textcolor = System.Drawing.Color.White;
            this.btnGames.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGames.Click += new System.EventHandler(this.btnGames_Click);
            // 
            // btnAccessories
            // 
            this.btnAccessories.Activecolor = System.Drawing.Color.Teal;
            this.btnAccessories.BackColor = System.Drawing.Color.Teal;
            this.btnAccessories.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAccessories.BorderRadius = 0;
            this.btnAccessories.ButtonText = "Accessories";
            this.btnAccessories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeAnimator.SetDecoration(this.btnAccessories, BunifuAnimatorNS.DecorationType.None);
            this.btnAccessories.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccessories.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAccessories.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAccessories.Iconimage")));
            this.btnAccessories.Iconimage_right = null;
            this.btnAccessories.Iconimage_right_Selected = null;
            this.btnAccessories.Iconimage_Selected = null;
            this.btnAccessories.IconZoom = 90D;
            this.btnAccessories.IsTab = false;
            this.btnAccessories.Location = new System.Drawing.Point(2, 359);
            this.btnAccessories.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAccessories.Name = "btnAccessories";
            this.btnAccessories.Normalcolor = System.Drawing.Color.Teal;
            this.btnAccessories.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAccessories.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAccessories.selected = false;
            this.btnAccessories.Size = new System.Drawing.Size(160, 48);
            this.btnAccessories.TabIndex = 1;
            this.btnAccessories.Textcolor = System.Drawing.Color.White;
            this.btnAccessories.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnMonitor
            // 
            this.btnMonitor.Activecolor = System.Drawing.Color.Teal;
            this.btnMonitor.BackColor = System.Drawing.Color.Teal;
            this.btnMonitor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMonitor.BorderRadius = 0;
            this.btnMonitor.ButtonText = "Monitor";
            this.btnMonitor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeAnimator.SetDecoration(this.btnMonitor, BunifuAnimatorNS.DecorationType.None);
            this.btnMonitor.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonitor.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMonitor.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMonitor.Iconimage")));
            this.btnMonitor.Iconimage_right = null;
            this.btnMonitor.Iconimage_right_Selected = null;
            this.btnMonitor.Iconimage_Selected = null;
            this.btnMonitor.IconZoom = 90D;
            this.btnMonitor.IsTab = false;
            this.btnMonitor.Location = new System.Drawing.Point(4, 295);
            this.btnMonitor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMonitor.Name = "btnMonitor";
            this.btnMonitor.Normalcolor = System.Drawing.Color.Teal;
            this.btnMonitor.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnMonitor.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMonitor.selected = false;
            this.btnMonitor.Size = new System.Drawing.Size(159, 47);
            this.btnMonitor.TabIndex = 1;
            this.btnMonitor.Textcolor = System.Drawing.Color.White;
            this.btnMonitor.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnLaptop
            // 
            this.btnLaptop.Activecolor = System.Drawing.Color.Teal;
            this.btnLaptop.BackColor = System.Drawing.Color.Teal;
            this.btnLaptop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLaptop.BorderRadius = 0;
            this.btnLaptop.ButtonText = "Laptop";
            this.btnLaptop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeAnimator.SetDecoration(this.btnLaptop, BunifuAnimatorNS.DecorationType.None);
            this.btnLaptop.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaptop.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLaptop.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLaptop.Iconimage")));
            this.btnLaptop.Iconimage_right = null;
            this.btnLaptop.Iconimage_right_Selected = null;
            this.btnLaptop.Iconimage_Selected = null;
            this.btnLaptop.IconZoom = 90D;
            this.btnLaptop.IsTab = false;
            this.btnLaptop.Location = new System.Drawing.Point(4, 224);
            this.btnLaptop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLaptop.Name = "btnLaptop";
            this.btnLaptop.Normalcolor = System.Drawing.Color.Teal;
            this.btnLaptop.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnLaptop.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLaptop.selected = false;
            this.btnLaptop.Size = new System.Drawing.Size(159, 47);
            this.btnLaptop.TabIndex = 1;
            this.btnLaptop.Textcolor = System.Drawing.Color.White;
            this.btnLaptop.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnMobiledevice
            // 
            this.btnMobiledevice.Activecolor = System.Drawing.Color.Teal;
            this.btnMobiledevice.BackColor = System.Drawing.Color.Teal;
            this.btnMobiledevice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMobiledevice.BorderRadius = 0;
            this.btnMobiledevice.ButtonText = "Mobile Devices";
            this.btnMobiledevice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeAnimator.SetDecoration(this.btnMobiledevice, BunifuAnimatorNS.DecorationType.None);
            this.btnMobiledevice.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMobiledevice.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMobiledevice.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMobiledevice.Iconimage")));
            this.btnMobiledevice.Iconimage_right = null;
            this.btnMobiledevice.Iconimage_right_Selected = null;
            this.btnMobiledevice.Iconimage_Selected = null;
            this.btnMobiledevice.IconZoom = 90D;
            this.btnMobiledevice.IsTab = false;
            this.btnMobiledevice.Location = new System.Drawing.Point(2, 158);
            this.btnMobiledevice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMobiledevice.Name = "btnMobiledevice";
            this.btnMobiledevice.Normalcolor = System.Drawing.Color.Teal;
            this.btnMobiledevice.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnMobiledevice.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMobiledevice.selected = false;
            this.btnMobiledevice.Size = new System.Drawing.Size(160, 46);
            this.btnMobiledevice.TabIndex = 1;
            this.btnMobiledevice.Textcolor = System.Drawing.Color.White;
            this.btnMobiledevice.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMobiledevice.Click += new System.EventHandler(this.btnMobiledevice_Click);
            // 
            // btnHardware
            // 
            this.btnHardware.Activecolor = System.Drawing.Color.Teal;
            this.btnHardware.BackColor = System.Drawing.Color.Teal;
            this.btnHardware.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHardware.BorderRadius = 0;
            this.btnHardware.ButtonText = "Hardware";
            this.btnHardware.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeAnimator.SetDecoration(this.btnHardware, BunifuAnimatorNS.DecorationType.None);
            this.btnHardware.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHardware.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHardware.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHardware.Iconimage")));
            this.btnHardware.Iconimage_right = null;
            this.btnHardware.Iconimage_right_Selected = null;
            this.btnHardware.Iconimage_Selected = null;
            this.btnHardware.IconZoom = 90D;
            this.btnHardware.IsTab = false;
            this.btnHardware.Location = new System.Drawing.Point(3, 85);
            this.btnHardware.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHardware.Name = "btnHardware";
            this.btnHardware.Normalcolor = System.Drawing.Color.Teal;
            this.btnHardware.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnHardware.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHardware.selected = false;
            this.btnHardware.Size = new System.Drawing.Size(159, 47);
            this.btnHardware.TabIndex = 1;
            this.btnHardware.Textcolor = System.Drawing.Color.White;
            this.btnHardware.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHardware.Click += new System.EventHandler(this.btnHardware_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.closeAnimator.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator1.ForeColor = System.Drawing.Color.Cornsilk;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 3;
            this.bunifuSeparator1.Location = new System.Drawing.Point(3, 58);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(190, 15);
            this.bunifuSeparator1.TabIndex = 0;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            this.bunifuSeparator1.Load += new System.EventHandler(this.bunifuSeparator1_Load);
            // 
            // lblCategoryLabel
            // 
            this.lblCategoryLabel.AutoSize = true;
            this.closeAnimator.SetDecoration(this.lblCategoryLabel, BunifuAnimatorNS.DecorationType.None);
            this.lblCategoryLabel.Font = new System.Drawing.Font("Consolas", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryLabel.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.lblCategoryLabel.Location = new System.Drawing.Point(16, 7);
            this.lblCategoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoryLabel.Name = "lblCategoryLabel";
            this.lblCategoryLabel.Size = new System.Drawing.Size(143, 36);
            this.lblCategoryLabel.TabIndex = 0;
            this.lblCategoryLabel.Text = "Category";
            this.lblCategoryLabel.Click += new System.EventHandler(this.lblCategoryLabel_Click);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.userNameButton);
            this.panelTop.Controls.Add(this.bunifuSeparator2);
            this.closeAnimator.SetDecoration(this.panelTop, BunifuAnimatorNS.DecorationType.None);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(179, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(820, 67);
            this.panelTop.TabIndex = 2;
            // 
            // userNameButton
            // 
            this.userNameButton.Activecolor = System.Drawing.Color.Transparent;
            this.userNameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userNameButton.BorderRadius = 0;
            this.userNameButton.ButtonText = "     ";
            this.userNameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeAnimator.SetDecoration(this.userNameButton, BunifuAnimatorNS.DecorationType.None);
            this.userNameButton.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.userNameButton.Iconcolor = System.Drawing.Color.Transparent;
            this.userNameButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("userNameButton.Iconimage")));
            this.userNameButton.Iconimage_right = null;
            this.userNameButton.Iconimage_right_Selected = null;
            this.userNameButton.Iconimage_Selected = null;
            this.userNameButton.IconZoom = 90D;
            this.userNameButton.IsTab = false;
            this.userNameButton.Location = new System.Drawing.Point(5, 7);
            this.userNameButton.Name = "userNameButton";
            this.userNameButton.Normalcolor = System.Drawing.Color.Empty;
            this.userNameButton.OnHovercolor = System.Drawing.Color.Empty;
            this.userNameButton.OnHoverTextColor = System.Drawing.Color.White;
            this.userNameButton.selected = false;
            this.userNameButton.Size = new System.Drawing.Size(241, 48);
            this.userNameButton.TabIndex = 1;
            this.userNameButton.Textcolor = System.Drawing.Color.White;
            this.userNameButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameButton.Load += new System.EventHandler(this.userNameButton_Load_1);
            this.userNameButton.Click += new System.EventHandler(this.userNameButton_Click_1);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.closeAnimator.SetDecoration(this.bunifuSeparator2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator2.ForeColor = System.Drawing.Color.Teal;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 3;
            this.bunifuSeparator2.Location = new System.Drawing.Point(-3, 58);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(1201, 15);
            this.bunifuSeparator2.TabIndex = 0;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            this.bunifuSeparator2.Load += new System.EventHandler(this.bunifuSeparator2_Load);
            // 
            // membersBindingSource
            // 
            this.membersBindingSource.DataMember = "Members";
            this.membersBindingSource.DataSource = this.shopDataSet;
            // 
            // shopDataSet
            // 
            this.shopDataSet.DataSetName = "ShopDataSet";
            this.shopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // membersTableAdapter
            // 
            this.membersTableAdapter.ClearBeforeFill = true;
            // 
            // panleMain
            // 
            this.panleMain.Controls.Add(this.paneluserDropDown);
            this.closeAnimator.SetDecoration(this.panleMain, BunifuAnimatorNS.DecorationType.None);
            this.panleMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panleMain.Location = new System.Drawing.Point(179, 67);
            this.panleMain.Name = "panleMain";
            this.panleMain.Size = new System.Drawing.Size(820, 633);
            this.panleMain.TabIndex = 3;
            // 
            // paneluserDropDown
            // 
            this.paneluserDropDown.Controls.Add(this.picboxClose);
            this.paneluserDropDown.Controls.Add(this.bunifuFlatButton4);
            this.paneluserDropDown.Controls.Add(this.bunifuFlatButton3);
            this.paneluserDropDown.Controls.Add(this.bunifuFlatButton2);
            this.paneluserDropDown.Controls.Add(this.bunifuFlatButton1);
            this.closeAnimator.SetDecoration(this.paneluserDropDown, BunifuAnimatorNS.DecorationType.None);
            this.paneluserDropDown.Location = new System.Drawing.Point(5, 12);
            this.paneluserDropDown.Name = "paneluserDropDown";
            this.paneluserDropDown.Size = new System.Drawing.Size(241, 274);
            this.paneluserDropDown.TabIndex = 0;
            this.paneluserDropDown.Visible = false;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "     Bunifu Flat Button";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeAnimator.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(-2, 0);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(241, 48);
            this.bunifuFlatButton1.TabIndex = 0;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "     Bunifu Flat Button";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeAnimator.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(0, 54);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(241, 48);
            this.bunifuFlatButton2.TabIndex = 0;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "     Bunifu Flat Button";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeAnimator.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(0, 108);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(241, 48);
            this.bunifuFlatButton3.TabIndex = 0;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "     Bunifu Flat Button";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeAnimator.SetDecoration(this.bunifuFlatButton4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton4.Iconimage")));
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconZoom = 90D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(0, 162);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(241, 48);
            this.bunifuFlatButton4.TabIndex = 0;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // picboxClose
            // 
            this.picboxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeAnimator.SetDecoration(this.picboxClose, BunifuAnimatorNS.DecorationType.None);
            this.picboxClose.Image = ((System.Drawing.Image)(resources.GetObject("picboxClose.Image")));
            this.picboxClose.Location = new System.Drawing.Point(188, 224);
            this.picboxClose.Name = "picboxClose";
            this.picboxClose.Size = new System.Drawing.Size(50, 47);
            this.picboxClose.TabIndex = 1;
            this.picboxClose.TabStop = false;
            this.picboxClose.Click += new System.EventHandler(this.picboxClose_Click);
            // 
            // closeAnimator
            // 
            this.closeAnimator.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.closeAnimator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.closeAnimator.DefaultAnimation = animation1;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(999, 700);
            this.Controls.Add(this.panleMain);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.doubleBitmapControl1);
            this.closeAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1366, 739);
            this.Name = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).EndInit();
            this.panleMain.ResumeLayout(false);
            this.paneluserDropDown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BunifuAnimatorNS.DoubleBitmapControl doubleBitmapControl1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelSidebar;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCategoryLabel;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuFlatButton btnHardware;
        private Bunifu.Framework.UI.BunifuFlatButton btnGames;
        private Bunifu.Framework.UI.BunifuFlatButton btnAccessories;
        private Bunifu.Framework.UI.BunifuFlatButton btnMonitor;
        private Bunifu.Framework.UI.BunifuFlatButton btnLaptop;
        private Bunifu.Framework.UI.BunifuFlatButton btnMobiledevice;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private ShopDataSet shopDataSet;
        private System.Windows.Forms.BindingSource membersBindingSource;
        private ShopDataSetTableAdapters.MembersTableAdapter membersTableAdapter;
        private Bunifu.Framework.UI.BunifuFlatButton userNameButton;
        private System.Windows.Forms.Panel panleMain;
        private System.Windows.Forms.Panel paneluserDropDown;
        private System.Windows.Forms.PictureBox picboxClose;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private BunifuAnimatorNS.Animator closeAnimator;
    }
}