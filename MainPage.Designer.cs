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
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.doubleBitmapControl1 = new BunifuAnimatorNS.DoubleBitmapControl();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnGames = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAccessories = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLaptop = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMobiledevice = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblCategoryLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnHardware = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnLoginName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panleMain = new System.Windows.Forms.Panel();
            this.panelHardware = new System.Windows.Forms.Panel();
            this.panelHarawareData = new System.Windows.Forms.Panel();
            this.seacrchHaradware = new System.Windows.Forms.ToolStrip();
            this.productnameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.productnameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.seacrchToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.hardwareDataGridView = new System.Windows.Forms.DataGridView();
            this.closeAnimator = new BunifuAnimatorNS.Animator(this.components);
            this.openAnimator = new BunifuAnimatorNS.Animator(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.hardwareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mobileDeviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lvlProductCategpry = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtQuantity = new MetroFramework.Controls.MetroLabel();
            this.comboCategory = new MetroFramework.Controls.MetroComboBox();
            this.txtproductId = new MetroFramework.Controls.MetroTextBox();
            this.txtproductQuantity = new MetroFramework.Controls.MetroTextBox();
            this.btnAddToCart = new MetroFramework.Controls.MetroButton();
            this.btnConfirm = new MetroFramework.Controls.MetroButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hardwareBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.shopData = new ManagementSystem.shopData();
            this.hardwareTableAdapter = new ManagementSystem.shopDataTableAdapters.HardwareTableAdapter();
            this.tableAdapterManager = new ManagementSystem.shopDataTableAdapters.TableAdapterManager();
            this.buyGrid = new System.Windows.Forms.DataGridView();
            this.panelSidebar.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panleMain.SuspendLayout();
            this.panelHardware.SuspendLayout();
            this.panelHarawareData.SuspendLayout();
            this.seacrchHaradware.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hardwareDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardwareBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileDeviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardwareBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // doubleBitmapControl1
            // 
            this.openAnimator.SetDecoration(this.doubleBitmapControl1, BunifuAnimatorNS.DecorationType.None);
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
            this.panelSidebar.Controls.Add(this.btnLaptop);
            this.panelSidebar.Controls.Add(this.btnMobiledevice);
            this.panelSidebar.Controls.Add(this.bunifuSeparator1);
            this.panelSidebar.Controls.Add(this.lblCategoryLabel);
            this.panelSidebar.Controls.Add(this.btnHardware);
            this.openAnimator.SetDecoration(this.panelSidebar, BunifuAnimatorNS.DecorationType.None);
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
            this.openAnimator.SetDecoration(this.bunifuSeparator3, BunifuAnimatorNS.DecorationType.None);
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
            this.openAnimator.SetDecoration(this.btnGames, BunifuAnimatorNS.DecorationType.None);
            this.btnGames.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGames.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGames.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGames.Iconimage")));
            this.btnGames.Iconimage_right = null;
            this.btnGames.Iconimage_right_Selected = null;
            this.btnGames.Iconimage_Selected = null;
            this.btnGames.IconZoom = 90D;
            this.btnGames.IsTab = false;
            this.btnGames.Location = new System.Drawing.Point(2, 387);
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
            this.openAnimator.SetDecoration(this.btnAccessories, BunifuAnimatorNS.DecorationType.None);
            this.btnAccessories.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccessories.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAccessories.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAccessories.Iconimage")));
            this.btnAccessories.Iconimage_right = null;
            this.btnAccessories.Iconimage_right_Selected = null;
            this.btnAccessories.Iconimage_Selected = null;
            this.btnAccessories.IconZoom = 90D;
            this.btnAccessories.IsTab = false;
            this.btnAccessories.Location = new System.Drawing.Point(5, 303);
            this.btnAccessories.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAccessories.Name = "btnAccessories";
            this.btnAccessories.Normalcolor = System.Drawing.Color.Teal;
            this.btnAccessories.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAccessories.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAccessories.selected = false;
            this.btnAccessories.Size = new System.Drawing.Size(156, 48);
            this.btnAccessories.TabIndex = 1;
            this.btnAccessories.Textcolor = System.Drawing.Color.White;
            this.btnAccessories.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.openAnimator.SetDecoration(this.btnLaptop, BunifuAnimatorNS.DecorationType.None);
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
            this.openAnimator.SetDecoration(this.btnMobiledevice, BunifuAnimatorNS.DecorationType.None);
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
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.openAnimator.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
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
            this.openAnimator.SetDecoration(this.lblCategoryLabel, BunifuAnimatorNS.DecorationType.None);
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
            // btnHardware
            // 
            this.btnHardware.Activecolor = System.Drawing.Color.Teal;
            this.btnHardware.BackColor = System.Drawing.Color.Teal;
            this.btnHardware.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHardware.BorderRadius = 0;
            this.btnHardware.ButtonText = "Hardware";
            this.btnHardware.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeAnimator.SetDecoration(this.btnHardware, BunifuAnimatorNS.DecorationType.None);
            this.openAnimator.SetDecoration(this.btnHardware, BunifuAnimatorNS.DecorationType.None);
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
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btnLoginName);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.lblTimer);
            this.panelTop.Controls.Add(this.lblWelcome);
            this.panelTop.Controls.Add(this.bunifuSeparator2);
            this.openAnimator.SetDecoration(this.panelTop, BunifuAnimatorNS.DecorationType.None);
            this.closeAnimator.SetDecoration(this.panelTop, BunifuAnimatorNS.DecorationType.None);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(179, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1171, 67);
            this.panelTop.TabIndex = 2;
            // 
            // btnLoginName
            // 
            this.btnLoginName.AutoSize = true;
            this.closeAnimator.SetDecoration(this.btnLoginName, BunifuAnimatorNS.DecorationType.None);
            this.openAnimator.SetDecoration(this.btnLoginName, BunifuAnimatorNS.DecorationType.None);
            this.btnLoginName.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginName.Location = new System.Drawing.Point(774, 15);
            this.btnLoginName.Name = "btnLoginName";
            this.btnLoginName.Size = new System.Drawing.Size(165, 32);
            this.btnLoginName.TabIndex = 6;
            this.btnLoginName.Text = "Login Name";
            this.btnLoginName.Click += new System.EventHandler(this.btnLoginName_Click);
            this.btnLoginName.Enter += new System.EventHandler(this.label2_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.closeAnimator.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.openAnimator.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 32);
            this.label1.TabIndex = 5;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.closeAnimator.SetDecoration(this.lblTimer, BunifuAnimatorNS.DecorationType.None);
            this.openAnimator.SetDecoration(this.lblTimer, BunifuAnimatorNS.DecorationType.None);
            this.lblTimer.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblTimer.Location = new System.Drawing.Point(68, 13);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(179, 43);
            this.lblTimer.TabIndex = 4;
            this.lblTimer.Text = "00:00:00";
            this.lblTimer.Enter += new System.EventHandler(this.lblTimer_Enter);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.closeAnimator.SetDecoration(this.lblWelcome, BunifuAnimatorNS.DecorationType.None);
            this.openAnimator.SetDecoration(this.lblWelcome, BunifuAnimatorNS.DecorationType.None);
            this.lblWelcome.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblWelcome.Location = new System.Drawing.Point(332, 15);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(305, 37);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.Text = "Welcome to EShop";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.openAnimator.SetDecoration(this.bunifuSeparator2, BunifuAnimatorNS.DecorationType.None);
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
            // panleMain
            // 
            this.panleMain.Controls.Add(this.buyGrid);
            this.panleMain.Controls.Add(this.btnConfirm);
            this.panleMain.Controls.Add(this.btnAddToCart);
            this.panleMain.Controls.Add(this.txtproductQuantity);
            this.panleMain.Controls.Add(this.txtproductId);
            this.panleMain.Controls.Add(this.comboCategory);
            this.panleMain.Controls.Add(this.txtQuantity);
            this.panleMain.Controls.Add(this.metroLabel1);
            this.panleMain.Controls.Add(this.lvlProductCategpry);
            this.panleMain.Controls.Add(this.panelHardware);
            this.openAnimator.SetDecoration(this.panleMain, BunifuAnimatorNS.DecorationType.None);
            this.closeAnimator.SetDecoration(this.panleMain, BunifuAnimatorNS.DecorationType.None);
            this.panleMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panleMain.Location = new System.Drawing.Point(179, 67);
            this.panleMain.Name = "panleMain";
            this.panleMain.Size = new System.Drawing.Size(1171, 633);
            this.panleMain.TabIndex = 3;
            this.panleMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panleMain_Paint);
            // 
            // panelHardware
            // 
            this.panelHardware.Controls.Add(this.panelHarawareData);
            this.openAnimator.SetDecoration(this.panelHardware, BunifuAnimatorNS.DecorationType.None);
            this.closeAnimator.SetDecoration(this.panelHardware, BunifuAnimatorNS.DecorationType.None);
            this.panelHardware.Location = new System.Drawing.Point(5, 3);
            this.panelHardware.Name = "panelHardware";
            this.panelHardware.Size = new System.Drawing.Size(721, 583);
            this.panelHardware.TabIndex = 5;
            // 
            // panelHarawareData
            // 
            this.panelHarawareData.Controls.Add(this.seacrchHaradware);
            this.panelHarawareData.Controls.Add(this.hardwareDataGridView);
            this.openAnimator.SetDecoration(this.panelHarawareData, BunifuAnimatorNS.DecorationType.None);
            this.closeAnimator.SetDecoration(this.panelHarawareData, BunifuAnimatorNS.DecorationType.None);
            this.panelHarawareData.Location = new System.Drawing.Point(3, 3);
            this.panelHarawareData.Name = "panelHarawareData";
            this.panelHarawareData.Size = new System.Drawing.Size(748, 581);
            this.panelHarawareData.TabIndex = 0;
            this.panelHarawareData.Visible = false;
            this.panelHarawareData.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHarawareData_Paint);
            // 
            // seacrchHaradware
            // 
            this.openAnimator.SetDecoration(this.seacrchHaradware, BunifuAnimatorNS.DecorationType.None);
            this.closeAnimator.SetDecoration(this.seacrchHaradware, BunifuAnimatorNS.DecorationType.None);
            this.seacrchHaradware.Dock = System.Windows.Forms.DockStyle.None;
            this.seacrchHaradware.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productnameToolStripLabel,
            this.productnameToolStripTextBox,
            this.seacrchToolStripButton});
            this.seacrchHaradware.Location = new System.Drawing.Point(384, 34);
            this.seacrchHaradware.Name = "seacrchHaradware";
            this.seacrchHaradware.Size = new System.Drawing.Size(248, 25);
            this.seacrchHaradware.TabIndex = 4;
            this.seacrchHaradware.Text = "seacrchToolStrip";
            // 
            // productnameToolStripLabel
            // 
            this.productnameToolStripLabel.Name = "productnameToolStripLabel";
            this.productnameToolStripLabel.Size = new System.Drawing.Size(82, 22);
            this.productnameToolStripLabel.Text = "productname:";
            // 
            // productnameToolStripTextBox
            // 
            this.productnameToolStripTextBox.Name = "productnameToolStripTextBox";
            this.productnameToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            this.productnameToolStripTextBox.Click += new System.EventHandler(this.productnameToolStripTextBox_Click);
            // 
            // seacrchToolStripButton
            // 
            this.seacrchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.seacrchToolStripButton.Name = "seacrchToolStripButton";
            this.seacrchToolStripButton.Size = new System.Drawing.Size(52, 22);
            this.seacrchToolStripButton.Text = "Seacrch";
            this.seacrchToolStripButton.Click += new System.EventHandler(this.seacrchToolStripButton_Click);
            // 
            // hardwareDataGridView
            // 
            this.hardwareDataGridView.AutoGenerateColumns = false;
            this.hardwareDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(63)))));
            this.hardwareDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hardwareDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.hardwareDataGridView.DataSource = this.hardwareBindingSource1;
            this.openAnimator.SetDecoration(this.hardwareDataGridView, BunifuAnimatorNS.DecorationType.None);
            this.closeAnimator.SetDecoration(this.hardwareDataGridView, BunifuAnimatorNS.DecorationType.None);
            this.hardwareDataGridView.Location = new System.Drawing.Point(24, 68);
            this.hardwareDataGridView.Name = "hardwareDataGridView";
            this.hardwareDataGridView.Size = new System.Drawing.Size(614, 486);
            this.hardwareDataGridView.TabIndex = 0;
            // 
            // closeAnimator
            // 
            this.closeAnimator.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlideAndRotate;
            this.closeAnimator.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(50);
            animation2.RotateCoeff = 0.3F;
            animation2.RotateLimit = 0.2F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.closeAnimator.DefaultAnimation = animation2;
            // 
            // openAnimator
            // 
            this.openAnimator.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.openAnimator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.openAnimator.DefaultAnimation = animation1;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // hardwareBindingSource
            // 
            this.hardwareBindingSource.DataMember = "Hardware";
            // 
            // mobileDeviceBindingSource
            // 
            this.mobileDeviceBindingSource.DataMember = "MobileDevice";
            // 
            // lvlProductCategpry
            // 
            this.lvlProductCategpry.AutoSize = true;
            this.openAnimator.SetDecoration(this.lvlProductCategpry, BunifuAnimatorNS.DecorationType.None);
            this.closeAnimator.SetDecoration(this.lvlProductCategpry, BunifuAnimatorNS.DecorationType.None);
            this.lvlProductCategpry.Location = new System.Drawing.Point(771, 91);
            this.lvlProductCategpry.Name = "lvlProductCategpry";
            this.lvlProductCategpry.Size = new System.Drawing.Size(114, 19);
            this.lvlProductCategpry.TabIndex = 6;
            this.lvlProductCategpry.Text = "Product Category";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.openAnimator.SetDecoration(this.metroLabel1, BunifuAnimatorNS.DecorationType.None);
            this.closeAnimator.SetDecoration(this.metroLabel1, BunifuAnimatorNS.DecorationType.None);
            this.metroLabel1.Location = new System.Drawing.Point(771, 157);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(70, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Product Id";
            // 
            // txtQuantity
            // 
            this.txtQuantity.AutoSize = true;
            this.openAnimator.SetDecoration(this.txtQuantity, BunifuAnimatorNS.DecorationType.None);
            this.closeAnimator.SetDecoration(this.txtQuantity, BunifuAnimatorNS.DecorationType.None);
            this.txtQuantity.Location = new System.Drawing.Point(771, 203);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(108, 19);
            this.txtQuantity.TabIndex = 6;
            this.txtQuantity.Text = "Product Quantity";
            // 
            // comboCategory
            // 
            this.openAnimator.SetDecoration(this.comboCategory, BunifuAnimatorNS.DecorationType.None);
            this.closeAnimator.SetDecoration(this.comboCategory, BunifuAnimatorNS.DecorationType.None);
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.ItemHeight = 23;
            this.comboCategory.Items.AddRange(new object[] {
            "Accessories",
            "Games",
            "Hardware",
            "Laptops",
            "MobileDevice"});
            this.comboCategory.Location = new System.Drawing.Point(922, 81);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(121, 29);
            this.comboCategory.TabIndex = 7;
            this.comboCategory.UseSelectable = true;
            // 
            // txtproductId
            // 
            // 
            // 
            // 
            this.txtproductId.CustomButton.Image = null;
            this.txtproductId.CustomButton.Location = new System.Drawing.Point(106, 1);
            this.txtproductId.CustomButton.Name = "";
            this.txtproductId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtproductId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtproductId.CustomButton.TabIndex = 1;
            this.txtproductId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtproductId.CustomButton.UseSelectable = true;
            this.txtproductId.CustomButton.Visible = false;
            this.openAnimator.SetDecoration(this.txtproductId, BunifuAnimatorNS.DecorationType.None);
            this.closeAnimator.SetDecoration(this.txtproductId, BunifuAnimatorNS.DecorationType.None);
            this.txtproductId.Lines = new string[0];
            this.txtproductId.Location = new System.Drawing.Point(922, 153);
            this.txtproductId.MaxLength = 32767;
            this.txtproductId.Name = "txtproductId";
            this.txtproductId.PasswordChar = '\0';
            this.txtproductId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtproductId.SelectedText = "";
            this.txtproductId.SelectionLength = 0;
            this.txtproductId.SelectionStart = 0;
            this.txtproductId.ShortcutsEnabled = true;
            this.txtproductId.Size = new System.Drawing.Size(128, 23);
            this.txtproductId.TabIndex = 8;
            this.txtproductId.UseSelectable = true;
            this.txtproductId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtproductId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtproductQuantity
            // 
            // 
            // 
            // 
            this.txtproductQuantity.CustomButton.Image = null;
            this.txtproductQuantity.CustomButton.Location = new System.Drawing.Point(106, 1);
            this.txtproductQuantity.CustomButton.Name = "";
            this.txtproductQuantity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtproductQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtproductQuantity.CustomButton.TabIndex = 1;
            this.txtproductQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtproductQuantity.CustomButton.UseSelectable = true;
            this.txtproductQuantity.CustomButton.Visible = false;
            this.openAnimator.SetDecoration(this.txtproductQuantity, BunifuAnimatorNS.DecorationType.None);
            this.closeAnimator.SetDecoration(this.txtproductQuantity, BunifuAnimatorNS.DecorationType.None);
            this.txtproductQuantity.Lines = new string[0];
            this.txtproductQuantity.Location = new System.Drawing.Point(922, 199);
            this.txtproductQuantity.MaxLength = 32767;
            this.txtproductQuantity.Name = "txtproductQuantity";
            this.txtproductQuantity.PasswordChar = '\0';
            this.txtproductQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtproductQuantity.SelectedText = "";
            this.txtproductQuantity.SelectionLength = 0;
            this.txtproductQuantity.SelectionStart = 0;
            this.txtproductQuantity.ShortcutsEnabled = true;
            this.txtproductQuantity.Size = new System.Drawing.Size(128, 23);
            this.txtproductQuantity.TabIndex = 9;
            this.txtproductQuantity.UseSelectable = true;
            this.txtproductQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtproductQuantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnAddToCart
            // 
            this.openAnimator.SetDecoration(this.btnAddToCart, BunifuAnimatorNS.DecorationType.None);
            this.closeAnimator.SetDecoration(this.btnAddToCart, BunifuAnimatorNS.DecorationType.None);
            this.btnAddToCart.Location = new System.Drawing.Point(771, 261);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(114, 23);
            this.btnAddToCart.TabIndex = 10;
            this.btnAddToCart.Text = "Add To Cart";
            this.btnAddToCart.UseSelectable = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click_1);
            // 
            // btnConfirm
            // 
            this.openAnimator.SetDecoration(this.btnConfirm, BunifuAnimatorNS.DecorationType.None);
            this.closeAnimator.SetDecoration(this.btnConfirm, BunifuAnimatorNS.DecorationType.None);
            this.btnConfirm.Location = new System.Drawing.Point(936, 261);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(114, 23);
            this.btnConfirm.TabIndex = 10;
            this.btnConfirm.Text = "Confirm Purchase";
            this.btnConfirm.UseSelectable = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "productname";
            this.dataGridViewTextBoxColumn2.HeaderText = "productname";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "productprice";
            this.dataGridViewTextBoxColumn3.HeaderText = "productprice";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "productavailabale";
            this.dataGridViewTextBoxColumn4.HeaderText = "productavailabale";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "productstatus";
            this.dataGridViewTextBoxColumn5.HeaderText = "productstatus";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // hardwareBindingSource1
            // 
            this.hardwareBindingSource1.DataMember = "Hardware";
            this.hardwareBindingSource1.DataSource = this.shopData;
            // 
            // shopData
            // 
            this.shopData.DataSetName = "shopData";
            this.shopData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hardwareTableAdapter
            // 
            this.hardwareTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccessoriesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GamesTableAdapter = null;
            this.tableAdapterManager.HardwareTableAdapter = this.hardwareTableAdapter;
            this.tableAdapterManager.LaptopsTableAdapter = null;
            this.tableAdapterManager.MembersTableAdapter = null;
            this.tableAdapterManager.MobileDeviceTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ManagementSystem.shopDataTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // buyGrid
            // 
            this.buyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.openAnimator.SetDecoration(this.buyGrid, BunifuAnimatorNS.DecorationType.None);
            this.closeAnimator.SetDecoration(this.buyGrid, BunifuAnimatorNS.DecorationType.None);
            this.buyGrid.Location = new System.Drawing.Point(771, 306);
            this.buyGrid.Name = "buyGrid";
            this.buyGrid.Size = new System.Drawing.Size(286, 150);
            this.buyGrid.TabIndex = 11;
            this.buyGrid.Visible = false;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1350, 700);
            this.Controls.Add(this.panleMain);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.doubleBitmapControl1);
            this.closeAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.openAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1366, 739);
            this.Name = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panleMain.ResumeLayout(false);
            this.panleMain.PerformLayout();
            this.panelHardware.ResumeLayout(false);
            this.panelHarawareData.ResumeLayout(false);
            this.panelHarawareData.PerformLayout();
            this.seacrchHaradware.ResumeLayout(false);
            this.seacrchHaradware.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hardwareDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardwareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileDeviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardwareBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyGrid)).EndInit();
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
        private Bunifu.Framework.UI.BunifuFlatButton btnLaptop;
        private Bunifu.Framework.UI.BunifuFlatButton btnMobiledevice;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private System.Windows.Forms.Panel panleMain;
        private BunifuAnimatorNS.Animator closeAnimator;
        private BunifuAnimatorNS.Animator openAnimator;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label btnLoginName;
       
        private System.Windows.Forms.BindingSource mobileDeviceBindingSource;
        
        private System.Windows.Forms.Panel panelHardware;
       
        private System.Windows.Forms.BindingSource hardwareBindingSource;
        private System.Windows.Forms.Panel panelHarawareData;
        private shopData shopData;
        private System.Windows.Forms.BindingSource hardwareBindingSource1;
        private shopDataTableAdapters.HardwareTableAdapter hardwareTableAdapter;
        private shopDataTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView hardwareDataGridView;
        private System.Windows.Forms.ToolStrip seacrchHaradware;
        private System.Windows.Forms.ToolStripLabel productnameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox productnameToolStripTextBox;
        private System.Windows.Forms.ToolStripButton seacrchToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private MetroFramework.Controls.MetroButton btnConfirm;
        private MetroFramework.Controls.MetroButton btnAddToCart;
        private MetroFramework.Controls.MetroTextBox txtproductQuantity;
        private MetroFramework.Controls.MetroTextBox txtproductId;
        private MetroFramework.Controls.MetroComboBox comboCategory;
        private MetroFramework.Controls.MetroLabel txtQuantity;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lvlProductCategpry;
        private System.Windows.Forms.DataGridView buyGrid;
    }
}