namespace ManagementSystem
{
    partial class StartUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartUp));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnSignUpChange = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSignInChange = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelSignUp = new System.Windows.Forms.Panel();
            this.txtFieldContactNumber = new Bunifu.Framework.UI.BunifuTextbox();
            this.txtFieldPassword = new Bunifu.Framework.UI.BunifuTextbox();
            this.txtFieldUserName = new Bunifu.Framework.UI.BunifuTextbox();
            this.txtFieldLastName = new Bunifu.Framework.UI.BunifuTextbox();
            this.txtFieldFirstName = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnSignUp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelSignIn = new System.Windows.Forms.Panel();
            this.txtFieldLoginPassword = new Bunifu.Framework.UI.BunifuTextbox();
            this.txtFieldLoginUserName = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnSignIn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.directoryEntry2 = new System.DirectoryServices.DirectoryEntry();
            this.panelSignUp.SuspendLayout();
            this.panelSignIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnSignUpChange
            // 
            this.btnSignUpChange.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSignUpChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(160)))), ((int)(((byte)(136)))));
            this.btnSignUpChange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSignUpChange.BorderRadius = 0;
            this.btnSignUpChange.ButtonText = "Sign Up";
            this.btnSignUpChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUpChange.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSignUpChange.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSignUpChange.Iconimage")));
            this.btnSignUpChange.Iconimage_right = null;
            this.btnSignUpChange.Iconimage_right_Selected = null;
            this.btnSignUpChange.Iconimage_Selected = null;
            this.btnSignUpChange.IconZoom = 90D;
            this.btnSignUpChange.IsTab = false;
            this.btnSignUpChange.Location = new System.Drawing.Point(112, 40);
            this.btnSignUpChange.Margin = new System.Windows.Forms.Padding(4);
            this.btnSignUpChange.Name = "btnSignUpChange";
            this.btnSignUpChange.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(160)))), ((int)(((byte)(136)))));
            this.btnSignUpChange.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(160)))), ((int)(((byte)(136)))));
            this.btnSignUpChange.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSignUpChange.selected = false;
            this.btnSignUpChange.Size = new System.Drawing.Size(126, 45);
            this.btnSignUpChange.TabIndex = 0;
            this.btnSignUpChange.Textcolor = System.Drawing.Color.White;
            this.btnSignUpChange.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUpChange.Click += new System.EventHandler(this.btnSignUpChange_Click);
            // 
            // btnSignInChange
            // 
            this.btnSignInChange.Activecolor = System.Drawing.Color.SeaGreen;
            this.btnSignInChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(160)))), ((int)(((byte)(136)))));
            this.btnSignInChange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSignInChange.BorderRadius = 0;
            this.btnSignInChange.ButtonText = "Sign In";
            this.btnSignInChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignInChange.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSignInChange.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSignInChange.Iconimage")));
            this.btnSignInChange.Iconimage_right = null;
            this.btnSignInChange.Iconimage_right_Selected = null;
            this.btnSignInChange.Iconimage_Selected = null;
            this.btnSignInChange.IconZoom = 90D;
            this.btnSignInChange.IsTab = false;
            this.btnSignInChange.Location = new System.Drawing.Point(244, 40);
            this.btnSignInChange.Margin = new System.Windows.Forms.Padding(4);
            this.btnSignInChange.Name = "btnSignInChange";
            this.btnSignInChange.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(160)))), ((int)(((byte)(136)))));
            this.btnSignInChange.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(160)))), ((int)(((byte)(136)))));
            this.btnSignInChange.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSignInChange.selected = false;
            this.btnSignInChange.Size = new System.Drawing.Size(120, 45);
            this.btnSignInChange.TabIndex = 0;
            this.btnSignInChange.Textcolor = System.Drawing.Color.White;
            this.btnSignInChange.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignInChange.Click += new System.EventHandler(this.btnSignInChange_Click);
            // 
            // panelSignUp
            // 
            this.panelSignUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSignUp.Controls.Add(this.txtFieldContactNumber);
            this.panelSignUp.Controls.Add(this.txtFieldPassword);
            this.panelSignUp.Controls.Add(this.txtFieldUserName);
            this.panelSignUp.Controls.Add(this.txtFieldLastName);
            this.panelSignUp.Controls.Add(this.txtFieldFirstName);
            this.panelSignUp.Controls.Add(this.btnSignUp);
            this.panelSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            this.panelSignUp.Location = new System.Drawing.Point(25, 114);
            this.panelSignUp.Name = "panelSignUp";
            this.panelSignUp.Size = new System.Drawing.Size(396, 484);
            this.panelSignUp.TabIndex = 1;
            // 
            // txtFieldContactNumber
            // 
            this.txtFieldContactNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            this.txtFieldContactNumber.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtFieldContactNumber.BackgroundImage")));
            this.txtFieldContactNumber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtFieldContactNumber.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFieldContactNumber.ForeColor = System.Drawing.Color.White;
            this.txtFieldContactNumber.Icon = ((System.Drawing.Image)(resources.GetObject("txtFieldContactNumber.Icon")));
            this.txtFieldContactNumber.Location = new System.Drawing.Point(38, 309);
            this.txtFieldContactNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtFieldContactNumber.Name = "txtFieldContactNumber";
            this.txtFieldContactNumber.Size = new System.Drawing.Size(315, 48);
            this.txtFieldContactNumber.TabIndex = 1;
            this.txtFieldContactNumber.text = "Contact Number";
            // 
            // txtFieldPassword
            // 
            this.txtFieldPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            this.txtFieldPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtFieldPassword.BackgroundImage")));
            this.txtFieldPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtFieldPassword.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFieldPassword.ForeColor = System.Drawing.Color.White;
            this.txtFieldPassword.Icon = ((System.Drawing.Image)(resources.GetObject("txtFieldPassword.Icon")));
            this.txtFieldPassword.Location = new System.Drawing.Point(38, 236);
            this.txtFieldPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtFieldPassword.Name = "txtFieldPassword";
            this.txtFieldPassword.Size = new System.Drawing.Size(315, 48);
            this.txtFieldPassword.TabIndex = 1;
            this.txtFieldPassword.text = "password";
            // 
            // txtFieldUserName
            // 
            this.txtFieldUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            this.txtFieldUserName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtFieldUserName.BackgroundImage")));
            this.txtFieldUserName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtFieldUserName.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFieldUserName.ForeColor = System.Drawing.Color.White;
            this.txtFieldUserName.Icon = ((System.Drawing.Image)(resources.GetObject("txtFieldUserName.Icon")));
            this.txtFieldUserName.Location = new System.Drawing.Point(38, 166);
            this.txtFieldUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFieldUserName.Name = "txtFieldUserName";
            this.txtFieldUserName.Size = new System.Drawing.Size(315, 48);
            this.txtFieldUserName.TabIndex = 1;
            this.txtFieldUserName.text = "UserName";
            // 
            // txtFieldLastName
            // 
            this.txtFieldLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            this.txtFieldLastName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtFieldLastName.BackgroundImage")));
            this.txtFieldLastName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtFieldLastName.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFieldLastName.ForeColor = System.Drawing.Color.White;
            this.txtFieldLastName.Icon = ((System.Drawing.Image)(resources.GetObject("txtFieldLastName.Icon")));
            this.txtFieldLastName.Location = new System.Drawing.Point(38, 96);
            this.txtFieldLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFieldLastName.Name = "txtFieldLastName";
            this.txtFieldLastName.Size = new System.Drawing.Size(315, 48);
            this.txtFieldLastName.TabIndex = 1;
            this.txtFieldLastName.text = "Last Name";
            // 
            // txtFieldFirstName
            // 
            this.txtFieldFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            this.txtFieldFirstName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtFieldFirstName.BackgroundImage")));
            this.txtFieldFirstName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtFieldFirstName.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFieldFirstName.ForeColor = System.Drawing.Color.White;
            this.txtFieldFirstName.Icon = ((System.Drawing.Image)(resources.GetObject("txtFieldFirstName.Icon")));
            this.txtFieldFirstName.Location = new System.Drawing.Point(38, 24);
            this.txtFieldFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFieldFirstName.Name = "txtFieldFirstName";
            this.txtFieldFirstName.Size = new System.Drawing.Size(315, 48);
            this.txtFieldFirstName.TabIndex = 1;
            this.txtFieldFirstName.text = "First Name";
            // 
            // btnSignUp
            // 
            this.btnSignUp.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(160)))), ((int)(((byte)(136)))));
            this.btnSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSignUp.BorderRadius = 0;
            this.btnSignUp.ButtonText = "                          Sign Up";
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSignUp.Iconimage = null;
            this.btnSignUp.Iconimage_right = null;
            this.btnSignUp.Iconimage_right_Selected = null;
            this.btnSignUp.Iconimage_Selected = null;
            this.btnSignUp.IconZoom = 90D;
            this.btnSignUp.IsTab = false;
            this.btnSignUp.Location = new System.Drawing.Point(77, 402);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(4);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(160)))), ((int)(((byte)(136)))));
            this.btnSignUp.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(160)))), ((int)(((byte)(136)))));
            this.btnSignUp.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSignUp.selected = false;
            this.btnSignUp.Size = new System.Drawing.Size(252, 45);
            this.btnSignUp.TabIndex = 0;
            this.btnSignUp.Textcolor = System.Drawing.Color.White;
            this.btnSignUp.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // panelSignIn
            // 
            this.panelSignIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSignIn.Controls.Add(this.txtFieldLoginPassword);
            this.panelSignIn.Controls.Add(this.txtFieldLoginUserName);
            this.panelSignIn.Controls.Add(this.btnSignIn);
            this.panelSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            this.panelSignIn.Location = new System.Drawing.Point(487, 114);
            this.panelSignIn.Name = "panelSignIn";
            this.panelSignIn.Size = new System.Drawing.Size(400, 484);
            this.panelSignIn.TabIndex = 2;
            this.panelSignIn.Visible = false;
            // 
            // txtFieldLoginPassword
            // 
            this.txtFieldLoginPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            this.txtFieldLoginPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtFieldLoginPassword.BackgroundImage")));
            this.txtFieldLoginPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtFieldLoginPassword.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFieldLoginPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(192)))), ((int)(((byte)(160)))));
            this.txtFieldLoginPassword.Icon = ((System.Drawing.Image)(resources.GetObject("txtFieldLoginPassword.Icon")));
            this.txtFieldLoginPassword.Location = new System.Drawing.Point(49, 150);
            this.txtFieldLoginPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtFieldLoginPassword.Name = "txtFieldLoginPassword";
            this.txtFieldLoginPassword.Size = new System.Drawing.Size(315, 48);
            this.txtFieldLoginPassword.TabIndex = 2;
            this.txtFieldLoginPassword.Tag = "";
            this.txtFieldLoginPassword.text = "password";
            // 
            // txtFieldLoginUserName
            // 
            this.txtFieldLoginUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            this.txtFieldLoginUserName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtFieldLoginUserName.BackgroundImage")));
            this.txtFieldLoginUserName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtFieldLoginUserName.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFieldLoginUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(192)))), ((int)(((byte)(160)))));
            this.txtFieldLoginUserName.Icon = ((System.Drawing.Image)(resources.GetObject("txtFieldLoginUserName.Icon")));
            this.txtFieldLoginUserName.Location = new System.Drawing.Point(49, 61);
            this.txtFieldLoginUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFieldLoginUserName.Name = "txtFieldLoginUserName";
            this.txtFieldLoginUserName.Size = new System.Drawing.Size(315, 48);
            this.txtFieldLoginUserName.TabIndex = 1;
            this.txtFieldLoginUserName.text = "UserName";
            this.txtFieldLoginUserName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtFieldLoginUserName_MouseClick);
            // 
            // btnSignIn
            // 
            this.btnSignIn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(160)))), ((int)(((byte)(136)))));
            this.btnSignIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSignIn.BorderRadius = 0;
            this.btnSignIn.ButtonText = "                    Sign  In";
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIn.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSignIn.Iconimage = null;
            this.btnSignIn.Iconimage_right = null;
            this.btnSignIn.Iconimage_right_Selected = null;
            this.btnSignIn.Iconimage_Selected = null;
            this.btnSignIn.IconZoom = 90D;
            this.btnSignIn.IsTab = false;
            this.btnSignIn.Location = new System.Drawing.Point(90, 256);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(160)))), ((int)(((byte)(136)))));
            this.btnSignIn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(160)))), ((int)(((byte)(136)))));
            this.btnSignIn.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSignIn.selected = false;
            this.btnSignIn.Size = new System.Drawing.Size(252, 45);
            this.btnSignIn.TabIndex = 3;
            this.btnSignIn.Textcolor = System.Drawing.Color.White;
            this.btnSignIn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // StartUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1177, 654);
            this.Controls.Add(this.panelSignIn);
            this.Controls.Add(this.panelSignUp);
            this.Controls.Add(this.btnSignInChange);
            this.Controls.Add(this.btnSignUpChange);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StartUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelSignUp.ResumeLayout(false);
            this.panelSignIn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton btnSignUpChange;
        private Bunifu.Framework.UI.BunifuFlatButton btnSignInChange;
        private System.Windows.Forms.Panel panelSignUp;
        private Bunifu.Framework.UI.BunifuFlatButton btnSignUp;
        private Bunifu.Framework.UI.BunifuTextbox txtFieldFirstName;
        private Bunifu.Framework.UI.BunifuTextbox txtFieldContactNumber;
        private Bunifu.Framework.UI.BunifuTextbox txtFieldPassword;
        private Bunifu.Framework.UI.BunifuTextbox txtFieldUserName;
        private Bunifu.Framework.UI.BunifuTextbox txtFieldLastName;
        private System.Windows.Forms.Panel panelSignIn;
        private Bunifu.Framework.UI.BunifuTextbox txtFieldLoginPassword;
        private Bunifu.Framework.UI.BunifuTextbox txtFieldLoginUserName;
        private Bunifu.Framework.UI.BunifuFlatButton btnSignIn;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.DirectoryServices.DirectoryEntry directoryEntry2;
    }
}