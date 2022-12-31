namespace StokTakipOtomasyon
{
    partial class ResetPassword
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
            this.resetPassword_buttonSend = new System.Windows.Forms.Button();
            this.resetPassword_buttonVerify = new System.Windows.Forms.Button();
            this.resetPassword_email = new System.Windows.Forms.TextBox();
            this.resetPassword_veify = new System.Windows.Forms.TextBox();
            this.resetPassword_lblEmail = new System.Windows.Forms.Label();
            this.resetPassword_lblVerificationCode = new System.Windows.Forms.Label();
            this.resetPassword_buttonExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.resetPassword_buttonExit)).BeginInit();
            this.SuspendLayout();
            // 
            // resetPassword_buttonSend
            // 
            this.resetPassword_buttonSend.Location = new System.Drawing.Point(240, 110);
            this.resetPassword_buttonSend.Name = "resetPassword_buttonSend";
            this.resetPassword_buttonSend.Size = new System.Drawing.Size(75, 23);
            this.resetPassword_buttonSend.TabIndex = 0;
            this.resetPassword_buttonSend.Text = "Send";
            this.resetPassword_buttonSend.UseVisualStyleBackColor = true;
            // 
            // resetPassword_buttonVerify
            // 
            this.resetPassword_buttonVerify.Location = new System.Drawing.Point(240, 210);
            this.resetPassword_buttonVerify.Name = "resetPassword_buttonVerify";
            this.resetPassword_buttonVerify.Size = new System.Drawing.Size(75, 23);
            this.resetPassword_buttonVerify.TabIndex = 1;
            this.resetPassword_buttonVerify.Text = "Verify";
            this.resetPassword_buttonVerify.UseVisualStyleBackColor = true;
            this.resetPassword_buttonVerify.Click += new System.EventHandler(this.resetPassword_buttonVerify_Click);
            // 
            // resetPassword_email
            // 
            this.resetPassword_email.Location = new System.Drawing.Point(38, 84);
            this.resetPassword_email.Name = "resetPassword_email";
            this.resetPassword_email.Size = new System.Drawing.Size(277, 20);
            this.resetPassword_email.TabIndex = 2;
            // 
            // resetPassword_veify
            // 
            this.resetPassword_veify.Location = new System.Drawing.Point(38, 184);
            this.resetPassword_veify.Name = "resetPassword_veify";
            this.resetPassword_veify.Size = new System.Drawing.Size(277, 20);
            this.resetPassword_veify.TabIndex = 3;
            // 
            // resetPassword_lblEmail
            // 
            this.resetPassword_lblEmail.AutoSize = true;
            this.resetPassword_lblEmail.Location = new System.Drawing.Point(35, 55);
            this.resetPassword_lblEmail.Name = "resetPassword_lblEmail";
            this.resetPassword_lblEmail.Size = new System.Drawing.Size(35, 13);
            this.resetPassword_lblEmail.TabIndex = 4;
            this.resetPassword_lblEmail.Text = "Email:";
            // 
            // resetPassword_lblVerificationCode
            // 
            this.resetPassword_lblVerificationCode.AutoSize = true;
            this.resetPassword_lblVerificationCode.Location = new System.Drawing.Point(35, 155);
            this.resetPassword_lblVerificationCode.Name = "resetPassword_lblVerificationCode";
            this.resetPassword_lblVerificationCode.Size = new System.Drawing.Size(90, 13);
            this.resetPassword_lblVerificationCode.TabIndex = 5;
            this.resetPassword_lblVerificationCode.Text = "Verification Code:";
            // 
            // resetPassword_buttonExit
            // 
            this.resetPassword_buttonExit.BackgroundImage = global::StokTakipOtomasyon.Properties.Resources.exitButton;
            this.resetPassword_buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.resetPassword_buttonExit.Location = new System.Drawing.Point(342, 12);
            this.resetPassword_buttonExit.Name = "resetPassword_buttonExit";
            this.resetPassword_buttonExit.Size = new System.Drawing.Size(30, 30);
            this.resetPassword_buttonExit.TabIndex = 6;
            this.resetPassword_buttonExit.TabStop = false;
            this.resetPassword_buttonExit.Click += new System.EventHandler(this.resetPassword_buttonExit_Click);
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 264);
            this.Controls.Add(this.resetPassword_buttonExit);
            this.Controls.Add(this.resetPassword_lblVerificationCode);
            this.Controls.Add(this.resetPassword_lblEmail);
            this.Controls.Add(this.resetPassword_veify);
            this.Controls.Add(this.resetPassword_email);
            this.Controls.Add(this.resetPassword_buttonVerify);
            this.Controls.Add(this.resetPassword_buttonSend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResetPassword";
            ((System.ComponentModel.ISupportInitialize)(this.resetPassword_buttonExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resetPassword_buttonSend;
        private System.Windows.Forms.Button resetPassword_buttonVerify;
        private System.Windows.Forms.TextBox resetPassword_email;
        private System.Windows.Forms.TextBox resetPassword_veify;
        private System.Windows.Forms.Label resetPassword_lblEmail;
        private System.Windows.Forms.Label resetPassword_lblVerificationCode;
        private System.Windows.Forms.PictureBox resetPassword_buttonExit;
    }
}