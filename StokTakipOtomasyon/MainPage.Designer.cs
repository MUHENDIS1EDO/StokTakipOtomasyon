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
            this.label1 = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.textbox_email = new System.Windows.Forms.TextBox();
            this.textbox_password = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.PanelSignUp = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.lbl_newHere = new System.Windows.Forms.Label();
            this.button_hideShow = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.PanelSignUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.button_hideShow);
            this.panel1.Controls.Add(this.lbl_password);
            this.panel1.Controls.Add(this.lbl_email);
            this.panel1.Controls.Add(this.textbox_password);
            this.panel1.Controls.Add(this.textbox_email);
            this.panel1.Controls.Add(this.button_login);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 476);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(24, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login to Your Account";
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.SeaGreen;
            this.button_login.FlatAppearance.BorderSize = 0;
            this.button_login.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.ForeColor = System.Drawing.Color.White;
            this.button_login.Location = new System.Drawing.Point(158, 334);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(105, 44);
            this.button_login.TabIndex = 3;
            this.button_login.Text = "Sign In";
            this.button_login.UseVisualStyleBackColor = false;
            // 
            // textbox_email
            // 
            this.textbox_email.Location = new System.Drawing.Point(94, 214);
            this.textbox_email.Name = "textbox_email";
            this.textbox_email.Size = new System.Drawing.Size(283, 20);
            this.textbox_email.TabIndex = 1;
            this.textbox_email.TextChanged += new System.EventHandler(this.textbox_email_TextChanged);
            // 
            // textbox_password
            // 
            this.textbox_password.Location = new System.Drawing.Point(94, 267);
            this.textbox_password.Name = "textbox_password";
            this.textbox_password.PasswordChar = '*';
            this.textbox_password.Size = new System.Drawing.Size(283, 20);
            this.textbox_password.TabIndex = 2;
            this.textbox_password.TextChanged += new System.EventHandler(this.textbox_password_TextChanged);
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(29, 217);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(35, 13);
            this.lbl_email.TabIndex = 4;
            this.lbl_email.Text = "Email:";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(23, 270);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(56, 13);
            this.lbl_password.TabIndex = 5;
            this.lbl_password.Text = "Password:";
            // 
            // PanelSignUp
            // 
            this.PanelSignUp.BackColor = System.Drawing.Color.Transparent;
            this.PanelSignUp.BackgroundImage = global::StokTakipOtomasyon.Properties.Resources.backgroundMainPage;
            this.PanelSignUp.Controls.Add(this.label2);
            this.PanelSignUp.Controls.Add(this.button2);
            this.PanelSignUp.Controls.Add(this.exitButton);
            this.PanelSignUp.Controls.Add(this.lbl_newHere);
            this.PanelSignUp.Location = new System.Drawing.Point(464, -1);
            this.PanelSignUp.Name = "PanelSignUp";
            this.PanelSignUp.Size = new System.Drawing.Size(429, 476);
            this.PanelSignUp.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(396, 51);
            this.label2.TabIndex = 2;
            this.label2.Text = "                                Not a member yet?\r\nRegister below to start buildi" +
    "ng your sign up page in minutes. \r\n                                        It\'s " +
    "easy!";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(155, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 44);
            this.button2.TabIndex = 0;
            this.button2.TabStop = false;
            this.button2.Text = "Sign Up";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // exitButton
            // 
            this.exitButton.BackgroundImage = global::StokTakipOtomasyon.Properties.Resources.exitButton;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitButton.Location = new System.Drawing.Point(378, 13);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(30, 30);
            this.exitButton.TabIndex = 1;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_newHere
            // 
            this.lbl_newHere.AutoSize = true;
            this.lbl_newHere.Font = new System.Drawing.Font("Microsoft Uighur", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_newHere.ForeColor = System.Drawing.Color.White;
            this.lbl_newHere.Location = new System.Drawing.Point(96, 167);
            this.lbl_newHere.Name = "lbl_newHere";
            this.lbl_newHere.Size = new System.Drawing.Size(201, 63);
            this.lbl_newHere.TabIndex = 0;
            this.lbl_newHere.Text = "New Here?";
            // 
            // button_hideShow
            // 
            this.button_hideShow.BackColor = System.Drawing.Color.White;
            this.button_hideShow.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_hideShow.Location = new System.Drawing.Point(319, 267);
            this.button_hideShow.Name = "button_hideShow";
            this.button_hideShow.Size = new System.Drawing.Size(58, 21);
            this.button_hideShow.TabIndex = 0;
            this.button_hideShow.TabStop = false;
            this.button_hideShow.Text = "SHOW";
            this.button_hideShow.UseCompatibleTextRendering = true;
            this.button_hideShow.UseVisualStyleBackColor = false;
            this.button_hideShow.Click += new System.EventHandler(this.button_hideShow_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 464);
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
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelSignUp;
        private System.Windows.Forms.Label lbl_newHere;
        private System.Windows.Forms.PictureBox exitButton;
        private System.Windows.Forms.TextBox textbox_password;
        private System.Windows.Forms.TextBox textbox_email;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_hideShow;
    }
}

