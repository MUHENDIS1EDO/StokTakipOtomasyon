namespace StokTakipOtomasyon
{
    partial class AddBrand
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
            this.AddBrand_buttonExit = new System.Windows.Forms.PictureBox();
            this.AddBrand_comboboxCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddBrand_textboxBrand = new System.Windows.Forms.TextBox();
            this.AddBrand_buttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AddBrand_buttonExit)).BeginInit();
            this.SuspendLayout();
            // 
            // AddBrand_buttonExit
            // 
            this.AddBrand_buttonExit.BackgroundImage = global::StokTakipOtomasyon.Properties.Resources.exitButton;
            this.AddBrand_buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddBrand_buttonExit.Location = new System.Drawing.Point(258, 12);
            this.AddBrand_buttonExit.Name = "AddBrand_buttonExit";
            this.AddBrand_buttonExit.Size = new System.Drawing.Size(30, 30);
            this.AddBrand_buttonExit.TabIndex = 21;
            this.AddBrand_buttonExit.TabStop = false;
            this.AddBrand_buttonExit.Click += new System.EventHandler(this.AddBrand_buttonExit_Click);
            // 
            // AddBrand_comboboxCategory
            // 
            this.AddBrand_comboboxCategory.FormattingEnabled = true;
            this.AddBrand_comboboxCategory.Location = new System.Drawing.Point(81, 48);
            this.AddBrand_comboboxCategory.Name = "AddBrand_comboboxCategory";
            this.AddBrand_comboboxCategory.Size = new System.Drawing.Size(141, 21);
            this.AddBrand_comboboxCategory.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Category:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Brand:";
            // 
            // AddBrand_textboxBrand
            // 
            this.AddBrand_textboxBrand.Location = new System.Drawing.Point(81, 93);
            this.AddBrand_textboxBrand.Name = "AddBrand_textboxBrand";
            this.AddBrand_textboxBrand.Size = new System.Drawing.Size(141, 20);
            this.AddBrand_textboxBrand.TabIndex = 25;
            // 
            // AddBrand_buttonAdd
            // 
            this.AddBrand_buttonAdd.Location = new System.Drawing.Point(147, 140);
            this.AddBrand_buttonAdd.Name = "AddBrand_buttonAdd";
            this.AddBrand_buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.AddBrand_buttonAdd.TabIndex = 26;
            this.AddBrand_buttonAdd.Text = "Add";
            this.AddBrand_buttonAdd.UseVisualStyleBackColor = true;
            this.AddBrand_buttonAdd.Click += new System.EventHandler(this.AddBrand_buttonAdd_Click);
            // 
            // AddBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.AddBrand_buttonAdd);
            this.Controls.Add(this.AddBrand_textboxBrand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddBrand_comboboxCategory);
            this.Controls.Add(this.AddBrand_buttonExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddBrand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBrand";
            this.Load += new System.EventHandler(this.AddBrand_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AddBrand_buttonExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox AddBrand_buttonExit;
        private System.Windows.Forms.ComboBox AddBrand_comboboxCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AddBrand_textboxBrand;
        private System.Windows.Forms.Button AddBrand_buttonAdd;
    }
}