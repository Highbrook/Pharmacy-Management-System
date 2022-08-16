namespace PharmacyManagementSystem
{
    partial class MedicineManufacturersForm
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
            this.MedManufLabel = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.MedicineNameLabel = new System.Windows.Forms.Label();
            this.ManufacturerNameLabel = new System.Windows.Forms.Label();
            this.ManufacturerIDLabel = new System.Windows.Forms.Label();
            this.MedicineName = new System.Windows.Forms.TextBox();
            this.ManufacturerName = new System.Windows.Forms.TextBox();
            this.ManufacturerID = new System.Windows.Forms.TextBox();
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
            this.EmployeeGridView.TabIndex = 15;
            // 
            // MedManufLabel
            // 
            this.MedManufLabel.AutoSize = true;
            this.MedManufLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedManufLabel.ForeColor = System.Drawing.Color.White;
            this.MedManufLabel.Location = new System.Drawing.Point(11, 9);
            this.MedManufLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MedManufLabel.Name = "MedManufLabel";
            this.MedManufLabel.Size = new System.Drawing.Size(244, 37);
            this.MedManufLabel.TabIndex = 16;
            this.MedManufLabel.Text = "Manufacturers";
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
            this.ClearBtn.Location = new System.Drawing.Point(126, 507);
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
            this.Search.Location = new System.Drawing.Point(18, 507);
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
            this.Update.Location = new System.Drawing.Point(126, 471);
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
            this.Add.Location = new System.Drawing.Point(18, 471);
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
            this.Delete.Location = new System.Drawing.Point(1073, 541);
            this.Delete.Margin = new System.Windows.Forms.Padding(2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(197, 32);
            this.Delete.TabIndex = 30;
            this.Delete.Text = "DELETE";
            this.Delete.UseVisualStyleBackColor = false;
            // 
            // MedicineNameLabel
            // 
            this.MedicineNameLabel.AutoSize = true;
            this.MedicineNameLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MedicineNameLabel.ForeColor = System.Drawing.Color.White;
            this.MedicineNameLabel.Location = new System.Drawing.Point(17, 192);
            this.MedicineNameLabel.Name = "MedicineNameLabel";
            this.MedicineNameLabel.Size = new System.Drawing.Size(118, 18);
            this.MedicineNameLabel.TabIndex = 39;
            this.MedicineNameLabel.Text = "Medicine Name";
            // 
            // ManufacturerNameLabel
            // 
            this.ManufacturerNameLabel.AutoSize = true;
            this.ManufacturerNameLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ManufacturerNameLabel.ForeColor = System.Drawing.Color.White;
            this.ManufacturerNameLabel.Location = new System.Drawing.Point(17, 74);
            this.ManufacturerNameLabel.Name = "ManufacturerNameLabel";
            this.ManufacturerNameLabel.Size = new System.Drawing.Size(144, 18);
            this.ManufacturerNameLabel.TabIndex = 38;
            this.ManufacturerNameLabel.Text = "Manufacturer Name";
            // 
            // ManufacturerIDLabel
            // 
            this.ManufacturerIDLabel.AutoSize = true;
            this.ManufacturerIDLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ManufacturerIDLabel.ForeColor = System.Drawing.Color.White;
            this.ManufacturerIDLabel.Location = new System.Drawing.Point(17, 134);
            this.ManufacturerIDLabel.Name = "ManufacturerIDLabel";
            this.ManufacturerIDLabel.Size = new System.Drawing.Size(117, 18);
            this.ManufacturerIDLabel.TabIndex = 37;
            this.ManufacturerIDLabel.Text = "Manufacturer ID";
            // 
            // MedicineName
            // 
            this.MedicineName.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MedicineName.ForeColor = System.Drawing.Color.DarkGreen;
            this.MedicineName.Location = new System.Drawing.Point(19, 212);
            this.MedicineName.Margin = new System.Windows.Forms.Padding(2);
            this.MedicineName.Name = "MedicineName";
            this.MedicineName.Size = new System.Drawing.Size(198, 29);
            this.MedicineName.TabIndex = 35;
            // 
            // ManufacturerName
            // 
            this.ManufacturerName.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ManufacturerName.ForeColor = System.Drawing.Color.DarkGreen;
            this.ManufacturerName.Location = new System.Drawing.Point(19, 94);
            this.ManufacturerName.Margin = new System.Windows.Forms.Padding(2);
            this.ManufacturerName.Name = "ManufacturerName";
            this.ManufacturerName.Size = new System.Drawing.Size(198, 29);
            this.ManufacturerName.TabIndex = 31;
            // 
            // ManufacturerID
            // 
            this.ManufacturerID.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ManufacturerID.ForeColor = System.Drawing.Color.DarkGreen;
            this.ManufacturerID.Location = new System.Drawing.Point(18, 154);
            this.ManufacturerID.Margin = new System.Windows.Forms.Padding(2);
            this.ManufacturerID.Name = "ManufacturerID";
            this.ManufacturerID.Size = new System.Drawing.Size(198, 29);
            this.ManufacturerID.TabIndex = 36;
            // 
            // MedicineManufacturersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1280, 585);
            this.Controls.Add(this.MedicineNameLabel);
            this.Controls.Add(this.ManufacturerNameLabel);
            this.Controls.Add(this.ManufacturerIDLabel);
            this.Controls.Add(this.MedicineName);
            this.Controls.Add(this.ManufacturerName);
            this.Controls.Add(this.ManufacturerID);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.MedManufLabel);
            this.Controls.Add(this.EmployeeGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MedicineManufacturersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MedicineManufacturersForm";
            this.Load += new System.EventHandler(this.MedicineManufacturersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EmployeeGridView;
        private System.Windows.Forms.Label MedManufLabel;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label MedicineNameLabel;
        private System.Windows.Forms.Label ManufacturerNameLabel;
        private System.Windows.Forms.Label ManufacturerIDLabel;
        private System.Windows.Forms.TextBox MedicineName;
        private System.Windows.Forms.TextBox ManufacturerName;
        private System.Windows.Forms.TextBox ManufacturerID;
    }
}