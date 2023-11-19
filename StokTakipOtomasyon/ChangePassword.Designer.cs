namespace StokTakipOtomasyon
{
    partial class ChangePassword
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
            this.changePassword_textBoxPassword1 = new System.Windows.Forms.TextBox();
            this.changePassword_textBoxPassword2 = new System.Windows.Forms.TextBox();
            this.changePassword_lblPassword1 = new System.Windows.Forms.Label();
            this.changePassword_lblPassword2 = new System.Windows.Forms.Label();
            this.changePassword_buttonChange = new System.Windows.Forms.Button();
            this.changePassword_buttonExit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.changePassword_textBoxEmail = new System.Windows.Forms.TextBox();
            this.changePassword_buttonSend = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.changePassword_textBoxVerify = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.changePassword_buttonExit)).BeginInit();
            this.SuspendLayout();
            // 
            // changePassword_textBoxPassword1
            // 
            this.changePassword_textBoxPassword1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.changePassword_textBoxPassword1.Location = new System.Drawing.Point(135, 146);
            this.changePassword_textBoxPassword1.Name = "changePassword_textBoxPassword1";
            this.changePassword_textBoxPassword1.Size = new System.Drawing.Size(179, 20);
            this.changePassword_textBoxPassword1.TabIndex = 2;
            // 
            // changePassword_textBoxPassword2
            // 
            this.changePassword_textBoxPassword2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.changePassword_textBoxPassword2.Location = new System.Drawing.Point(135, 184);
            this.changePassword_textBoxPassword2.Name = "changePassword_textBoxPassword2";
            this.changePassword_textBoxPassword2.Size = new System.Drawing.Size(179, 20);
            this.changePassword_textBoxPassword2.TabIndex = 3;
            // 
            // changePassword_lblPassword1
            // 
            this.changePassword_lblPassword1.AutoSize = true;
            this.changePassword_lblPassword1.Location = new System.Drawing.Point(58, 148);
            this.changePassword_lblPassword1.Name = "changePassword_lblPassword1";
            this.changePassword_lblPassword1.Size = new System.Drawing.Size(56, 13);
            this.changePassword_lblPassword1.TabIndex = 2;
            this.changePassword_lblPassword1.Text = "Password:";
            // 
            // changePassword_lblPassword2
            // 
            this.changePassword_lblPassword2.AutoSize = true;
            this.changePassword_lblPassword2.Location = new System.Drawing.Point(32, 185);
            this.changePassword_lblPassword2.Name = "changePassword_lblPassword2";
            this.changePassword_lblPassword2.Size = new System.Drawing.Size(82, 13);
            this.changePassword_lblPassword2.TabIndex = 3;
            this.changePassword_lblPassword2.Text = "Verify Password";
            // 
            // changePassword_buttonChange
            // 
            this.changePassword_buttonChange.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.changePassword_buttonChange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changePassword_buttonChange.Location = new System.Drawing.Point(269, 211);
            this.changePassword_buttonChange.Name = "changePassword_buttonChange";
            this.changePassword_buttonChange.Size = new System.Drawing.Size(75, 23);
            this.changePassword_buttonChange.TabIndex = 4;
            this.changePassword_buttonChange.Text = "Change";
            this.changePassword_buttonChange.UseVisualStyleBackColor = false;
            this.changePassword_buttonChange.Click += new System.EventHandler(this.changePassword_buttonChange_Click);
            // 
            // changePassword_buttonExit
            // 
            this.changePassword_buttonExit.BackgroundImage = global::StokTakipOtomasyon.Properties.Resources.exitButton;
            this.changePassword_buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.changePassword_buttonExit.Location = new System.Drawing.Point(342, 12);
            this.changePassword_buttonExit.Name = "changePassword_buttonExit";
            this.changePassword_buttonExit.Size = new System.Drawing.Size(30, 30);
            this.changePassword_buttonExit.TabIndex = 5;
            this.changePassword_buttonExit.TabStop = false;
            this.changePassword_buttonExit.Click += new System.EventHandler(this.changePassword_buttonExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Email:";
            // 
            // changePassword_textBoxEmail
            // 
            this.changePassword_textBoxEmail.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.changePassword_textBoxEmail.Location = new System.Drawing.Point(132, 38);
            this.changePassword_textBoxEmail.Name = "changePassword_textBoxEmail";
            this.changePassword_textBoxEmail.Size = new System.Drawing.Size(179, 20);
            this.changePassword_textBoxEmail.TabIndex = 1;
            // 
            // changePassword_buttonSend
            // 
            this.changePassword_buttonSend.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.changePassword_buttonSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changePassword_buttonSend.Location = new System.Drawing.Point(269, 64);
            this.changePassword_buttonSend.Name = "changePassword_buttonSend";
            this.changePassword_buttonSend.Size = new System.Drawing.Size(75, 23);
            this.changePassword_buttonSend.TabIndex = 7;
            this.changePassword_buttonSend.Text = "Send";
            this.changePassword_buttonSend.UseVisualStyleBackColor = false;
            this.changePassword_buttonSend.Click += new System.EventHandler(this.changePassword_buttonSend_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Verification Code:";
            // 
            // changePassword_textBoxVerify
            // 
            this.changePassword_textBoxVerify.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.changePassword_textBoxVerify.Location = new System.Drawing.Point(135, 108);
            this.changePassword_textBoxVerify.Name = "changePassword_textBoxVerify";
            this.changePassword_textBoxVerify.Size = new System.Drawing.Size(179, 20);
            this.changePassword_textBoxVerify.TabIndex = 9;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(384, 264);
            this.Controls.Add(this.changePassword_textBoxVerify);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.changePassword_buttonSend);
            this.Controls.Add(this.changePassword_textBoxEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.changePassword_buttonExit);
            this.Controls.Add(this.changePassword_buttonChange);
            this.Controls.Add(this.changePassword_lblPassword2);
            this.Controls.Add(this.changePassword_lblPassword1);
            this.Controls.Add(this.changePassword_textBoxPassword2);
            this.Controls.Add(this.changePassword_textBoxPassword1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            ((System.ComponentModel.ISupportInitialize)(this.changePassword_buttonExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox changePassword_textBoxPassword1;
        private System.Windows.Forms.TextBox changePassword_textBoxPassword2;
        private System.Windows.Forms.Label changePassword_lblPassword1;
        private System.Windows.Forms.Label changePassword_lblPassword2;
        private System.Windows.Forms.Button changePassword_buttonChange;
        private System.Windows.Forms.PictureBox changePassword_buttonExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox changePassword_textBoxEmail;
        private System.Windows.Forms.Button changePassword_buttonSend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox changePassword_textBoxVerify;
    }
}