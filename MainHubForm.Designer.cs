namespace C969Scheduling
{
    partial class MainHubForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainHubForm));
            this.mainHubLabel = new System.Windows.Forms.Label();
            this.customersButton = new System.Windows.Forms.Button();
            this.appointmentsButton = new System.Windows.Forms.Button();
            this.reportsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainHubLabel
            // 
            this.mainHubLabel.AutoSize = true;
            this.mainHubLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainHubLabel.Location = new System.Drawing.Point(8, 9);
            this.mainHubLabel.Name = "mainHubLabel";
            this.mainHubLabel.Size = new System.Drawing.Size(130, 29);
            this.mainHubLabel.TabIndex = 0;
            this.mainHubLabel.Text = " Main Hub";
            // 
            // customersButton
            // 
            this.customersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersButton.Location = new System.Drawing.Point(14, 63);
            this.customersButton.Name = "customersButton";
            this.customersButton.Size = new System.Drawing.Size(397, 79);
            this.customersButton.TabIndex = 1;
            this.customersButton.Text = "Customers";
            this.customersButton.UseVisualStyleBackColor = true;
            this.customersButton.Click += new System.EventHandler(this.CustomersButton_Click);
            // 
            // appointmentsButton
            // 
            this.appointmentsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentsButton.Location = new System.Drawing.Point(14, 148);
            this.appointmentsButton.Name = "appointmentsButton";
            this.appointmentsButton.Size = new System.Drawing.Size(397, 79);
            this.appointmentsButton.TabIndex = 1;
            this.appointmentsButton.Text = "Appointments";
            this.appointmentsButton.UseVisualStyleBackColor = true;
            this.appointmentsButton.Click += new System.EventHandler(this.AppointmentsButton_Click);
            // 
            // reportsButton
            // 
            this.reportsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsButton.Location = new System.Drawing.Point(14, 233);
            this.reportsButton.Name = "reportsButton";
            this.reportsButton.Size = new System.Drawing.Size(397, 79);
            this.reportsButton.TabIndex = 1;
            this.reportsButton.Text = "Reports";
            this.reportsButton.UseVisualStyleBackColor = true;
            this.reportsButton.Click += new System.EventHandler(this.ReportsButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(14, 318);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(397, 79);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MainHubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(430, 425);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.reportsButton);
            this.Controls.Add(this.appointmentsButton);
            this.Controls.Add(this.customersButton);
            this.Controls.Add(this.mainHubLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainHubForm";
            this.Text = "Main Hub";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainHubForm_FormClosed);
            this.Load += new System.EventHandler(this.MainHubForm_Load);
            this.Shown += new System.EventHandler(this.MainHubForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainHubLabel;
        private System.Windows.Forms.Button customersButton;
        private System.Windows.Forms.Button appointmentsButton;
        private System.Windows.Forms.Button reportsButton;
        private System.Windows.Forms.Button exitButton;
    }
}