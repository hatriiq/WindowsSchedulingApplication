namespace C969Scheduling
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.reportTextBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.numberAptsRadioButton = new System.Windows.Forms.RadioButton();
            this.userScheduleRadioButton = new System.Windows.Forms.RadioButton();
            this.aptsTodayRadioButton = new System.Windows.Forms.RadioButton();
            this.selectReportLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reportTextBox
            // 
            this.reportTextBox.Location = new System.Drawing.Point(448, 114);
            this.reportTextBox.Multiline = true;
            this.reportTextBox.Name = "reportTextBox";
            this.reportTextBox.Size = new System.Drawing.Size(642, 265);
            this.reportTextBox.TabIndex = 0;
            this.reportTextBox.TextChanged += new System.EventHandler(this.ReportTextBox_TextChanged);
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(970, 451);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(170, 42);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // numberAptsRadioButton
            // 
            this.numberAptsRadioButton.AutoSize = true;
            this.numberAptsRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberAptsRadioButton.Location = new System.Drawing.Point(25, 123);
            this.numberAptsRadioButton.Name = "numberAptsRadioButton";
            this.numberAptsRadioButton.Size = new System.Drawing.Size(347, 24);
            this.numberAptsRadioButton.TabIndex = 2;
            this.numberAptsRadioButton.TabStop = true;
            this.numberAptsRadioButton.Text = "Number of Appointment Types by Month";
            this.numberAptsRadioButton.UseVisualStyleBackColor = true;
            this.numberAptsRadioButton.CheckedChanged += new System.EventHandler(this.NumberAptsRadioButton_CheckedChanged);
            // 
            // userScheduleRadioButton
            // 
            this.userScheduleRadioButton.AutoSize = true;
            this.userScheduleRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userScheduleRadioButton.Location = new System.Drawing.Point(25, 235);
            this.userScheduleRadioButton.Name = "userScheduleRadioButton";
            this.userScheduleRadioButton.Size = new System.Drawing.Size(145, 24);
            this.userScheduleRadioButton.TabIndex = 3;
            this.userScheduleRadioButton.TabStop = true;
            this.userScheduleRadioButton.Text = "User Schedule";
            this.userScheduleRadioButton.UseVisualStyleBackColor = true;
            this.userScheduleRadioButton.CheckedChanged += new System.EventHandler(this.UserScheduleRadioButton_CheckedChanged);
            // 
            // aptsTodayRadioButton
            // 
            this.aptsTodayRadioButton.AutoSize = true;
            this.aptsTodayRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aptsTodayRadioButton.Location = new System.Drawing.Point(25, 355);
            this.aptsTodayRadioButton.Name = "aptsTodayRadioButton";
            this.aptsTodayRadioButton.Size = new System.Drawing.Size(187, 24);
            this.aptsTodayRadioButton.TabIndex = 4;
            this.aptsTodayRadioButton.TabStop = true;
            this.aptsTodayRadioButton.Text = "Appointments today";
            this.aptsTodayRadioButton.UseVisualStyleBackColor = true;
            this.aptsTodayRadioButton.CheckedChanged += new System.EventHandler(this.AptsTodayRadioButton_CheckedChanged);
            // 
            // selectReportLabel
            // 
            this.selectReportLabel.AutoSize = true;
            this.selectReportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectReportLabel.Location = new System.Drawing.Point(19, 24);
            this.selectReportLabel.Name = "selectReportLabel";
            this.selectReportLabel.Size = new System.Drawing.Size(289, 31);
            this.selectReportLabel.TabIndex = 5;
            this.selectReportLabel.Text = "Please Select Report";
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1152, 505);
            this.Controls.Add(this.selectReportLabel);
            this.Controls.Add(this.aptsTodayRadioButton);
            this.Controls.Add(this.userScheduleRadioButton);
            this.Controls.Add(this.numberAptsRadioButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.reportTextBox);
            this.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReportsForm_FormClosed);
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox reportTextBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.RadioButton numberAptsRadioButton;
        private System.Windows.Forms.RadioButton userScheduleRadioButton;
        private System.Windows.Forms.RadioButton aptsTodayRadioButton;
        private System.Windows.Forms.Label selectReportLabel;
    }
}