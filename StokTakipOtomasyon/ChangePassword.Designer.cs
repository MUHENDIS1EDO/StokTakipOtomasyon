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
            ((System.ComponentModel.ISupportInitialize)(this.changePassword_buttonExit)).BeginInit();
            this.SuspendLayout();
            // 
            // changePassword_textBoxPassword1
            // 
            this.changePassword_textBoxPassword1.Location = new System.Drawing.Point(130, 48);
            this.changePassword_textBoxPassword1.Name = "changePassword_textBoxPassword1";
            this.changePassword_textBoxPassword1.Size = new System.Drawing.Size(179, 20);
            this.changePassword_textBoxPassword1.TabIndex = 0;
            // 
            // changePassword_textBoxPassword2
            // 
            this.changePassword_textBoxPassword2.Location = new System.Drawing.Point(130, 92);
            this.changePassword_textBoxPassword2.Name = "changePassword_textBoxPassword2";
            this.changePassword_textBoxPassword2.Size = new System.Drawing.Size(179, 20);
            this.changePassword_textBoxPassword2.TabIndex = 1;
            // 
            // changePassword_lblPassword1
            // 
            this.changePassword_lblPassword1.AutoSize = true;
            this.changePassword_lblPassword1.Location = new System.Drawing.Point(31, 48);
            this.changePassword_lblPassword1.Name = "changePassword_lblPassword1";
            this.changePassword_lblPassword1.Size = new System.Drawing.Size(56, 13);
            this.changePassword_lblPassword1.TabIndex = 2;
            this.changePassword_lblPassword1.Text = "Password:";
            // 
            // changePassword_lblPassword2
            // 
            this.changePassword_lblPassword2.AutoSize = true;
            this.changePassword_lblPassword2.Location = new System.Drawing.Point(31, 92);
            this.changePassword_lblPassword2.Name = "changePassword_lblPassword2";
            this.changePassword_lblPassword2.Size = new System.Drawing.Size(82, 13);
            this.changePassword_lblPassword2.TabIndex = 3;
            this.changePassword_lblPassword2.Text = "Verify Password";
            // 
            // changePassword_buttonChange
            // 
            this.changePassword_buttonChange.Location = new System.Drawing.Point(261, 138);
            this.changePassword_buttonChange.Name = "changePassword_buttonChange";
            this.changePassword_buttonChange.Size = new System.Drawing.Size(75, 23);
            this.changePassword_buttonChange.TabIndex = 4;
            this.changePassword_buttonChange.Text = "Change";
            this.changePassword_buttonChange.UseVisualStyleBackColor = true;
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
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 264);
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
    }
}