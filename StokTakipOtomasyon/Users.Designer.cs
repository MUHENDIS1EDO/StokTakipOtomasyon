namespace StokTakipOtomasyon
{
    partial class Users
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
            this.components = new System.ComponentModel.Container();
            this.Users_buttonExit = new System.Windows.Forms.PictureBox();
            this.Users_buttonBack = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Users_comboboxGender = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.Users_textboxUserId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Users_comboboxUserType = new System.Windows.Forms.ComboBox();
            this.Users_textboxUserName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Users_textboxName = new System.Windows.Forms.TextBox();
            this.Users_textboxLastName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Users_textboxEmail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Users_textboxPassword = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Searchbox = new System.Windows.Forms.TextBox();
            this.Users_buttonUpdate = new System.Windows.Forms.Button();
            this.Users_buttonDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Users_buttonAddCustomer = new System.Windows.Forms.Button();
            this.stokTakipOtomasyonuDataSet1 = new StokTakipOtomasyon.StokTakipOtomasyonuDataSet1();
            this.tblUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_UsersTableAdapter = new StokTakipOtomasyon.StokTakipOtomasyonuDataSet1TableAdapters.tbl_UsersTableAdapter();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Users_buttonExit)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakipOtomasyonuDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Users_buttonExit
            // 
            this.Users_buttonExit.BackgroundImage = global::StokTakipOtomasyon.Properties.Resources.exitButton;
            this.Users_buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Users_buttonExit.Location = new System.Drawing.Point(758, 12);
            this.Users_buttonExit.Name = "Users_buttonExit";
            this.Users_buttonExit.Size = new System.Drawing.Size(30, 30);
            this.Users_buttonExit.TabIndex = 20;
            this.Users_buttonExit.TabStop = false;
            this.Users_buttonExit.Click += new System.EventHandler(this.Users_buttonExit_Click);
            // 
            // Users_buttonBack
            // 
            this.Users_buttonBack.Location = new System.Drawing.Point(12, 12);
            this.Users_buttonBack.Name = "Users_buttonBack";
            this.Users_buttonBack.Size = new System.Drawing.Size(75, 23);
            this.Users_buttonBack.TabIndex = 21;
            this.Users_buttonBack.Text = "Back";
            this.Users_buttonBack.UseVisualStyleBackColor = true;
            this.Users_buttonBack.Click += new System.EventHandler(this.Users_buttonBack_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.Users_comboboxGender);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.Users_textboxUserId);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.Users_comboboxUserType);
            this.panel2.Controls.Add(this.Users_textboxUserName);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.Users_textboxName);
            this.panel2.Controls.Add(this.Users_textboxLastName);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.Users_textboxEmail);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.Users_textboxPassword);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Location = new System.Drawing.Point(175, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(479, 111);
            this.panel2.TabIndex = 27;
            // 
            // Users_comboboxGender
            // 
            this.Users_comboboxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Users_comboboxGender.FormattingEnabled = true;
            this.Users_comboboxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Users_comboboxGender.Location = new System.Drawing.Point(317, 91);
            this.Users_comboboxGender.Name = "Users_comboboxGender";
            this.Users_comboboxGender.Size = new System.Drawing.Size(157, 21);
            this.Users_comboboxGender.TabIndex = 33;
            this.Users_comboboxGender.Tag = "";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 13);
            this.label17.TabIndex = 38;
            this.label17.Text = "User Info:";
            // 
            // Users_textboxUserId
            // 
            this.Users_textboxUserId.Enabled = false;
            this.Users_textboxUserId.Location = new System.Drawing.Point(317, 25);
            this.Users_textboxUserId.Name = "Users_textboxUserId";
            this.Users_textboxUserId.Size = new System.Drawing.Size(157, 20);
            this.Users_textboxUserId.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(246, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "User ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "User Type:";
            // 
            // Users_comboboxUserType
            // 
            this.Users_comboboxUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Users_comboboxUserType.FormattingEnabled = true;
            this.Users_comboboxUserType.Items.AddRange(new object[] {
            "Admin",
            "Customer",
            "Seller"});
            this.Users_comboboxUserType.Location = new System.Drawing.Point(82, 21);
            this.Users_comboboxUserType.Name = "Users_comboboxUserType";
            this.Users_comboboxUserType.Size = new System.Drawing.Size(157, 21);
            this.Users_comboboxUserType.TabIndex = 27;
            this.Users_comboboxUserType.Tag = "";
            // 
            // Users_textboxUserName
            // 
            this.Users_textboxUserName.Location = new System.Drawing.Point(82, 45);
            this.Users_textboxUserName.Name = "Users_textboxUserName";
            this.Users_textboxUserName.Size = new System.Drawing.Size(157, 20);
            this.Users_textboxUserName.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(245, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Gender:";
            // 
            // Users_textboxName
            // 
            this.Users_textboxName.Location = new System.Drawing.Point(82, 68);
            this.Users_textboxName.Name = "Users_textboxName";
            this.Users_textboxName.Size = new System.Drawing.Size(157, 20);
            this.Users_textboxName.TabIndex = 29;
            // 
            // Users_textboxLastName
            // 
            this.Users_textboxLastName.Location = new System.Drawing.Point(82, 91);
            this.Users_textboxLastName.Name = "Users_textboxLastName";
            this.Users_textboxLastName.Size = new System.Drawing.Size(157, 20);
            this.Users_textboxLastName.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(245, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Password:";
            // 
            // Users_textboxEmail
            // 
            this.Users_textboxEmail.Location = new System.Drawing.Point(317, 47);
            this.Users_textboxEmail.Name = "Users_textboxEmail";
            this.Users_textboxEmail.Size = new System.Drawing.Size(157, 20);
            this.Users_textboxEmail.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(245, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Email:";
            // 
            // Users_textboxPassword
            // 
            this.Users_textboxPassword.Location = new System.Drawing.Point(317, 70);
            this.Users_textboxPassword.Name = "Users_textboxPassword";
            this.Users_textboxPassword.Size = new System.Drawing.Size(157, 20);
            this.Users_textboxPassword.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Last Name:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Name:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 46);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "User Name:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIdDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.userTypeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblUsersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 255);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Searchbox
            // 
            this.Searchbox.Location = new System.Drawing.Point(105, 149);
            this.Searchbox.Name = "Searchbox";
            this.Searchbox.Size = new System.Drawing.Size(143, 20);
            this.Searchbox.TabIndex = 29;
            this.Searchbox.TextChanged += new System.EventHandler(this.Searchbox_TextChanged);
            // 
            // Users_buttonUpdate
            // 
            this.Users_buttonUpdate.Location = new System.Drawing.Point(538, 145);
            this.Users_buttonUpdate.Name = "Users_buttonUpdate";
            this.Users_buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.Users_buttonUpdate.TabIndex = 31;
            this.Users_buttonUpdate.Text = "Update";
            this.Users_buttonUpdate.UseVisualStyleBackColor = true;
            this.Users_buttonUpdate.Click += new System.EventHandler(this.Users_buttonUpdate_Click);
            // 
            // Users_buttonDelete
            // 
            this.Users_buttonDelete.Location = new System.Drawing.Point(642, 145);
            this.Users_buttonDelete.Name = "Users_buttonDelete";
            this.Users_buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.Users_buttonDelete.TabIndex = 32;
            this.Users_buttonDelete.Text = "Delete";
            this.Users_buttonDelete.UseVisualStyleBackColor = true;
            this.Users_buttonDelete.Click += new System.EventHandler(this.Users_buttonDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Search:";
            // 
            // Users_buttonAddCustomer
            // 
            this.Users_buttonAddCustomer.Location = new System.Drawing.Point(350, 144);
            this.Users_buttonAddCustomer.Name = "Users_buttonAddCustomer";
            this.Users_buttonAddCustomer.Size = new System.Drawing.Size(115, 23);
            this.Users_buttonAddCustomer.TabIndex = 34;
            this.Users_buttonAddCustomer.Text = "Add Customer";
            this.Users_buttonAddCustomer.UseVisualStyleBackColor = true;
            this.Users_buttonAddCustomer.Click += new System.EventHandler(this.Users_buttonAddCustomer_Click);
            // 
            // stokTakipOtomasyonuDataSet1
            // 
            this.stokTakipOtomasyonuDataSet1.DataSetName = "StokTakipOtomasyonuDataSet1";
            this.stokTakipOtomasyonuDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblUsersBindingSource
            // 
            this.tblUsersBindingSource.DataMember = "tbl_Users";
            this.tblUsersBindingSource.DataSource = this.stokTakipOtomasyonuDataSet1;
            // 
            // tbl_UsersTableAdapter
            // 
            this.tbl_UsersTableAdapter.ClearBeforeFill = true;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // userTypeDataGridViewTextBoxColumn
            // 
            this.userTypeDataGridViewTextBoxColumn.DataPropertyName = "UserType";
            this.userTypeDataGridViewTextBoxColumn.HeaderText = "UserType";
            this.userTypeDataGridViewTextBoxColumn.Name = "userTypeDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.Users_buttonAddCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Users_buttonDelete);
            this.Controls.Add(this.Users_buttonUpdate);
            this.Controls.Add(this.Searchbox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Users_buttonBack);
            this.Controls.Add(this.Users_buttonExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Users_buttonExit)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakipOtomasyonuDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Users_buttonExit;
        private System.Windows.Forms.Button Users_buttonBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox Users_textboxUserId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Users_comboboxUserType;
        private System.Windows.Forms.TextBox Users_textboxUserName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Users_textboxName;
        private System.Windows.Forms.TextBox Users_textboxLastName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Users_textboxEmail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Users_textboxPassword;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Searchbox;
        private System.Windows.Forms.Button Users_buttonUpdate;
        private System.Windows.Forms.Button Users_buttonDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Users_comboboxGender;
        private System.Windows.Forms.Button Users_buttonAddCustomer;
        private StokTakipOtomasyonuDataSet1 stokTakipOtomasyonuDataSet1;
        private System.Windows.Forms.BindingSource tblUsersBindingSource;
        private StokTakipOtomasyonuDataSet1TableAdapters.tbl_UsersTableAdapter tbl_UsersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
    }
}