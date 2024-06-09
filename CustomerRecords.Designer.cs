namespace C969Scheduling
{
    partial class CustomerRecords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerRecords));
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.nameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.address2Label = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.address2TextBox = new System.Windows.Forms.TextBox();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.zipcodeLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.customerRecordLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Location = new System.Drawing.Point(238, 43);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.Size = new System.Drawing.Size(694, 239);
            this.customerDataGridView.TabIndex = 0;
            this.customerDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomDataGridView_CellClick);
            this.customerDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerDataGridView_CellContentClick);
            this.customerDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CustomDataGridView_CellMouseClick);
            this.customerDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.CustomDataGridView_DataBindingComplete);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(234, 298);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(55, 20);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(214, 350);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(75, 20);
            this.addressLabel.TabIndex = 2;
            this.addressLabel.Text = "Address";
            // 
            // address2Label
            // 
            this.address2Label.AutoSize = true;
            this.address2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address2Label.Location = new System.Drawing.Point(199, 376);
            this.address2Label.Name = "address2Label";
            this.address2Label.Size = new System.Drawing.Size(90, 20);
            this.address2Label.TabIndex = 3;
            this.address2Label.Text = "Address 2";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryLabel.Location = new System.Drawing.Point(218, 458);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(71, 20);
            this.countryLabel.TabIndex = 4;
            this.countryLabel.Text = "Country";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.Location = new System.Drawing.Point(250, 402);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(39, 20);
            this.cityLabel.TabIndex = 5;
            this.cityLabel.Text = "City";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Location = new System.Drawing.Point(295, 300);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(514, 20);
            this.nameTextBox.TabIndex = 6;
            this.nameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Enabled = false;
            this.addressTextBox.Location = new System.Drawing.Point(295, 352);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(402, 20);
            this.addressTextBox.TabIndex = 7;
            this.addressTextBox.TextChanged += new System.EventHandler(this.AddressTextBox_TextChanged);
            // 
            // address2TextBox
            // 
            this.address2TextBox.Enabled = false;
            this.address2TextBox.Location = new System.Drawing.Point(295, 378);
            this.address2TextBox.Name = "address2TextBox";
            this.address2TextBox.Size = new System.Drawing.Size(402, 20);
            this.address2TextBox.TabIndex = 8;
            this.address2TextBox.TextChanged += new System.EventHandler(this.Address2TextBox_TextChanged);
            // 
            // countryComboBox
            // 
            this.countryComboBox.Enabled = false;
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Location = new System.Drawing.Point(295, 457);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(217, 21);
            this.countryComboBox.TabIndex = 9;
            this.countryComboBox.SelectedIndexChanged += new System.EventHandler(this.CountryComboBox_SelectedIndexChanged);
            this.countryComboBox.SelectionChangeCommitted += new System.EventHandler(this.CountryComboBox_SelectionChangeCommitted);
            this.countryComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CountryComboBox_KeyPress);
            // 
            // cityComboBox
            // 
            this.cityComboBox.Enabled = false;
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Location = new System.Drawing.Point(295, 404);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(217, 21);
            this.cityComboBox.TabIndex = 10;
            this.cityComboBox.SelectedIndexChanged += new System.EventHandler(this.CityComboBox_SelectedIndexChanged);
            this.cityComboBox.SelectionChangeCommitted += new System.EventHandler(this.CityComboBox_SelectionChangeCommitted);
            this.cityComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CityComboBox_KeyPress);
            // 
            // zipcodeLabel
            // 
            this.zipcodeLabel.AutoSize = true;
            this.zipcodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipcodeLabel.Location = new System.Drawing.Point(208, 429);
            this.zipcodeLabel.Name = "zipcodeLabel";
            this.zipcodeLabel.Size = new System.Drawing.Size(81, 20);
            this.zipcodeLabel.TabIndex = 11;
            this.zipcodeLabel.Text = "Zip Code";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(229, 324);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(60, 20);
            this.phoneLabel.TabIndex = 12;
            this.phoneLabel.Text = "Phone";
            // 
            // zipTextBox
            // 
            this.zipTextBox.Enabled = false;
            this.zipTextBox.Location = new System.Drawing.Point(295, 431);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(100, 20);
            this.zipTextBox.TabIndex = 13;
            this.zipTextBox.TextChanged += new System.EventHandler(this.ZipTextBox_TextChanged);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Enabled = false;
            this.phoneTextBox.Location = new System.Drawing.Point(295, 326);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(183, 20);
            this.phoneTextBox.TabIndex = 14;
            this.phoneTextBox.TextChanged += new System.EventHandler(this.PhoneTextBox_TextChanged);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(817, 298);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(28, 20);
            this.idLabel.TabIndex = 15;
            this.idLabel.Text = "ID";
            // 
            // idTextBox
            // 
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(851, 300);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(81, 20);
            this.idTextBox.TabIndex = 16;
            this.idTextBox.TextChanged += new System.EventHandler(this.IdTextBox_TextChanged);
            // 
            // customerRecordLabel
            // 
            this.customerRecordLabel.AutoSize = true;
            this.customerRecordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerRecordLabel.Location = new System.Drawing.Point(12, 9);
            this.customerRecordLabel.Name = "customerRecordLabel";
            this.customerRecordLabel.Size = new System.Drawing.Size(265, 31);
            this.customerRecordLabel.TabIndex = 17;
            this.customerRecordLabel.Text = "Customer Records ";
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(967, 43);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(179, 43);
            this.addButton.TabIndex = 18;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(967, 92);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(179, 43);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.Location = new System.Drawing.Point(967, 141);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(179, 43);
            this.editButton.TabIndex = 18;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(967, 239);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(179, 43);
            this.cancelButton.TabIndex = 18;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(967, 190);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(179, 43);
            this.deleteButton.TabIndex = 18;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(967, 458);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(179, 43);
            this.backButton.TabIndex = 18;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CustomerRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1158, 513);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.customerRecordLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.zipTextBox);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.zipcodeLabel);
            this.Controls.Add(this.cityComboBox);
            this.Controls.Add(this.countryComboBox);
            this.Controls.Add(this.address2TextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.address2Label);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.customerDataGridView);
            this.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerRecords";
            this.Text = "CustomerRecords";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomerRecords_FormClosed);
            this.Load += new System.EventHandler(this.CustomerRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label address2Label;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox address2TextBox;
        private System.Windows.Forms.ComboBox countryComboBox;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.Label zipcodeLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label customerRecordLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button backButton;
    }
}