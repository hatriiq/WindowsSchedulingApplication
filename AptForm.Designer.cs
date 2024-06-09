namespace C969Scheduling
{
    partial class AptForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AptForm));
            this.appointmentDataGridView = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.searchAptLabel = new System.Windows.Forms.Label();
            this.appointmentLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTypelabel = new System.Windows.Forms.Label();
            this.customerIDradioButton = new System.Windows.Forms.RadioButton();
            this.appointmentTypeRadioButton = new System.Windows.Forms.RadioButton();
            this.datesRadioButton = new System.Windows.Forms.RadioButton();
            this.customerIdLabel = new System.Windows.Forms.Label();
            this.appointmentTypeLabel = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.appointmentTypeComboBox = new System.Windows.Forms.ComboBox();
            this.customerIDtextbox = new System.Windows.Forms.TextBox();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // appointmentDataGridView
            // 
            this.appointmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentDataGridView.Location = new System.Drawing.Point(103, 56);
            this.appointmentDataGridView.Name = "appointmentDataGridView";
            this.appointmentDataGridView.Size = new System.Drawing.Size(780, 186);
            this.appointmentDataGridView.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(980, 56);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(164, 41);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(980, 129);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(164, 41);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(980, 201);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(164, 41);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(980, 457);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(164, 41);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // searchAptLabel
            // 
            this.searchAptLabel.AutoSize = true;
            this.searchAptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchAptLabel.Location = new System.Drawing.Point(614, 257);
            this.searchAptLabel.Name = "searchAptLabel";
            this.searchAptLabel.Size = new System.Drawing.Size(269, 25);
            this.searchAptLabel.TabIndex = 3;
            this.searchAptLabel.Text = "Search for appointments";
            // 
            // appointmentLabel
            // 
            this.appointmentLabel.AutoSize = true;
            this.appointmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentLabel.Location = new System.Drawing.Point(97, 9);
            this.appointmentLabel.Name = "appointmentLabel";
            this.appointmentLabel.Size = new System.Drawing.Size(177, 31);
            this.appointmentLabel.TabIndex = 6;
            this.appointmentLabel.Text = "Appointment";
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(719, 456);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(164, 42);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // searchTypelabel
            // 
            this.searchTypelabel.AutoSize = true;
            this.searchTypelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTypelabel.Location = new System.Drawing.Point(98, 257);
            this.searchTypelabel.Name = "searchTypelabel";
            this.searchTypelabel.Size = new System.Drawing.Size(145, 25);
            this.searchTypelabel.TabIndex = 8;
            this.searchTypelabel.Text = "Search Type";
            // 
            // customerIDradioButton
            // 
            this.customerIDradioButton.AutoSize = true;
            this.customerIDradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIDradioButton.Location = new System.Drawing.Point(103, 287);
            this.customerIDradioButton.Name = "customerIDradioButton";
            this.customerIDradioButton.Size = new System.Drawing.Size(128, 24);
            this.customerIDradioButton.TabIndex = 9;
            this.customerIDradioButton.TabStop = true;
            this.customerIDradioButton.Text = "Customer ID";
            this.customerIDradioButton.UseVisualStyleBackColor = true;
            this.customerIDradioButton.CheckedChanged += new System.EventHandler(this.CustomerIDRadioButton_CheckedChanged);
            // 
            // appointmentTypeRadioButton
            // 
            this.appointmentTypeRadioButton.AutoSize = true;
            this.appointmentTypeRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentTypeRadioButton.Location = new System.Drawing.Point(103, 323);
            this.appointmentTypeRadioButton.Name = "appointmentTypeRadioButton";
            this.appointmentTypeRadioButton.Size = new System.Drawing.Size(172, 24);
            this.appointmentTypeRadioButton.TabIndex = 10;
            this.appointmentTypeRadioButton.TabStop = true;
            this.appointmentTypeRadioButton.Text = "Appointment Type";
            this.appointmentTypeRadioButton.UseVisualStyleBackColor = true;
            this.appointmentTypeRadioButton.CheckedChanged += new System.EventHandler(this.AppointmentTypeRadioButton_CheckedChanged);
            // 
            // datesRadioButton
            // 
            this.datesRadioButton.AutoSize = true;
            this.datesRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datesRadioButton.Location = new System.Drawing.Point(103, 357);
            this.datesRadioButton.Name = "datesRadioButton";
            this.datesRadioButton.Size = new System.Drawing.Size(75, 24);
            this.datesRadioButton.TabIndex = 11;
            this.datesRadioButton.TabStop = true;
            this.datesRadioButton.Text = "Dates";
            this.datesRadioButton.UseVisualStyleBackColor = true;
            this.datesRadioButton.CheckedChanged += new System.EventHandler(this.DatesRadioButton_CheckedChanged);
            // 
            // customerIdLabel
            // 
            this.customerIdLabel.AutoSize = true;
            this.customerIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIdLabel.Location = new System.Drawing.Point(546, 291);
            this.customerIdLabel.Name = "customerIdLabel";
            this.customerIdLabel.Size = new System.Drawing.Size(110, 20);
            this.customerIdLabel.TabIndex = 12;
            this.customerIdLabel.Text = "Customer ID";
            // 
            // appointmentTypeLabel
            // 
            this.appointmentTypeLabel.AutoSize = true;
            this.appointmentTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentTypeLabel.Location = new System.Drawing.Point(502, 327);
            this.appointmentTypeLabel.Name = "appointmentTypeLabel";
            this.appointmentTypeLabel.Size = new System.Drawing.Size(154, 20);
            this.appointmentTypeLabel.TabIndex = 13;
            this.appointmentTypeLabel.Text = "Appointment Type";
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateLabel.Location = new System.Drawing.Point(563, 362);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(93, 20);
            this.startDateLabel.TabIndex = 14;
            this.startDateLabel.Text = "Start Date";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateLabel.Location = new System.Drawing.Point(571, 399);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(85, 20);
            this.endDateLabel.TabIndex = 15;
            this.endDateLabel.Text = "End Date";
            // 
            // appointmentTypeComboBox
            // 
            this.appointmentTypeComboBox.FormattingEnabled = true;
            this.appointmentTypeComboBox.Location = new System.Drawing.Point(683, 326);
            this.appointmentTypeComboBox.Name = "appointmentTypeComboBox";
            this.appointmentTypeComboBox.Size = new System.Drawing.Size(200, 21);
            this.appointmentTypeComboBox.TabIndex = 16;
            this.appointmentTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.appointmentTypeComboBox_SelectedIndexChanged);
            // 
            // customerIDtextbox
            // 
            this.customerIDtextbox.Location = new System.Drawing.Point(762, 291);
            this.customerIDtextbox.Name = "customerIDtextbox";
            this.customerIDtextbox.Size = new System.Drawing.Size(121, 20);
            this.customerIDtextbox.TabIndex = 17;
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(683, 361);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStartDate.TabIndex = 18;
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(683, 399);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerEndDate.TabIndex = 19;
            // 
            // AptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1156, 510);
            this.Controls.Add(this.dateTimePickerEndDate);
            this.Controls.Add(this.dateTimePickerStartDate);
            this.Controls.Add(this.customerIDtextbox);
            this.Controls.Add(this.appointmentTypeComboBox);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.appointmentTypeLabel);
            this.Controls.Add(this.customerIdLabel);
            this.Controls.Add(this.datesRadioButton);
            this.Controls.Add(this.appointmentTypeRadioButton);
            this.Controls.Add(this.customerIDradioButton);
            this.Controls.Add(this.searchTypelabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.appointmentLabel);
            this.Controls.Add(this.searchAptLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.appointmentDataGridView);
            this.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AptForm";
            this.Text = "AptForm";
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView appointmentDataGridView;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label searchAptLabel;
        private System.Windows.Forms.Label appointmentLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label searchTypelabel;
        private System.Windows.Forms.RadioButton customerIDradioButton;
        private System.Windows.Forms.RadioButton appointmentTypeRadioButton;
        private System.Windows.Forms.RadioButton datesRadioButton;
        private System.Windows.Forms.Label customerIdLabel;
        private System.Windows.Forms.Label appointmentTypeLabel;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.ComboBox appointmentTypeComboBox;
        private System.Windows.Forms.TextBox customerIDtextbox;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
    }
}