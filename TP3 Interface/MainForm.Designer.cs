namespace Client_PM
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CBX_UsersList = new System.Windows.Forms.ComboBox();
            this.MS_Account = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Account_Login = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Account_Profil = new System.Windows.Forms.ToolStripMenuItem();
            this.Mi_Account_Create = new System.Windows.Forms.ToolStripMenuItem();
            this.retraitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Account_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.layoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CBX_Keywords = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BTN_Bottom = new System.Windows.Forms.Button();
            this.BTN_Right = new System.Windows.Forms.Button();
            this.BTN_Top = new System.Windows.Forms.Button();
            this.BTN_Left = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.FB_Masquer = new PhotoManagerClient.FlashButton();
            this.FB_Supprimer = new PhotoManagerClient.FlashButton();
            this.FB_Modifier = new PhotoManagerClient.FlashButton();
            this.FB_Ajout = new PhotoManagerClient.FlashButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.LBL_DateFin = new System.Windows.Forms.Label();
            this.LBL_DateDebut = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PhotoBrowser = new PhotoManagerClient.PhotosBrowser();
            this.groupBox1.SuspendLayout();
            this.MS_Account.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CBX_UsersList);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(245, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 74);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Users";
            // 
            // CBX_UsersList
            // 
            this.CBX_UsersList.FormattingEnabled = true;
            this.CBX_UsersList.Location = new System.Drawing.Point(6, 25);
            this.CBX_UsersList.Name = "CBX_UsersList";
            this.CBX_UsersList.Size = new System.Drawing.Size(215, 28);
            this.CBX_UsersList.TabIndex = 0;
            this.CBX_UsersList.SelectedIndexChanged += new System.EventHandler(this.CBX_UsersList_SelectedIndexChanged);
            // 
            // MS_Account
            // 
            this.MS_Account.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MS_Account.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MS_Account.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.layoutToolStripMenuItem});
            this.MS_Account.Location = new System.Drawing.Point(0, 0);
            this.MS_Account.Name = "MS_Account";
            this.MS_Account.Size = new System.Drawing.Size(1209, 24);
            this.MS_Account.TabIndex = 2;
            this.MS_Account.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MI_Account_Login,
            this.MI_Account_Profil,
            this.Mi_Account_Create,
            this.retraitToolStripMenuItem,
            this.MI_Account_Exit});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // MI_Account_Login
            // 
            this.MI_Account_Login.Name = "MI_Account_Login";
            this.MI_Account_Login.Size = new System.Drawing.Size(180, 22);
            this.MI_Account_Login.Text = "Login";
            this.MI_Account_Login.Click += new System.EventHandler(this.MI_Account_Login_Click);
            // 
            // MI_Account_Profil
            // 
            this.MI_Account_Profil.Name = "MI_Account_Profil";
            this.MI_Account_Profil.Size = new System.Drawing.Size(180, 22);
            this.MI_Account_Profil.Text = "Profil";
            this.MI_Account_Profil.Click += new System.EventHandler(this.MI_Account_Profil_Click);
            // 
            // Mi_Account_Create
            // 
            this.Mi_Account_Create.Name = "Mi_Account_Create";
            this.Mi_Account_Create.Size = new System.Drawing.Size(180, 22);
            this.Mi_Account_Create.Text = "Create";
            this.Mi_Account_Create.Click += new System.EventHandler(this.Mi_Account_Create_Click);
            // 
            // retraitToolStripMenuItem
            // 
            this.retraitToolStripMenuItem.Name = "retraitToolStripMenuItem";
            this.retraitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.retraitToolStripMenuItem.Text = "Retrait";
            // 
            // MI_Account_Exit
            // 
            this.MI_Account_Exit.Name = "MI_Account_Exit";
            this.MI_Account_Exit.Size = new System.Drawing.Size(180, 22);
            this.MI_Account_Exit.Text = "Exit";
            // 
            // layoutToolStripMenuItem
            // 
            this.layoutToolStripMenuItem.Name = "layoutToolStripMenuItem";
            this.layoutToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.layoutToolStripMenuItem.Text = "Layout";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CBX_Keywords);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(478, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 74);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Keyword";
            // 
            // CBX_Keywords
            // 
            this.CBX_Keywords.FormattingEnabled = true;
            this.CBX_Keywords.Location = new System.Drawing.Point(6, 25);
            this.CBX_Keywords.Name = "CBX_Keywords";
            this.CBX_Keywords.Size = new System.Drawing.Size(155, 28);
            this.CBX_Keywords.TabIndex = 0;
            this.CBX_Keywords.SelectedIndexChanged += new System.EventHandler(this.CBX_Keywords_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.BTN_Bottom);
            this.groupBox3.Controls.Add(this.BTN_Right);
            this.groupBox3.Controls.Add(this.BTN_Top);
            this.groupBox3.Controls.Add(this.BTN_Left);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(1009, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(146, 74);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Placement";
            // 
            // BTN_Bottom
            // 
            this.BTN_Bottom.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Bottom.Location = new System.Drawing.Point(109, 23);
            this.BTN_Bottom.Name = "BTN_Bottom";
            this.BTN_Bottom.Size = new System.Drawing.Size(30, 30);
            this.BTN_Bottom.TabIndex = 0;
            this.BTN_Bottom.Text = "↓";
            this.BTN_Bottom.UseVisualStyleBackColor = true;
            this.BTN_Bottom.Click += new System.EventHandler(this.BTN_Bottom_Click);
            // 
            // BTN_Right
            // 
            this.BTN_Right.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Right.Location = new System.Drawing.Point(75, 23);
            this.BTN_Right.Name = "BTN_Right";
            this.BTN_Right.Size = new System.Drawing.Size(30, 30);
            this.BTN_Right.TabIndex = 0;
            this.BTN_Right.Text = "→";
            this.BTN_Right.UseVisualStyleBackColor = true;
            this.BTN_Right.Click += new System.EventHandler(this.BTN_Right_Click);
            // 
            // BTN_Top
            // 
            this.BTN_Top.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Top.Location = new System.Drawing.Point(41, 23);
            this.BTN_Top.Name = "BTN_Top";
            this.BTN_Top.Size = new System.Drawing.Size(30, 30);
            this.BTN_Top.TabIndex = 0;
            this.BTN_Top.Text = "↑";
            this.BTN_Top.UseVisualStyleBackColor = true;
            this.BTN_Top.Click += new System.EventHandler(this.BTN_Top_Click);
            // 
            // BTN_Left
            // 
            this.BTN_Left.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Left.Location = new System.Drawing.Point(7, 23);
            this.BTN_Left.Name = "BTN_Left";
            this.BTN_Left.Size = new System.Drawing.Size(30, 30);
            this.BTN_Left.TabIndex = 0;
            this.BTN_Left.Text = "← ";
            this.BTN_Left.UseVisualStyleBackColor = true;
            this.BTN_Left.Click += new System.EventHandler(this.BTN_Left_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox4.Controls.Add(this.FB_Masquer);
            this.groupBox4.Controls.Add(this.FB_Supprimer);
            this.groupBox4.Controls.Add(this.FB_Modifier);
            this.groupBox4.Controls.Add(this.FB_Ajout);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Location = new System.Drawing.Point(12, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(227, 74);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Commands";
            // 
            // FB_Masquer
            // 
            this.FB_Masquer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FB_Masquer.BackgroundImage")));
            this.FB_Masquer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FB_Masquer.ClickedImage = ((System.Drawing.Image)(resources.GetObject("FB_Masquer.ClickedImage")));
            this.FB_Masquer.DisabledImage = ((System.Drawing.Image)(resources.GetObject("FB_Masquer.DisabledImage")));
            this.FB_Masquer.Image = ((System.Drawing.Image)(resources.GetObject("FB_Masquer.Image")));
            this.FB_Masquer.Location = new System.Drawing.Point(136, 29);
            this.FB_Masquer.Name = "FB_Masquer";
            this.FB_Masquer.NeutralImage = ((System.Drawing.Image)(resources.GetObject("FB_Masquer.NeutralImage")));
            this.FB_Masquer.OverImage = ((System.Drawing.Image)(resources.GetObject("FB_Masquer.OverImage")));
            this.FB_Masquer.Size = new System.Drawing.Size(36, 36);
            this.FB_Masquer.TabIndex = 3;
            this.FB_Masquer.Text = "flashButton1";
            this.FB_Masquer.UseVisualStyleBackColor = true;
            // 
            // FB_Supprimer
            // 
            this.FB_Supprimer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FB_Supprimer.BackgroundImage")));
            this.FB_Supprimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FB_Supprimer.ClickedImage = ((System.Drawing.Image)(resources.GetObject("FB_Supprimer.ClickedImage")));
            this.FB_Supprimer.DisabledImage = ((System.Drawing.Image)(resources.GetObject("FB_Supprimer.DisabledImage")));
            this.FB_Supprimer.Image = ((System.Drawing.Image)(resources.GetObject("FB_Supprimer.Image")));
            this.FB_Supprimer.Location = new System.Drawing.Point(93, 28);
            this.FB_Supprimer.Name = "FB_Supprimer";
            this.FB_Supprimer.NeutralImage = ((System.Drawing.Image)(resources.GetObject("FB_Supprimer.NeutralImage")));
            this.FB_Supprimer.OverImage = ((System.Drawing.Image)(resources.GetObject("FB_Supprimer.OverImage")));
            this.FB_Supprimer.Size = new System.Drawing.Size(36, 36);
            this.FB_Supprimer.TabIndex = 2;
            this.FB_Supprimer.Text = "flashButton1";
            this.FB_Supprimer.UseVisualStyleBackColor = true;
            // 
            // FB_Modifier
            // 
            this.FB_Modifier.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FB_Modifier.BackgroundImage")));
            this.FB_Modifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FB_Modifier.ClickedImage = ((System.Drawing.Image)(resources.GetObject("FB_Modifier.ClickedImage")));
            this.FB_Modifier.DisabledImage = ((System.Drawing.Image)(resources.GetObject("FB_Modifier.DisabledImage")));
            this.FB_Modifier.Image = ((System.Drawing.Image)(resources.GetObject("FB_Modifier.Image")));
            this.FB_Modifier.Location = new System.Drawing.Point(50, 29);
            this.FB_Modifier.Name = "FB_Modifier";
            this.FB_Modifier.NeutralImage = ((System.Drawing.Image)(resources.GetObject("FB_Modifier.NeutralImage")));
            this.FB_Modifier.OverImage = ((System.Drawing.Image)(resources.GetObject("FB_Modifier.OverImage")));
            this.FB_Modifier.Size = new System.Drawing.Size(36, 36);
            this.FB_Modifier.TabIndex = 1;
            this.FB_Modifier.Text = "flashButton1";
            this.FB_Modifier.UseVisualStyleBackColor = true;
            // 
            // FB_Ajout
            // 
            this.FB_Ajout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FB_Ajout.BackgroundImage")));
            this.FB_Ajout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FB_Ajout.ClickedImage = ((System.Drawing.Image)(resources.GetObject("FB_Ajout.ClickedImage")));
            this.FB_Ajout.DisabledImage = ((System.Drawing.Image)(resources.GetObject("FB_Ajout.DisabledImage")));
            this.FB_Ajout.Image = ((System.Drawing.Image)(resources.GetObject("FB_Ajout.Image")));
            this.FB_Ajout.Location = new System.Drawing.Point(7, 30);
            this.FB_Ajout.Name = "FB_Ajout";
            this.FB_Ajout.NeutralImage = ((System.Drawing.Image)(resources.GetObject("FB_Ajout.NeutralImage")));
            this.FB_Ajout.OverImage = ((System.Drawing.Image)(resources.GetObject("FB_Ajout.OverImage")));
            this.FB_Ajout.Size = new System.Drawing.Size(36, 36);
            this.FB_Ajout.TabIndex = 0;
            this.FB_Ajout.Text = "flashButton1";
            this.FB_Ajout.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.LBL_DateFin);
            this.groupBox5.Controls.Add(this.LBL_DateDebut);
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox5.Location = new System.Drawing.Point(654, 27);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(336, 74);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Date interval";
            // 
            // LBL_DateFin
            // 
            this.LBL_DateFin.AutoSize = true;
            this.LBL_DateFin.Location = new System.Drawing.Point(161, 15);
            this.LBL_DateFin.Name = "LBL_DateFin";
            this.LBL_DateFin.Size = new System.Drawing.Size(37, 20);
            this.LBL_DateFin.TabIndex = 3;
            this.LBL_DateFin.Text = "Au :";
            // 
            // LBL_DateDebut
            // 
            this.LBL_DateDebut.AutoSize = true;
            this.LBL_DateDebut.Location = new System.Drawing.Point(15, 15);
            this.LBL_DateDebut.Name = "LBL_DateDebut";
            this.LBL_DateDebut.Size = new System.Drawing.Size(38, 20);
            this.LBL_DateDebut.TabIndex = 2;
            this.LBL_DateDebut.Text = "Du :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(165, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(147, 26);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 26);
            this.textBox1.TabIndex = 0;
            // 
            // PhotoBrowser
            // 
            this.PhotoBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhotoBrowser.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PhotoBrowser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PhotoBrowser.Location = new System.Drawing.Point(12, 107);
            this.PhotoBrowser.Name = "PhotoBrowser";
            this.PhotoBrowser.Placement = PhotoManagerClient.PhotoBrowserPlacement.Left;
            this.PhotoBrowser.SelectedPhoto = null;
            this.PhotoBrowser.Size = new System.Drawing.Size(1185, 589);
            this.PhotoBrowser.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1209, 708);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PhotoBrowser);
            this.Controls.Add(this.MS_Account);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.MS_Account;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1169, 713);
            this.Name = "MainForm";
            this.Text = "Photo manager client application";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.groupBox1.ResumeLayout(false);
            this.MS_Account.ResumeLayout(false);
            this.MS_Account.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PhotoManagerClient.PhotosBrowser PhotoBrowser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip MS_Account;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MI_Account_Login;
        private System.Windows.Forms.ToolStripMenuItem MI_Account_Profil;
        private System.Windows.Forms.ToolStripMenuItem Mi_Account_Create;
        private System.Windows.Forms.ToolStripMenuItem MI_Account_Exit;
        private System.Windows.Forms.ComboBox CBX_UsersList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CBX_Keywords;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BTN_Bottom;
        private System.Windows.Forms.Button BTN_Right;
        private System.Windows.Forms.Button BTN_Top;
        private System.Windows.Forms.Button BTN_Left;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ToolStripMenuItem retraitToolStripMenuItem;
        private PhotoManagerClient.FlashButton FB_Masquer;
        private PhotoManagerClient.FlashButton FB_Supprimer;
        private PhotoManagerClient.FlashButton FB_Modifier;
        private PhotoManagerClient.FlashButton FB_Ajout;
        private System.Windows.Forms.ToolStripMenuItem layoutToolStripMenuItem;
        private System.Windows.Forms.Label LBL_DateFin;
        private System.Windows.Forms.Label LBL_DateDebut;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

