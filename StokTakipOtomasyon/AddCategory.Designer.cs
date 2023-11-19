namespace StokTakipOtomasyon
{
    partial class AddCategory
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
            this.AddCategory_buttonExit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddCategory_textboxCategory = new System.Windows.Forms.TextBox();
            this.AddCategory_buttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AddCategory_buttonExit)).BeginInit();
            this.SuspendLayout();
            // 
            // AddCategory_buttonExit
            // 
            this.AddCategory_buttonExit.BackgroundImage = global::StokTakipOtomasyon.Properties.Resources.exitButton;
            this.AddCategory_buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddCategory_buttonExit.Location = new System.Drawing.Point(258, 12);
            this.AddCategory_buttonExit.Name = "AddCategory_buttonExit";
            this.AddCategory_buttonExit.Size = new System.Drawing.Size(30, 30);
            this.AddCategory_buttonExit.TabIndex = 21;
            this.AddCategory_buttonExit.TabStop = false;
            this.AddCategory_buttonExit.Click += new System.EventHandler(this.AddCategory_buttonExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Category:";
            // 
            // AddCategory_textboxCategory
            // 
            this.AddCategory_textboxCategory.BackColor = System.Drawing.SystemColors.Control;
            this.AddCategory_textboxCategory.Location = new System.Drawing.Point(71, 66);
            this.AddCategory_textboxCategory.Name = "AddCategory_textboxCategory";
            this.AddCategory_textboxCategory.Size = new System.Drawing.Size(162, 20);
            this.AddCategory_textboxCategory.TabIndex = 23;
            // 
            // AddCategory_buttonAdd
            // 
            this.AddCategory_buttonAdd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.AddCategory_buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddCategory_buttonAdd.Location = new System.Drawing.Point(158, 112);
            this.AddCategory_buttonAdd.Name = "AddCategory_buttonAdd";
            this.AddCategory_buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.AddCategory_buttonAdd.TabIndex = 24;
            this.AddCategory_buttonAdd.Text = "Add";
            this.AddCategory_buttonAdd.UseVisualStyleBackColor = false;
            this.AddCategory_buttonAdd.Click += new System.EventHandler(this.AddCategory_buttonAdd_Click);
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.AddCategory_buttonAdd);
            this.Controls.Add(this.AddCategory_textboxCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddCategory_buttonExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCategory";
            this.Load += new System.EventHandler(this.AddCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AddCategory_buttonExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox AddCategory_buttonExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddCategory_textboxCategory;
        private System.Windows.Forms.Button AddCategory_buttonAdd;
    }
}