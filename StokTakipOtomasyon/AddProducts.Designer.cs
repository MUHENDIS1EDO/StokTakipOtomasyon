namespace StokTakipOtomasyon
{
    partial class AddProducts
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
            this.yeniUrunGroupBox = new System.Windows.Forms.GroupBox();
            this.textboxPurchasePrice = new System.Windows.Forms.TextBox();
            this.textboxSalePrice = new System.Windows.Forms.TextBox();
            this.textboxStock = new System.Windows.Forms.TextBox();
            this.textboxProductName = new System.Windows.Forms.TextBox();
            this.comboboxBrand = new System.Windows.Forms.ComboBox();
            this.comboboxCategory = new System.Windows.Forms.ComboBox();
            this.textboxStockCode = new System.Windows.Forms.TextBox();
            this.AddProducts_buttonAddNew = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.VarOlanUrunGroupBox = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.PurchasePricetextbox = new System.Windows.Forms.TextBox();
            this.SalePricetextbox = new System.Windows.Forms.TextBox();
            this.Stocktextbox = new System.Windows.Forms.TextBox();
            this.ProductNametextbox = new System.Windows.Forms.TextBox();
            this.Brandcombobox = new System.Windows.Forms.ComboBox();
            this.Categorycombobox = new System.Windows.Forms.ComboBox();
            this.StockCodetextbox = new System.Windows.Forms.TextBox();
            this.AddProducts_buttonAddExisting = new System.Windows.Forms.Button();
            this.AddProducts_buttonExit = new System.Windows.Forms.PictureBox();
            this.lblTotalStock = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.yeniUrunGroupBox.SuspendLayout();
            this.VarOlanUrunGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddProducts_buttonExit)).BeginInit();
            this.SuspendLayout();
            // 
            // yeniUrunGroupBox
            // 
            this.yeniUrunGroupBox.Controls.Add(this.textboxPurchasePrice);
            this.yeniUrunGroupBox.Controls.Add(this.textboxSalePrice);
            this.yeniUrunGroupBox.Controls.Add(this.textboxStock);
            this.yeniUrunGroupBox.Controls.Add(this.textboxProductName);
            this.yeniUrunGroupBox.Controls.Add(this.comboboxBrand);
            this.yeniUrunGroupBox.Controls.Add(this.comboboxCategory);
            this.yeniUrunGroupBox.Controls.Add(this.textboxStockCode);
            this.yeniUrunGroupBox.Controls.Add(this.AddProducts_buttonAddNew);
            this.yeniUrunGroupBox.Controls.Add(this.label7);
            this.yeniUrunGroupBox.Controls.Add(this.label6);
            this.yeniUrunGroupBox.Controls.Add(this.label5);
            this.yeniUrunGroupBox.Controls.Add(this.label4);
            this.yeniUrunGroupBox.Controls.Add(this.label3);
            this.yeniUrunGroupBox.Controls.Add(this.label2);
            this.yeniUrunGroupBox.Controls.Add(this.label1);
            this.yeniUrunGroupBox.Location = new System.Drawing.Point(52, 26);
            this.yeniUrunGroupBox.Name = "yeniUrunGroupBox";
            this.yeniUrunGroupBox.Size = new System.Drawing.Size(231, 326);
            this.yeniUrunGroupBox.TabIndex = 0;
            this.yeniUrunGroupBox.TabStop = false;
            this.yeniUrunGroupBox.Text = "New Product";
            // 
            // textboxPurchasePrice
            // 
            this.textboxPurchasePrice.Location = new System.Drawing.Point(91, 240);
            this.textboxPurchasePrice.Name = "textboxPurchasePrice";
            this.textboxPurchasePrice.Size = new System.Drawing.Size(121, 20);
            this.textboxPurchasePrice.TabIndex = 14;
            // 
            // textboxSalePrice
            // 
            this.textboxSalePrice.Location = new System.Drawing.Point(91, 205);
            this.textboxSalePrice.Name = "textboxSalePrice";
            this.textboxSalePrice.Size = new System.Drawing.Size(121, 20);
            this.textboxSalePrice.TabIndex = 13;
            // 
            // textboxStock
            // 
            this.textboxStock.Location = new System.Drawing.Point(91, 170);
            this.textboxStock.Name = "textboxStock";
            this.textboxStock.Size = new System.Drawing.Size(121, 20);
            this.textboxStock.TabIndex = 12;
            // 
            // textboxProductName
            // 
            this.textboxProductName.Location = new System.Drawing.Point(91, 135);
            this.textboxProductName.Name = "textboxProductName";
            this.textboxProductName.Size = new System.Drawing.Size(121, 20);
            this.textboxProductName.TabIndex = 11;
            // 
            // comboboxBrand
            // 
            this.comboboxBrand.FormattingEnabled = true;
            this.comboboxBrand.Location = new System.Drawing.Point(91, 99);
            this.comboboxBrand.Name = "comboboxBrand";
            this.comboboxBrand.Size = new System.Drawing.Size(121, 21);
            this.comboboxBrand.TabIndex = 10;
            // 
            // comboboxCategory
            // 
            this.comboboxCategory.FormattingEnabled = true;
            this.comboboxCategory.Location = new System.Drawing.Point(91, 63);
            this.comboboxCategory.Name = "comboboxCategory";
            this.comboboxCategory.Size = new System.Drawing.Size(121, 21);
            this.comboboxCategory.TabIndex = 9;
            this.comboboxCategory.SelectedIndexChanged += new System.EventHandler(this.comboboxCategory_SelectedIndexChanged);
            // 
            // textboxStockCode
            // 
            this.textboxStockCode.Location = new System.Drawing.Point(91, 28);
            this.textboxStockCode.Name = "textboxStockCode";
            this.textboxStockCode.Size = new System.Drawing.Size(121, 20);
            this.textboxStockCode.TabIndex = 8;
            // 
            // AddProducts_buttonAddNew
            // 
            this.AddProducts_buttonAddNew.Location = new System.Drawing.Point(137, 297);
            this.AddProducts_buttonAddNew.Name = "AddProducts_buttonAddNew";
            this.AddProducts_buttonAddNew.Size = new System.Drawing.Size(75, 23);
            this.AddProducts_buttonAddNew.TabIndex = 7;
            this.AddProducts_buttonAddNew.Text = "Add";
            this.AddProducts_buttonAddNew.UseVisualStyleBackColor = true;
            this.AddProducts_buttonAddNew.Click += new System.EventHandler(this.AddProducts_buttonAddNew_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Purchase Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sale Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Stock:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Product Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Brand:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stock Code:";
            // 
            // VarOlanUrunGroupBox
            // 
            this.VarOlanUrunGroupBox.Controls.Add(this.label16);
            this.VarOlanUrunGroupBox.Controls.Add(this.lblTotalStock);
            this.VarOlanUrunGroupBox.Controls.Add(this.label8);
            this.VarOlanUrunGroupBox.Controls.Add(this.label9);
            this.VarOlanUrunGroupBox.Controls.Add(this.label10);
            this.VarOlanUrunGroupBox.Controls.Add(this.label11);
            this.VarOlanUrunGroupBox.Controls.Add(this.label12);
            this.VarOlanUrunGroupBox.Controls.Add(this.label13);
            this.VarOlanUrunGroupBox.Controls.Add(this.label14);
            this.VarOlanUrunGroupBox.Controls.Add(this.PurchasePricetextbox);
            this.VarOlanUrunGroupBox.Controls.Add(this.SalePricetextbox);
            this.VarOlanUrunGroupBox.Controls.Add(this.Stocktextbox);
            this.VarOlanUrunGroupBox.Controls.Add(this.ProductNametextbox);
            this.VarOlanUrunGroupBox.Controls.Add(this.Brandcombobox);
            this.VarOlanUrunGroupBox.Controls.Add(this.Categorycombobox);
            this.VarOlanUrunGroupBox.Controls.Add(this.StockCodetextbox);
            this.VarOlanUrunGroupBox.Controls.Add(this.AddProducts_buttonAddExisting);
            this.VarOlanUrunGroupBox.Location = new System.Drawing.Point(289, 26);
            this.VarOlanUrunGroupBox.Name = "VarOlanUrunGroupBox";
            this.VarOlanUrunGroupBox.Size = new System.Drawing.Size(230, 326);
            this.VarOlanUrunGroupBox.TabIndex = 0;
            this.VarOlanUrunGroupBox.TabStop = false;
            this.VarOlanUrunGroupBox.Text = "Existing Product";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Purchase Price:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Sale Price:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(57, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Stock:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Product Name:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(57, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Brand:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(43, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Category:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(29, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Stock Code:";
            // 
            // PurchasePricetextbox
            // 
            this.PurchasePricetextbox.Location = new System.Drawing.Point(103, 240);
            this.PurchasePricetextbox.Name = "PurchasePricetextbox";
            this.PurchasePricetextbox.Size = new System.Drawing.Size(121, 20);
            this.PurchasePricetextbox.TabIndex = 21;
            // 
            // SalePricetextbox
            // 
            this.SalePricetextbox.Location = new System.Drawing.Point(103, 205);
            this.SalePricetextbox.Name = "SalePricetextbox";
            this.SalePricetextbox.Size = new System.Drawing.Size(121, 20);
            this.SalePricetextbox.TabIndex = 20;
            // 
            // Stocktextbox
            // 
            this.Stocktextbox.Location = new System.Drawing.Point(103, 170);
            this.Stocktextbox.Name = "Stocktextbox";
            this.Stocktextbox.Size = new System.Drawing.Size(121, 20);
            this.Stocktextbox.TabIndex = 19;
            // 
            // ProductNametextbox
            // 
            this.ProductNametextbox.Location = new System.Drawing.Point(103, 135);
            this.ProductNametextbox.Name = "ProductNametextbox";
            this.ProductNametextbox.Size = new System.Drawing.Size(121, 20);
            this.ProductNametextbox.TabIndex = 18;
            // 
            // Brandcombobox
            // 
            this.Brandcombobox.FormattingEnabled = true;
            this.Brandcombobox.Location = new System.Drawing.Point(103, 99);
            this.Brandcombobox.Name = "Brandcombobox";
            this.Brandcombobox.Size = new System.Drawing.Size(121, 21);
            this.Brandcombobox.TabIndex = 17;
            // 
            // Categorycombobox
            // 
            this.Categorycombobox.FormattingEnabled = true;
            this.Categorycombobox.Location = new System.Drawing.Point(103, 63);
            this.Categorycombobox.Name = "Categorycombobox";
            this.Categorycombobox.Size = new System.Drawing.Size(121, 21);
            this.Categorycombobox.TabIndex = 16;
            // 
            // StockCodetextbox
            // 
            this.StockCodetextbox.Location = new System.Drawing.Point(103, 28);
            this.StockCodetextbox.Name = "StockCodetextbox";
            this.StockCodetextbox.Size = new System.Drawing.Size(121, 20);
            this.StockCodetextbox.TabIndex = 15;
            this.StockCodetextbox.TextChanged += new System.EventHandler(this.StockCodetextbox_TextChanged);
            // 
            // AddProducts_buttonAddExisting
            // 
            this.AddProducts_buttonAddExisting.Location = new System.Drawing.Point(143, 297);
            this.AddProducts_buttonAddExisting.Name = "AddProducts_buttonAddExisting";
            this.AddProducts_buttonAddExisting.Size = new System.Drawing.Size(75, 23);
            this.AddProducts_buttonAddExisting.TabIndex = 14;
            this.AddProducts_buttonAddExisting.Text = "Add";
            this.AddProducts_buttonAddExisting.UseVisualStyleBackColor = true;
            this.AddProducts_buttonAddExisting.Click += new System.EventHandler(this.AddProducts_buttonAddExisting_Click);
            // 
            // AddProducts_buttonExit
            // 
            this.AddProducts_buttonExit.BackgroundImage = global::StokTakipOtomasyon.Properties.Resources.exitButton;
            this.AddProducts_buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddProducts_buttonExit.Location = new System.Drawing.Point(558, 12);
            this.AddProducts_buttonExit.Name = "AddProducts_buttonExit";
            this.AddProducts_buttonExit.Size = new System.Drawing.Size(30, 30);
            this.AddProducts_buttonExit.TabIndex = 20;
            this.AddProducts_buttonExit.TabStop = false;
            this.AddProducts_buttonExit.Click += new System.EventHandler(this.AddProducts_buttonExit_Click);
            // 
            // lblTotalStock
            // 
            this.lblTotalStock.AutoSize = true;
            this.lblTotalStock.Location = new System.Drawing.Point(84, 297);
            this.lblTotalStock.Name = "lblTotalStock";
            this.lblTotalStock.Size = new System.Drawing.Size(0, 13);
            this.lblTotalStock.TabIndex = 29;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 297);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "Total Stock:";
            // 
            // AddProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.AddProducts_buttonExit);
            this.Controls.Add(this.VarOlanUrunGroupBox);
            this.Controls.Add(this.yeniUrunGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProducts";
            this.Load += new System.EventHandler(this.AddProducts_Load);
            this.yeniUrunGroupBox.ResumeLayout(false);
            this.yeniUrunGroupBox.PerformLayout();
            this.VarOlanUrunGroupBox.ResumeLayout(false);
            this.VarOlanUrunGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddProducts_buttonExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox yeniUrunGroupBox;
        private System.Windows.Forms.TextBox textboxPurchasePrice;
        private System.Windows.Forms.TextBox textboxSalePrice;
        private System.Windows.Forms.TextBox textboxStock;
        private System.Windows.Forms.TextBox textboxProductName;
        private System.Windows.Forms.ComboBox comboboxBrand;
        private System.Windows.Forms.ComboBox comboboxCategory;
        private System.Windows.Forms.TextBox textboxStockCode;
        private System.Windows.Forms.Button AddProducts_buttonAddNew;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox VarOlanUrunGroupBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox PurchasePricetextbox;
        private System.Windows.Forms.TextBox SalePricetextbox;
        private System.Windows.Forms.TextBox Stocktextbox;
        private System.Windows.Forms.TextBox ProductNametextbox;
        private System.Windows.Forms.ComboBox Brandcombobox;
        private System.Windows.Forms.ComboBox Categorycombobox;
        private System.Windows.Forms.TextBox StockCodetextbox;
        private System.Windows.Forms.Button AddProducts_buttonAddExisting;
        private System.Windows.Forms.PictureBox AddProducts_buttonExit;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblTotalStock;
    }
}