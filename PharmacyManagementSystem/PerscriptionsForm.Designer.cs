namespace PharmacyManagementSystem
{
    partial class PerscriptionsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.EmployeeGridView = new System.Windows.Forms.DataGridView();
            this.PerscriptionsLabel = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.PatientNameLabel = new System.Windows.Forms.Label();
            this.PatientName = new System.Windows.Forms.TextBox();
            this.DoctroNameLabel = new System.Windows.Forms.Label();
            this.DoctorName = new System.Windows.Forms.TextBox();
            this.PerscriptionIDLabel = new System.Windows.Forms.Label();
            this.PerscriptionID = new System.Windows.Forms.TextBox();
            this.PatientUMCNLabel = new System.Windows.Forms.Label();
            this.PatientUMCN = new System.Windows.Forms.TextBox();
            this.ExpirateionDateLabel = new System.Windows.Forms.Label();
            this.ExpDate = new System.Windows.Forms.DateTimePicker();
            this.PerscribedMedicineLabel = new System.Windows.Forms.Label();
            this.PerscribedMedicine = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeGridView
            // 
            this.EmployeeGridView.AllowUserToAddRows = false;
            this.EmployeeGridView.AllowUserToDeleteRows = false;
            this.EmployeeGridView.AllowUserToOrderColumns = true;
            this.EmployeeGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.EmployeeGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.EmployeeGridView.BackgroundColor = System.Drawing.Color.White;
            this.EmployeeGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.EmployeeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeeGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.EmployeeGridView.GridColor = System.Drawing.Color.DarkGray;
            this.EmployeeGridView.Location = new System.Drawing.Point(272, 11);
            this.EmployeeGridView.Margin = new System.Windows.Forms.Padding(2);
            this.EmployeeGridView.Name = "EmployeeGridView";
            this.EmployeeGridView.ReadOnly = true;
            this.EmployeeGridView.RowHeadersWidth = 40;
            this.EmployeeGridView.RowTemplate.Height = 24;
            this.EmployeeGridView.Size = new System.Drawing.Size(998, 526);
            this.EmployeeGridView.TabIndex = 14;
            // 
            // PerscriptionsLabel
            // 
            this.PerscriptionsLabel.AutoSize = true;
            this.PerscriptionsLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PerscriptionsLabel.ForeColor = System.Drawing.Color.White;
            this.PerscriptionsLabel.Location = new System.Drawing.Point(11, 11);
            this.PerscriptionsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PerscriptionsLabel.Name = "PerscriptionsLabel";
            this.PerscriptionsLabel.Size = new System.Drawing.Size(225, 37);
            this.PerscriptionsLabel.TabIndex = 15;
            this.PerscriptionsLabel.Text = "Perscriptions";
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Red;
            this.Back.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.White;
            this.Back.Location = new System.Drawing.Point(18, 542);
            this.Back.Margin = new System.Windows.Forms.Padding(2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(90, 32);
            this.Back.TabIndex = 19;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.Lime;
            this.ClearBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.ForeColor = System.Drawing.Color.White;
            this.ClearBtn.Location = new System.Drawing.Point(126, 506);
            this.ClearBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(90, 32);
            this.ClearBtn.TabIndex = 29;
            this.ClearBtn.Text = "CLEAR";
            this.ClearBtn.UseVisualStyleBackColor = false;
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.Lime;
            this.Search.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.Color.White;
            this.Search.Location = new System.Drawing.Point(18, 506);
            this.Search.Margin = new System.Windows.Forms.Padding(2);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(90, 32);
            this.Search.TabIndex = 28;
            this.Search.Text = "SEARCH";
            this.Search.UseVisualStyleBackColor = false;
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.Lime;
            this.Update.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.ForeColor = System.Drawing.Color.White;
            this.Update.Location = new System.Drawing.Point(126, 470);
            this.Update.Margin = new System.Windows.Forms.Padding(2);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(90, 32);
            this.Update.TabIndex = 27;
            this.Update.Text = "UPDATE";
            this.Update.UseVisualStyleBackColor = false;
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.Lime;
            this.Add.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.White;
            this.Add.Location = new System.Drawing.Point(18, 470);
            this.Add.Margin = new System.Windows.Forms.Padding(2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(90, 32);
            this.Add.TabIndex = 26;
            this.Add.Text = "ADD";
            this.Add.UseVisualStyleBackColor = false;
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Red;
            this.Delete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.Location = new System.Drawing.Point(1073, 542);
            this.Delete.Margin = new System.Windows.Forms.Padding(2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(197, 32);
            this.Delete.TabIndex = 30;
            this.Delete.Text = "DELETE";
            this.Delete.UseVisualStyleBackColor = false;
            // 
            // PatientNameLabel
            // 
            this.PatientNameLabel.AutoSize = true;
            this.PatientNameLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PatientNameLabel.ForeColor = System.Drawing.Color.White;
            this.PatientNameLabel.Location = new System.Drawing.Point(16, 64);
            this.PatientNameLabel.Name = "PatientNameLabel";
            this.PatientNameLabel.Size = new System.Drawing.Size(103, 18);
            this.PatientNameLabel.TabIndex = 32;
            this.PatientNameLabel.Text = "Patient Name";
            // 
            // PatientName
            // 
            this.PatientName.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PatientName.ForeColor = System.Drawing.Color.DarkGreen;
            this.PatientName.Location = new System.Drawing.Point(17, 84);
            this.PatientName.Margin = new System.Windows.Forms.Padding(2);
            this.PatientName.Name = "PatientName";
            this.PatientName.Size = new System.Drawing.Size(198, 29);
            this.PatientName.TabIndex = 31;
            // 
            // DoctroNameLabel
            // 
            this.DoctroNameLabel.AutoSize = true;
            this.DoctroNameLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DoctroNameLabel.ForeColor = System.Drawing.Color.White;
            this.DoctroNameLabel.Location = new System.Drawing.Point(16, 179);
            this.DoctroNameLabel.Name = "DoctroNameLabel";
            this.DoctroNameLabel.Size = new System.Drawing.Size(101, 18);
            this.DoctroNameLabel.TabIndex = 34;
            this.DoctroNameLabel.Text = "Doctor Name";
            // 
            // DoctorName
            // 
            this.DoctorName.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DoctorName.ForeColor = System.Drawing.Color.DarkGreen;
            this.DoctorName.Location = new System.Drawing.Point(17, 199);
            this.DoctorName.Margin = new System.Windows.Forms.Padding(2);
            this.DoctorName.Name = "DoctorName";
            this.DoctorName.Size = new System.Drawing.Size(198, 29);
            this.DoctorName.TabIndex = 33;
            // 
            // PerscriptionIDLabel
            // 
            this.PerscriptionIDLabel.AutoSize = true;
            this.PerscriptionIDLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PerscriptionIDLabel.ForeColor = System.Drawing.Color.White;
            this.PerscriptionIDLabel.Location = new System.Drawing.Point(16, 238);
            this.PerscriptionIDLabel.Name = "PerscriptionIDLabel";
            this.PerscriptionIDLabel.Size = new System.Drawing.Size(111, 18);
            this.PerscriptionIDLabel.TabIndex = 36;
            this.PerscriptionIDLabel.Text = "Perscription ID";
            // 
            // PerscriptionID
            // 
            this.PerscriptionID.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PerscriptionID.ForeColor = System.Drawing.Color.DarkGreen;
            this.PerscriptionID.Location = new System.Drawing.Point(17, 258);
            this.PerscriptionID.Margin = new System.Windows.Forms.Padding(2);
            this.PerscriptionID.Name = "PerscriptionID";
            this.PerscriptionID.Size = new System.Drawing.Size(198, 29);
            this.PerscriptionID.TabIndex = 35;
            // 
            // PatientUMCNLabel
            // 
            this.PatientUMCNLabel.AutoSize = true;
            this.PatientUMCNLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PatientUMCNLabel.ForeColor = System.Drawing.Color.White;
            this.PatientUMCNLabel.Location = new System.Drawing.Point(16, 121);
            this.PatientUMCNLabel.Name = "PatientUMCNLabel";
            this.PatientUMCNLabel.Size = new System.Drawing.Size(108, 18);
            this.PatientUMCNLabel.TabIndex = 38;
            this.PatientUMCNLabel.Text = "Patient UMCN";
            // 
            // PatientUMCN
            // 
            this.PatientUMCN.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PatientUMCN.ForeColor = System.Drawing.Color.DarkGreen;
            this.PatientUMCN.Location = new System.Drawing.Point(17, 141);
            this.PatientUMCN.Margin = new System.Windows.Forms.Padding(2);
            this.PatientUMCN.Name = "PatientUMCN";
            this.PatientUMCN.Size = new System.Drawing.Size(198, 29);
            this.PatientUMCN.TabIndex = 37;
            // 
            // ExpirateionDateLabel
            // 
            this.ExpirateionDateLabel.AutoSize = true;
            this.ExpirateionDateLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExpirateionDateLabel.ForeColor = System.Drawing.Color.White;
            this.ExpirateionDateLabel.Location = new System.Drawing.Point(16, 358);
            this.ExpirateionDateLabel.Name = "ExpirateionDateLabel";
            this.ExpirateionDateLabel.Size = new System.Drawing.Size(116, 18);
            this.ExpirateionDateLabel.TabIndex = 40;
            this.ExpirateionDateLabel.Text = "Expiration Date";
            // 
            // ExpDate
            // 
            this.ExpDate.CalendarForeColor = System.Drawing.Color.DarkGreen;
            this.ExpDate.CalendarTitleForeColor = System.Drawing.Color.DarkGreen;
            this.ExpDate.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExpDate.Location = new System.Drawing.Point(17, 378);
            this.ExpDate.Margin = new System.Windows.Forms.Padding(2);
            this.ExpDate.Name = "ExpDate";
            this.ExpDate.Size = new System.Drawing.Size(198, 19);
            this.ExpDate.TabIndex = 41;
            // 
            // PerscribedMedicineLabel
            // 
            this.PerscribedMedicineLabel.AutoSize = true;
            this.PerscribedMedicineLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PerscribedMedicineLabel.ForeColor = System.Drawing.Color.White;
            this.PerscribedMedicineLabel.Location = new System.Drawing.Point(16, 298);
            this.PerscribedMedicineLabel.Name = "PerscribedMedicineLabel";
            this.PerscribedMedicineLabel.Size = new System.Drawing.Size(153, 18);
            this.PerscribedMedicineLabel.TabIndex = 43;
            this.PerscribedMedicineLabel.Text = "Perscribed Medicine";
            // 
            // PerscribedMedicine
            // 
            this.PerscribedMedicine.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PerscribedMedicine.ForeColor = System.Drawing.Color.DarkGreen;
            this.PerscribedMedicine.Location = new System.Drawing.Point(17, 318);
            this.PerscribedMedicine.Margin = new System.Windows.Forms.Padding(2);
            this.PerscribedMedicine.Name = "PerscribedMedicine";
            this.PerscribedMedicine.Size = new System.Drawing.Size(198, 29);
            this.PerscribedMedicine.TabIndex = 42;
            // 
            // PerscriptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1280, 585);
            this.Controls.Add(this.PerscribedMedicineLabel);
            this.Controls.Add(this.PerscribedMedicine);
            this.Controls.Add(this.ExpDate);
            this.Controls.Add(this.ExpirateionDateLabel);
            this.Controls.Add(this.PatientUMCNLabel);
            this.Controls.Add(this.PatientUMCN);
            this.Controls.Add(this.PerscriptionIDLabel);
            this.Controls.Add(this.PerscriptionID);
            this.Controls.Add(this.DoctroNameLabel);
            this.Controls.Add(this.DoctorName);
            this.Controls.Add(this.PatientNameLabel);
            this.Controls.Add(this.PatientName);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.PerscriptionsLabel);
            this.Controls.Add(this.EmployeeGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PerscriptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PerscriptionsForm";
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EmployeeGridView;
        private System.Windows.Forms.Label PerscriptionsLabel;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label PatientNameLabel;
        private System.Windows.Forms.TextBox PatientName;
        private System.Windows.Forms.Label DoctroNameLabel;
        private System.Windows.Forms.TextBox DoctorName;
        private System.Windows.Forms.Label PerscriptionIDLabel;
        private System.Windows.Forms.TextBox PerscriptionID;
        private System.Windows.Forms.Label PatientUMCNLabel;
        private System.Windows.Forms.TextBox PatientUMCN;
        private System.Windows.Forms.Label ExpirateionDateLabel;
        private System.Windows.Forms.DateTimePicker ExpDate;
        private System.Windows.Forms.Label PerscribedMedicineLabel;
        private System.Windows.Forms.TextBox PerscribedMedicine;
    }
}