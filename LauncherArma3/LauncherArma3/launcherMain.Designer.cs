﻿namespace LauncherArma3
{
    partial class launcherMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(launcherMain));
            this.loginBox = new System.Windows.Forms.GroupBox();
            this.registerLink = new System.Windows.Forms.LinkLabel();
            this.loginForgot = new System.Windows.Forms.LinkLabel();
            this.loginRememberLabel = new FlatUI.FlatLabel();
            this.loginRemember = new FlatUI.FlatCheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginButton = new FlatUI.FlatButton();
            this.loginLabel = new FlatUI.FlatLabel();
            this.loginPassword = new FlatUI.FlatTextBox();
            this.loginUsername = new FlatUI.FlatTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.newsBox = new System.Windows.Forms.GroupBox();
            this.newsDate3 = new iTalk.iTalk_Label();
            this.newsDate2 = new iTalk.iTalk_Label();
            this.newsDate1 = new iTalk.iTalk_Label();
            this.newsLabel3 = new iTalk.iTalk_Label();
            this.newsLabel2 = new iTalk.iTalk_Label();
            this.newsLabel1 = new iTalk.iTalk_Label();
            this.newsLink3 = new iTalk.iTalk_Button_1();
            this.newsLink2 = new iTalk.iTalk_Button_1();
            this.newsLink1 = new iTalk.iTalk_Button_1();
            this.iTalk_Separator3 = new iTalk.iTalk_Separator();
            this.iTalk_Separator2 = new iTalk.iTalk_Separator();
            this.registerBox = new System.Windows.Forms.GroupBox();
            this.registerCancel = new FlatUI.FlatButton();
            this.registerPassConf = new FlatUI.FlatTextBox();
            this.registerEmail = new FlatUI.FlatTextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.registerButton = new FlatUI.FlatButton();
            this.registerLabel = new FlatUI.FlatLabel();
            this.registerPass = new FlatUI.FlatTextBox();
            this.registerUsername = new FlatUI.FlatTextBox();
            this.playerBox = new System.Windows.Forms.GroupBox();
            this.settingsButton = new iTalk.iTalk_Button_1();
            this.playerStatusLabel = new FlatUI.FlatLabel();
            this.playerEmailLabel = new FlatUI.FlatLabel();
            this.playerUsernameLabel = new FlatUI.FlatLabel();
            this.playerStatus = new FlatUI.FlatLabel();
            this.playerEmail = new FlatUI.FlatLabel();
            this.playerUsername = new FlatUI.FlatLabel();
            this.disconnectButton = new MonoFlat.MonoFlat_Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBig = new System.Windows.Forms.PictureBox();
            this.flatProgressBar1 = new FlatUI.FlatProgressBar();
            this.staffMessage = new FlatUI.FlatTextBox();
            this.errorBox = new FlatUI.FlatAlertBox();
            this.succesBox = new FlatUI.FlatAlertBox();
            this.infoBox = new FlatUI.FlatAlertBox();
            this.loginBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.newsBox.SuspendLayout();
            this.registerBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.playerBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBig)).BeginInit();
            this.SuspendLayout();
            // 
            // loginBox
            // 
            this.loginBox.BackColor = System.Drawing.Color.Transparent;
            this.loginBox.Controls.Add(this.registerLink);
            this.loginBox.Controls.Add(this.loginForgot);
            this.loginBox.Controls.Add(this.loginRememberLabel);
            this.loginBox.Controls.Add(this.loginRemember);
            this.loginBox.Controls.Add(this.pictureBox1);
            this.loginBox.Controls.Add(this.loginButton);
            this.loginBox.Controls.Add(this.loginLabel);
            this.loginBox.Controls.Add(this.loginPassword);
            this.loginBox.Controls.Add(this.loginUsername);
            this.loginBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBox.Location = new System.Drawing.Point(321, 151);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(281, 234);
            this.loginBox.TabIndex = 4;
            this.loginBox.TabStop = false;
            this.loginBox.Visible = false;
            // 
            // registerLink
            // 
            this.registerLink.Location = new System.Drawing.Point(7, 192);
            this.registerLink.Name = "registerLink";
            this.registerLink.Size = new System.Drawing.Size(268, 21);
            this.registerLink.TabIndex = 6;
            this.registerLink.TabStop = true;
            this.registerLink.Text = "or register";
            this.registerLink.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.registerLink.Visible = false;
            this.registerLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.register_LinkClicked);
            // 
            // loginForgot
            // 
            this.loginForgot.Location = new System.Drawing.Point(7, 209);
            this.loginForgot.Name = "loginForgot";
            this.loginForgot.Size = new System.Drawing.Size(268, 21);
            this.loginForgot.TabIndex = 10;
            this.loginForgot.TabStop = true;
            this.loginForgot.Text = "I forgot my password";
            this.loginForgot.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.loginForgot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginForgot_LinkClicked);
            // 
            // loginRememberLabel
            // 
            this.loginRememberLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginRememberLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.loginRememberLabel.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginRememberLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.loginRememberLabel.Location = new System.Drawing.Point(34, 140);
            this.loginRememberLabel.Name = "loginRememberLabel";
            this.loginRememberLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.loginRememberLabel.Size = new System.Drawing.Size(199, 22);
            this.loginRememberLabel.TabIndex = 9;
            this.loginRememberLabel.Text = "Remember me";
            // 
            // loginRemember
            // 
            this.loginRemember.BackColor = System.Drawing.SystemColors.Control;
            this.loginRemember.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.loginRemember.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.loginRemember.Checked = false;
            this.loginRemember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginRemember.Font = new System.Drawing.Font("Segoe Script", 10F);
            this.loginRemember.ForeColor = System.Drawing.Color.YellowGreen;
            this.loginRemember.Location = new System.Drawing.Point(7, 136);
            this.loginRemember.Name = "loginRemember";
            this.loginRemember.Options = FlatUI.FlatCheckBox._Options.Style1;
            this.loginRemember.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.loginRemember.Size = new System.Drawing.Size(22, 22);
            this.loginRemember.TabIndex = 7;
            this.loginRemember.Text = "Bite";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Transparent;
            this.loginButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.loginButton.Location = new System.Drawing.Point(61, 160);
            this.loginButton.Name = "loginButton";
            this.loginButton.Rounded = false;
            this.loginButton.Size = new System.Drawing.Size(162, 32);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Log In";
            this.loginButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.loginLabel.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.loginLabel.Location = new System.Drawing.Point(1, 27);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.loginLabel.Size = new System.Drawing.Size(280, 36);
            this.loginLabel.TabIndex = 3;
            this.loginLabel.Text = "To join our server\r\n  please sign in.\r\n";
            this.loginLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // loginPassword
            // 
            this.loginPassword.BackColor = System.Drawing.Color.Transparent;
            this.loginPassword.FocusOnHover = false;
            this.loginPassword.Location = new System.Drawing.Point(6, 105);
            this.loginPassword.MaxLength = 32767;
            this.loginPassword.Multiline = false;
            this.loginPassword.Name = "loginPassword";
            this.loginPassword.ReadOnly = false;
            this.loginPassword.Size = new System.Drawing.Size(269, 29);
            this.loginPassword.TabIndex = 2;
            this.loginPassword.Text = "0000";
            this.loginPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.loginPassword.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.loginPassword.UseSystemPasswordChar = true;
            // 
            // loginUsername
            // 
            this.loginUsername.BackColor = System.Drawing.Color.Transparent;
            this.loginUsername.FocusOnHover = false;
            this.loginUsername.Location = new System.Drawing.Point(6, 70);
            this.loginUsername.MaxLength = 32767;
            this.loginUsername.Multiline = false;
            this.loginUsername.Name = "loginUsername";
            this.loginUsername.ReadOnly = false;
            this.loginUsername.Size = new System.Drawing.Size(269, 29);
            this.loginUsername.TabIndex = 1;
            this.loginUsername.Text = "Username";
            this.loginUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.loginUsername.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.loginUsername.UseSystemPasswordChar = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabPage2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            this.tabPage2.Location = new System.Drawing.Point(44, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(835, 230);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            this.tabPage1.Location = new System.Drawing.Point(44, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(835, 230);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(505, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // newsBox
            // 
            this.newsBox.BackColor = System.Drawing.Color.Transparent;
            this.newsBox.Controls.Add(this.newsDate3);
            this.newsBox.Controls.Add(this.newsDate2);
            this.newsBox.Controls.Add(this.newsDate1);
            this.newsBox.Controls.Add(this.newsLabel3);
            this.newsBox.Controls.Add(this.newsLabel2);
            this.newsBox.Controls.Add(this.newsLabel1);
            this.newsBox.Controls.Add(this.newsLink3);
            this.newsBox.Controls.Add(this.newsLink2);
            this.newsBox.Controls.Add(this.newsLink1);
            this.newsBox.Controls.Add(this.iTalk_Separator3);
            this.newsBox.Controls.Add(this.iTalk_Separator2);
            this.newsBox.Controls.Add(this.pictureBox2);
            this.newsBox.Location = new System.Drawing.Point(20, 250);
            this.newsBox.Name = "newsBox";
            this.newsBox.Size = new System.Drawing.Size(505, 187);
            this.newsBox.TabIndex = 6;
            this.newsBox.TabStop = false;
            this.newsBox.Visible = false;
            // 
            // newsDate3
            // 
            this.newsDate3.AutoSize = true;
            this.newsDate3.BackColor = System.Drawing.Color.Transparent;
            this.newsDate3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newsDate3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.newsDate3.Location = new System.Drawing.Point(351, 147);
            this.newsDate3.Name = "newsDate3";
            this.newsDate3.Size = new System.Drawing.Size(80, 21);
            this.newsDate3.TabIndex = 20;
            this.newsDate3.Text = "**/**/****";
            // 
            // newsDate2
            // 
            this.newsDate2.AutoSize = true;
            this.newsDate2.BackColor = System.Drawing.Color.Transparent;
            this.newsDate2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newsDate2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.newsDate2.Location = new System.Drawing.Point(351, 87);
            this.newsDate2.Name = "newsDate2";
            this.newsDate2.Size = new System.Drawing.Size(80, 21);
            this.newsDate2.TabIndex = 19;
            this.newsDate2.Text = "**/**/****";
            // 
            // newsDate1
            // 
            this.newsDate1.AutoSize = true;
            this.newsDate1.BackColor = System.Drawing.Color.Transparent;
            this.newsDate1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newsDate1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.newsDate1.Location = new System.Drawing.Point(351, 32);
            this.newsDate1.Name = "newsDate1";
            this.newsDate1.Size = new System.Drawing.Size(80, 21);
            this.newsDate1.TabIndex = 18;
            this.newsDate1.Text = "**/**/****";
            // 
            // newsLabel3
            // 
            this.newsLabel3.AutoSize = true;
            this.newsLabel3.BackColor = System.Drawing.Color.Transparent;
            this.newsLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newsLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.newsLabel3.Location = new System.Drawing.Point(6, 147);
            this.newsLabel3.Name = "newsLabel3";
            this.newsLabel3.Size = new System.Drawing.Size(126, 21);
            this.newsLabel3.TabIndex = 17;
            this.newsLabel3.Text = "Comming soon";
            // 
            // newsLabel2
            // 
            this.newsLabel2.AutoSize = true;
            this.newsLabel2.BackColor = System.Drawing.Color.Transparent;
            this.newsLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newsLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.newsLabel2.Location = new System.Drawing.Point(6, 87);
            this.newsLabel2.Name = "newsLabel2";
            this.newsLabel2.Size = new System.Drawing.Size(126, 21);
            this.newsLabel2.TabIndex = 16;
            this.newsLabel2.Text = "Comming soon";
            // 
            // newsLabel1
            // 
            this.newsLabel1.AutoSize = true;
            this.newsLabel1.BackColor = System.Drawing.Color.Transparent;
            this.newsLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newsLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.newsLabel1.Location = new System.Drawing.Point(6, 32);
            this.newsLabel1.Name = "newsLabel1";
            this.newsLabel1.Size = new System.Drawing.Size(126, 21);
            this.newsLabel1.TabIndex = 15;
            this.newsLabel1.Text = "Comming soon";
            // 
            // newsLink3
            // 
            this.newsLink3.BackColor = System.Drawing.Color.Transparent;
            this.newsLink3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.newsLink3.Image = null;
            this.newsLink3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newsLink3.Location = new System.Drawing.Point(453, 150);
            this.newsLink3.Name = "newsLink3";
            this.newsLink3.Size = new System.Drawing.Size(35, 18);
            this.newsLink3.TabIndex = 14;
            this.newsLink3.Text = "...";
            this.newsLink3.TextAlignment = System.Drawing.StringAlignment.Center;
            this.newsLink3.Click += new System.EventHandler(this.newsLink3_Click);
            // 
            // newsLink2
            // 
            this.newsLink2.BackColor = System.Drawing.Color.Transparent;
            this.newsLink2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.newsLink2.Image = null;
            this.newsLink2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newsLink2.Location = new System.Drawing.Point(453, 90);
            this.newsLink2.Name = "newsLink2";
            this.newsLink2.Size = new System.Drawing.Size(35, 18);
            this.newsLink2.TabIndex = 13;
            this.newsLink2.Text = "...";
            this.newsLink2.TextAlignment = System.Drawing.StringAlignment.Center;
            this.newsLink2.Click += new System.EventHandler(this.newsLink2_Click);
            // 
            // newsLink1
            // 
            this.newsLink1.BackColor = System.Drawing.Color.Transparent;
            this.newsLink1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.newsLink1.Image = null;
            this.newsLink1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newsLink1.Location = new System.Drawing.Point(453, 35);
            this.newsLink1.Name = "newsLink1";
            this.newsLink1.Size = new System.Drawing.Size(35, 18);
            this.newsLink1.TabIndex = 12;
            this.newsLink1.Text = "...";
            this.newsLink1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.newsLink1.Click += new System.EventHandler(this.newsLink1_Click);
            // 
            // iTalk_Separator3
            // 
            this.iTalk_Separator3.Location = new System.Drawing.Point(6, 64);
            this.iTalk_Separator3.Name = "iTalk_Separator3";
            this.iTalk_Separator3.Size = new System.Drawing.Size(493, 10);
            this.iTalk_Separator3.TabIndex = 11;
            this.iTalk_Separator3.Text = "iTalk_Separator3";
            // 
            // iTalk_Separator2
            // 
            this.iTalk_Separator2.Location = new System.Drawing.Point(6, 125);
            this.iTalk_Separator2.Name = "iTalk_Separator2";
            this.iTalk_Separator2.Size = new System.Drawing.Size(493, 10);
            this.iTalk_Separator2.TabIndex = 10;
            this.iTalk_Separator2.Text = "iTalk_Separator2";
            // 
            // registerBox
            // 
            this.registerBox.BackColor = System.Drawing.Color.Transparent;
            this.registerBox.Controls.Add(this.registerCancel);
            this.registerBox.Controls.Add(this.registerPassConf);
            this.registerBox.Controls.Add(this.registerEmail);
            this.registerBox.Controls.Add(this.pictureBox3);
            this.registerBox.Controls.Add(this.registerButton);
            this.registerBox.Controls.Add(this.registerLabel);
            this.registerBox.Controls.Add(this.registerPass);
            this.registerBox.Controls.Add(this.registerUsername);
            this.registerBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBox.Location = new System.Drawing.Point(322, 143);
            this.registerBox.Name = "registerBox";
            this.registerBox.Size = new System.Drawing.Size(280, 252);
            this.registerBox.TabIndex = 6;
            this.registerBox.TabStop = false;
            this.registerBox.Visible = false;
            // 
            // registerCancel
            // 
            this.registerCancel.BackColor = System.Drawing.Color.Transparent;
            this.registerCancel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.registerCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerCancel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.registerCancel.Location = new System.Drawing.Point(6, 210);
            this.registerCancel.Name = "registerCancel";
            this.registerCancel.Rounded = false;
            this.registerCancel.Size = new System.Drawing.Size(132, 32);
            this.registerCancel.TabIndex = 8;
            this.registerCancel.Text = "Cancel";
            this.registerCancel.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.registerCancel.Click += new System.EventHandler(this.registerCancel_Click);
            // 
            // registerPassConf
            // 
            this.registerPassConf.BackColor = System.Drawing.Color.Transparent;
            this.registerPassConf.FocusOnHover = false;
            this.registerPassConf.Location = new System.Drawing.Point(5, 175);
            this.registerPassConf.MaxLength = 32767;
            this.registerPassConf.Multiline = false;
            this.registerPassConf.Name = "registerPassConf";
            this.registerPassConf.ReadOnly = false;
            this.registerPassConf.Size = new System.Drawing.Size(268, 29);
            this.registerPassConf.TabIndex = 7;
            this.registerPassConf.Text = "0000";
            this.registerPassConf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.registerPassConf.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.registerPassConf.UseSystemPasswordChar = true;
            // 
            // registerEmail
            // 
            this.registerEmail.BackColor = System.Drawing.Color.Transparent;
            this.registerEmail.FocusOnHover = false;
            this.registerEmail.Location = new System.Drawing.Point(6, 105);
            this.registerEmail.MaxLength = 32767;
            this.registerEmail.Multiline = false;
            this.registerEmail.Name = "registerEmail";
            this.registerEmail.ReadOnly = false;
            this.registerEmail.Size = new System.Drawing.Size(267, 29);
            this.registerEmail.TabIndex = 6;
            this.registerEmail.Text = "Email";
            this.registerEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.registerEmail.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.registerEmail.UseSystemPasswordChar = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(280, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.Transparent;
            this.registerButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.registerButton.Location = new System.Drawing.Point(144, 210);
            this.registerButton.Name = "registerButton";
            this.registerButton.Rounded = false;
            this.registerButton.Size = new System.Drawing.Size(129, 32);
            this.registerButton.TabIndex = 4;
            this.registerButton.Text = "Register";
            this.registerButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // registerLabel
            // 
            this.registerLabel.BackColor = System.Drawing.Color.Transparent;
            this.registerLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.registerLabel.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.registerLabel.Location = new System.Drawing.Point(-1, 27);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.registerLabel.Size = new System.Drawing.Size(281, 36);
            this.registerLabel.TabIndex = 3;
            this.registerLabel.Text = "Still not registered?\r\nWhat do you expect?";
            this.registerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // registerPass
            // 
            this.registerPass.BackColor = System.Drawing.Color.Transparent;
            this.registerPass.FocusOnHover = false;
            this.registerPass.Location = new System.Drawing.Point(6, 140);
            this.registerPass.MaxLength = 32767;
            this.registerPass.Multiline = false;
            this.registerPass.Name = "registerPass";
            this.registerPass.ReadOnly = false;
            this.registerPass.Size = new System.Drawing.Size(267, 29);
            this.registerPass.TabIndex = 2;
            this.registerPass.Text = "1234";
            this.registerPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.registerPass.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.registerPass.UseSystemPasswordChar = true;
            // 
            // registerUsername
            // 
            this.registerUsername.BackColor = System.Drawing.Color.Transparent;
            this.registerUsername.FocusOnHover = false;
            this.registerUsername.Location = new System.Drawing.Point(5, 70);
            this.registerUsername.MaxLength = 32767;
            this.registerUsername.Multiline = false;
            this.registerUsername.Name = "registerUsername";
            this.registerUsername.ReadOnly = false;
            this.registerUsername.Size = new System.Drawing.Size(268, 29);
            this.registerUsername.TabIndex = 1;
            this.registerUsername.Text = "Username";
            this.registerUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.registerUsername.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.registerUsername.UseSystemPasswordChar = false;
            // 
            // playerBox
            // 
            this.playerBox.Controls.Add(this.settingsButton);
            this.playerBox.Controls.Add(this.playerStatusLabel);
            this.playerBox.Controls.Add(this.playerEmailLabel);
            this.playerBox.Controls.Add(this.playerUsernameLabel);
            this.playerBox.Controls.Add(this.playerStatus);
            this.playerBox.Controls.Add(this.playerEmail);
            this.playerBox.Controls.Add(this.playerUsername);
            this.playerBox.Controls.Add(this.disconnectButton);
            this.playerBox.Controls.Add(this.pictureBox4);
            this.playerBox.Location = new System.Drawing.Point(20, 63);
            this.playerBox.Name = "playerBox";
            this.playerBox.Size = new System.Drawing.Size(282, 182);
            this.playerBox.TabIndex = 9;
            this.playerBox.TabStop = false;
            this.playerBox.Visible = false;
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.Transparent;
            this.settingsButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.settingsButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.settingsButton.Image = null;
            this.settingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.Location = new System.Drawing.Point(10, 132);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(124, 40);
            this.settingsButton.TabIndex = 17;
            this.settingsButton.Text = "Settings";
            this.settingsButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // playerStatusLabel
            // 
            this.playerStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerStatusLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold);
            this.playerStatusLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.playerStatusLabel.Location = new System.Drawing.Point(7, 83);
            this.playerStatusLabel.Name = "playerStatusLabel";
            this.playerStatusLabel.Size = new System.Drawing.Size(125, 14);
            this.playerStatusLabel.TabIndex = 15;
            this.playerStatusLabel.Text = "Status :";
            // 
            // playerEmailLabel
            // 
            this.playerEmailLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerEmailLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold);
            this.playerEmailLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.playerEmailLabel.Location = new System.Drawing.Point(6, 61);
            this.playerEmailLabel.Name = "playerEmailLabel";
            this.playerEmailLabel.Size = new System.Drawing.Size(126, 14);
            this.playerEmailLabel.TabIndex = 14;
            this.playerEmailLabel.Text = "Email :";
            // 
            // playerUsernameLabel
            // 
            this.playerUsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerUsernameLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold);
            this.playerUsernameLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.playerUsernameLabel.Location = new System.Drawing.Point(6, 36);
            this.playerUsernameLabel.Name = "playerUsernameLabel";
            this.playerUsernameLabel.Size = new System.Drawing.Size(126, 14);
            this.playerUsernameLabel.TabIndex = 12;
            this.playerUsernameLabel.Text = "Username :";
            // 
            // playerStatus
            // 
            this.playerStatus.BackColor = System.Drawing.Color.Transparent;
            this.playerStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.playerStatus.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerStatus.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.playerStatus.Location = new System.Drawing.Point(137, 80);
            this.playerStatus.Name = "playerStatus";
            this.playerStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.playerStatus.Size = new System.Drawing.Size(138, 22);
            this.playerStatus.TabIndex = 16;
            this.playerStatus.Text = "NULL";
            this.playerStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // playerEmail
            // 
            this.playerEmail.BackColor = System.Drawing.Color.Transparent;
            this.playerEmail.Cursor = System.Windows.Forms.Cursors.Default;
            this.playerEmail.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerEmail.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.playerEmail.Location = new System.Drawing.Point(138, 56);
            this.playerEmail.Name = "playerEmail";
            this.playerEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.playerEmail.Size = new System.Drawing.Size(136, 22);
            this.playerEmail.TabIndex = 13;
            this.playerEmail.Text = "NULL";
            this.playerEmail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // playerUsername
            // 
            this.playerUsername.BackColor = System.Drawing.Color.Transparent;
            this.playerUsername.Cursor = System.Windows.Forms.Cursors.Default;
            this.playerUsername.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerUsername.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.playerUsername.Location = new System.Drawing.Point(137, 33);
            this.playerUsername.Name = "playerUsername";
            this.playerUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.playerUsername.Size = new System.Drawing.Size(138, 22);
            this.playerUsername.TabIndex = 10;
            this.playerUsername.Text = "NULL";
            this.playerUsername.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // disconnectButton
            // 
            this.disconnectButton.BackColor = System.Drawing.Color.Transparent;
            this.disconnectButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.disconnectButton.Image = null;
            this.disconnectButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.disconnectButton.Location = new System.Drawing.Point(140, 133);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(136, 39);
            this.disconnectButton.TabIndex = 11;
            this.disconnectButton.Text = "Log Out";
            this.disconnectButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(285, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBig
            // 
            this.pictureBig.BackColor = System.Drawing.Color.Transparent;
            this.pictureBig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBig.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBig.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBig.ErrorImage")));
            this.pictureBig.Image = ((System.Drawing.Image)(resources.GetObject("pictureBig.Image")));
            this.pictureBig.InitialImage = null;
            this.pictureBig.Location = new System.Drawing.Point(20, 60);
            this.pictureBig.Name = "pictureBig";
            this.pictureBig.Size = new System.Drawing.Size(883, 421);
            this.pictureBig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBig.TabIndex = 3;
            this.pictureBig.TabStop = false;
            // 
            // flatProgressBar1
            // 
            this.flatProgressBar1.BackColor = System.Drawing.SystemColors.Control;
            this.flatProgressBar1.DarkerProgress = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(148)))), ((int)(((byte)(92)))));
            this.flatProgressBar1.Location = new System.Drawing.Point(20, 439);
            this.flatProgressBar1.Maximum = 100;
            this.flatProgressBar1.Name = "flatProgressBar1";
            this.flatProgressBar1.Pattern = true;
            this.flatProgressBar1.PercentSign = false;
            this.flatProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatProgressBar1.ShowBalloon = true;
            this.flatProgressBar1.Size = new System.Drawing.Size(883, 42);
            this.flatProgressBar1.TabIndex = 8;
            this.flatProgressBar1.Text = "flatProgressBar1";
            this.flatProgressBar1.Value = 50;
            this.flatProgressBar1.Visible = false;
            // 
            // staffMessage
            // 
            this.staffMessage.BackColor = System.Drawing.Color.Transparent;
            this.staffMessage.FocusOnHover = false;
            this.staffMessage.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffMessage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.staffMessage.Location = new System.Drawing.Point(215, 25);
            this.staffMessage.MaxLength = 32767;
            this.staffMessage.Multiline = false;
            this.staffMessage.Name = "staffMessage";
            this.staffMessage.ReadOnly = true;
            this.staffMessage.Size = new System.Drawing.Size(639, 27);
            this.staffMessage.TabIndex = 5;
            this.staffMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.staffMessage.TextColor = System.Drawing.Color.Gray;
            this.staffMessage.UseSystemPasswordChar = false;
            this.staffMessage.Visible = false;
            // 
            // errorBox
            // 
            this.errorBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.errorBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.errorBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.errorBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.errorBox.kind = FlatUI.FlatAlertBox._Kind.Error;
            this.errorBox.Location = new System.Drawing.Point(301, 63);
            this.errorBox.Name = "errorBox";
            this.errorBox.Size = new System.Drawing.Size(327, 42);
            this.errorBox.TabIndex = 2;
            this.errorBox.Visible = false;
            // 
            // succesBox
            // 
            this.succesBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.succesBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.succesBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.succesBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.succesBox.kind = FlatUI.FlatAlertBox._Kind.Success;
            this.succesBox.Location = new System.Drawing.Point(302, 63);
            this.succesBox.Name = "succesBox";
            this.succesBox.Size = new System.Drawing.Size(327, 42);
            this.succesBox.TabIndex = 1;
            this.succesBox.Visible = false;
            // 
            // infoBox
            // 
            this.infoBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.infoBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infoBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.infoBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.infoBox.kind = FlatUI.FlatAlertBox._Kind.Info;
            this.infoBox.Location = new System.Drawing.Point(301, 63);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(327, 42);
            this.infoBox.TabIndex = 0;
            this.infoBox.Visible = false;
            // 
            // launcherMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 501);
            this.Controls.Add(this.flatProgressBar1);
            this.Controls.Add(this.staffMessage);
            this.Controls.Add(this.newsBox);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.registerBox);
            this.Controls.Add(this.playerBox);
            this.Controls.Add(this.errorBox);
            this.Controls.Add(this.succesBox);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.pictureBig);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "launcherMain";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Launcher Arma3";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.launcherMain_Load);
            this.VisibleChanged += new System.EventHandler(this.checkOptions);
            this.loginBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.newsBox.ResumeLayout(false);
            this.newsBox.PerformLayout();
            this.registerBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.playerBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBig)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        private FlatUI.FlatAlertBox infoBox;
        private FlatUI.FlatAlertBox succesBox;
        private FlatUI.FlatAlertBox errorBox;
        private System.Windows.Forms.GroupBox loginBox;
        private FlatUI.FlatTextBox loginUsername;
        private FlatUI.FlatButton loginButton;
        private FlatUI.FlatLabel loginLabel;
        private FlatUI.FlatTextBox loginPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FlatUI.FlatTextBox staffMessage;
        private FlatUI.FlatProgressBar flatProgressBar1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox newsBox;
        private System.Windows.Forms.GroupBox registerBox;
        private FlatUI.FlatTextBox registerEmail;
        private System.Windows.Forms.PictureBox pictureBox3;
        private FlatUI.FlatButton registerButton;
        private FlatUI.FlatLabel registerLabel;
        private FlatUI.FlatTextBox registerPass;
        private FlatUI.FlatTextBox registerUsername;
        private FlatUI.FlatTextBox registerPassConf;
        private System.Windows.Forms.LinkLabel registerLink;
        private FlatUI.FlatButton registerCancel;
        private iTalk.iTalk_Button_1 newsLink3;
        private iTalk.iTalk_Button_1 newsLink2;
        private iTalk.iTalk_Button_1 newsLink1;
        private iTalk.iTalk_Separator iTalk_Separator3;
        private iTalk.iTalk_Separator iTalk_Separator2;
        private iTalk.iTalk_Label newsLabel3;
        private iTalk.iTalk_Label newsLabel2;
        private iTalk.iTalk_Label newsLabel1;
        private iTalk.iTalk_Label newsDate3;
        private iTalk.iTalk_Label newsDate2;
        private iTalk.iTalk_Label newsDate1;
        private FlatUI.FlatCheckBox loginRemember;
        private FlatUI.FlatLabel loginRememberLabel;
        private System.Windows.Forms.GroupBox playerBox;
        private System.Windows.Forms.PictureBox pictureBox4;
        private MonoFlat.MonoFlat_Button disconnectButton;
        private FlatUI.FlatLabel playerUsernameLabel;
        private FlatUI.FlatLabel playerUsername;
        private FlatUI.FlatLabel playerEmail;
        private FlatUI.FlatLabel playerEmailLabel;
        private FlatUI.FlatLabel playerStatus;
        private FlatUI.FlatLabel playerStatusLabel;
        private System.Windows.Forms.LinkLabel loginForgot;
        private iTalk.iTalk_Button_1 settingsButton;
        private System.Windows.Forms.PictureBox pictureBig;
    }
}