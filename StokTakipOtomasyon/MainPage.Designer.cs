namespace StokTakipOtomasyon
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_resetPassword = new System.Windows.Forms.Label();
            this.mainPage_buttonHideShow = new System.Windows.Forms.Button();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.mainPage_textboxPassword = new System.Windows.Forms.TextBox();
            this.mainPage_textboxEmail = new System.Windows.Forms.TextBox();
            this.mainPage_buttonLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelSignUp = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.mainPage_buttonSignUp = new System.Windows.Forms.Button();
            this.mainPage_buttonExit = new System.Windows.Forms.PictureBox();
            this.lbl_newHere = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.PanelSignUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPage_buttonExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.lbl_resetPassword);
            this.panel1.Controls.Add(this.mainPage_buttonHideShow);
            this.panel1.Controls.Add(this.lbl_password);
            this.panel1.Controls.Add(this.lbl_email);
            this.panel1.Controls.Add(this.mainPage_textboxPassword);
            this.panel1.Controls.Add(this.mainPage_textboxEmail);
            this.panel1.Controls.Add(this.mainPage_buttonLogin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 608);
            this.panel1.TabIndex = 6;
            // 
            // lbl_resetPassword
            // 
            this.lbl_resetPassword.AutoSize = true;
            this.lbl_resetPassword.ForeColor = System.Drawing.Color.White;
            this.lbl_resetPassword.Location = new System.Drawing.Point(340, 394);
            this.lbl_resetPassword.Name = "lbl_resetPassword";
            this.lbl_resetPassword.Size = new System.Drawing.Size(90, 13);
            this.lbl_resetPassword.TabIndex = 6;
            this.lbl_resetPassword.Text = "Reset Password?";
            this.lbl_resetPassword.Click += new System.EventHandler(this.lbl_resetPassword_Click);
            // 
            // mainPage_buttonHideShow
            // 
            this.mainPage_buttonHideShow.BackColor = System.Drawing.Color.White;
            this.mainPage_buttonHideShow.FlatAppearance.BorderSize = 0;
            this.mainPage_buttonHideShow.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainPage_buttonHideShow.Location = new System.Drawing.Point(372, 356);
            this.mainPage_buttonHideShow.Name = "mainPage_buttonHideShow";
            this.mainPage_buttonHideShow.Size = new System.Drawing.Size(58, 20);
            this.mainPage_buttonHideShow.TabIndex = 0;
            this.mainPage_buttonHideShow.TabStop = false;
            this.mainPage_buttonHideShow.Text = "SHOW";
            this.mainPage_buttonHideShow.UseCompatibleTextRendering = true;
            this.mainPage_buttonHideShow.UseVisualStyleBackColor = false;
            this.mainPage_buttonHideShow.Click += new System.EventHandler(this.button_hideShow_Click);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(76, 359);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(56, 13);
            this.lbl_password.TabIndex = 5;
            this.lbl_password.Text = "Password:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(82, 306);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(35, 13);
            this.lbl_email.TabIndex = 4;
            this.lbl_email.Text = "Email:";
            // 
            // mainPage_textboxPassword
            // 
            this.mainPage_textboxPassword.Location = new System.Drawing.Point(147, 356);
            this.mainPage_textboxPassword.Name = "mainPage_textboxPassword";
            this.mainPage_textboxPassword.PasswordChar = '*';
            this.mainPage_textboxPassword.Size = new System.Drawing.Size(283, 20);
            this.mainPage_textboxPassword.TabIndex = 2;
            // 
            // mainPage_textboxEmail
            // 
            this.mainPage_textboxEmail.Location = new System.Drawing.Point(147, 303);
            this.mainPage_textboxEmail.Name = "mainPage_textboxEmail";
            this.mainPage_textboxEmail.Size = new System.Drawing.Size(283, 20);
            this.mainPage_textboxEmail.TabIndex = 1;
            // 
            // mainPage_buttonLogin
            // 
            this.mainPage_buttonLogin.BackColor = System.Drawing.Color.SeaGreen;
            this.mainPage_buttonLogin.FlatAppearance.BorderSize = 0;
            this.mainPage_buttonLogin.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainPage_buttonLogin.ForeColor = System.Drawing.Color.White;
            this.mainPage_buttonLogin.Location = new System.Drawing.Point(211, 423);
            this.mainPage_buttonLogin.Name = "mainPage_buttonLogin";
            this.mainPage_buttonLogin.Size = new System.Drawing.Size(105, 44);
            this.mainPage_buttonLogin.TabIndex = 3;
            this.mainPage_buttonLogin.Text = "Login";
            this.mainPage_buttonLogin.UseVisualStyleBackColor = false;
            this.mainPage_buttonLogin.Click += new System.EventHandler(this.mainPage_buttonLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(56, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login to Your Account";
            // 
            // PanelSignUp
            // 
            this.PanelSignUp.BackColor = System.Drawing.Color.Transparent;
            this.PanelSignUp.BackgroundImage = global::StokTakipOtomasyon.Properties.Resources.backgroundMainPage;
            this.PanelSignUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelSignUp.Controls.Add(this.label2);
            this.PanelSignUp.Controls.Add(this.mainPage_buttonSignUp);
            this.PanelSignUp.Controls.Add(this.mainPage_buttonExit);
            this.PanelSignUp.Controls.Add(this.lbl_newHere);
            this.PanelSignUp.Location = new System.Drawing.Point(550, -1);
            this.PanelSignUp.Name = "PanelSignUp";
            this.PanelSignUp.Size = new System.Drawing.Size(715, 626);
            this.PanelSignUp.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(145, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(396, 51);
            this.label2.TabIndex = 2;
            this.label2.Text = "                                Not a member yet?\r\nRegister below to start buildi" +
    "ng your sign up page in minutes. \r\n                                        It\'s " +
    "easy!";
            // 
            // mainPage_buttonSignUp
            // 
            this.mainPage_buttonSignUp.BackColor = System.Drawing.Color.White;
            this.mainPage_buttonSignUp.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainPage_buttonSignUp.Location = new System.Drawing.Point(281, 362);
            this.mainPage_buttonSignUp.Name = "mainPage_buttonSignUp";
            this.mainPage_buttonSignUp.Size = new System.Drawing.Size(105, 44);
            this.mainPage_buttonSignUp.TabIndex = 0;
            this.mainPage_buttonSignUp.TabStop = false;
            this.mainPage_buttonSignUp.Text = "Sign Up";
            this.mainPage_buttonSignUp.UseVisualStyleBackColor = false;
            this.mainPage_buttonSignUp.Click += new System.EventHandler(this.mainPage_buttonSignUp_Click);
            // 
            // mainPage_buttonExit
            // 
            this.mainPage_buttonExit.BackgroundImage = global::StokTakipOtomasyon.Properties.Resources.exitButton;
            this.mainPage_buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mainPage_buttonExit.Location = new System.Drawing.Point(607, 12);
            this.mainPage_buttonExit.Name = "mainPage_buttonExit";
            this.mainPage_buttonExit.Size = new System.Drawing.Size(30, 30);
            this.mainPage_buttonExit.TabIndex = 1;
            this.mainPage_buttonExit.TabStop = false;
            this.mainPage_buttonExit.Click += new System.EventHandler(this.mainPage_buttonExit_Click_1);
            // 
            // lbl_newHere
            // 
            this.lbl_newHere.AutoSize = true;
            this.lbl_newHere.Font = new System.Drawing.Font("Microsoft Uighur", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_newHere.ForeColor = System.Drawing.Color.White;
            this.lbl_newHere.Location = new System.Drawing.Point(238, 196);
            this.lbl_newHere.Name = "lbl_newHere";
            this.lbl_newHere.Size = new System.Drawing.Size(201, 63);
            this.lbl_newHere.TabIndex = 0;
            this.lbl_newHere.Text = "New Here?";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.PanelSignUp);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelSignUp.ResumeLayout(false);
            this.PanelSignUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPage_buttonExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelSignUp;
        private System.Windows.Forms.Label lbl_newHere;
        private System.Windows.Forms.PictureBox mainPage_buttonExit;
        private System.Windows.Forms.TextBox mainPage_textboxPassword;
        private System.Windows.Forms.TextBox mainPage_textboxEmail;
        private System.Windows.Forms.Button mainPage_buttonLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button mainPage_buttonSignUp;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button mainPage_buttonHideShow;
        private System.Windows.Forms.Label lbl_resetPassword;
    }
}

