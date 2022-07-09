namespace PharmacyManagementSystem
{
    partial class MedicineForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.MedicineName = new System.Windows.Forms.TextBox();
            this.BuyPrice = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.SellPrice = new System.Windows.Forms.TextBox();
            this.MedicineGridView = new System.Windows.Forms.DataGridView();
            this.ExpireDate = new System.Windows.Forms.DateTimePicker();
            this.CompanySelect = new System.Windows.Forms.ComboBox();
            this.Add = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MedicineGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medicine Stock";
            // 
            // MedicineName
            // 
            this.MedicineName.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MedicineName.ForeColor = System.Drawing.Color.DarkGreen;
            this.MedicineName.Location = new System.Drawing.Point(16, 83);
            this.MedicineName.Margin = new System.Windows.Forms.Padding(2);
            this.MedicineName.Name = "MedicineName";
            this.MedicineName.Size = new System.Drawing.Size(198, 29);
            this.MedicineName.TabIndex = 1;
            this.MedicineName.TextChanged += new System.EventHandler(this.MedicineName_TextChanged);
            // 
            // BuyPrice
            // 
            this.BuyPrice.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BuyPrice.ForeColor = System.Drawing.Color.DarkGreen;
            this.BuyPrice.Location = new System.Drawing.Point(17, 146);
            this.BuyPrice.Margin = new System.Windows.Forms.Padding(2);
            this.BuyPrice.Name = "BuyPrice";
            this.BuyPrice.Size = new System.Drawing.Size(198, 29);
            this.BuyPrice.TabIndex = 1;
            // 
            // Quantity
            // 
            this.Quantity.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Quantity.ForeColor = System.Drawing.Color.DarkGreen;
            this.Quantity.Location = new System.Drawing.Point(17, 283);
            this.Quantity.Margin = new System.Windows.Forms.Padding(2);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(198, 29);
            this.Quantity.TabIndex = 1;
            // 
            // SellPrice
            // 
            this.SellPrice.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SellPrice.ForeColor = System.Drawing.Color.DarkGreen;
            this.SellPrice.Location = new System.Drawing.Point(17, 214);
            this.SellPrice.Margin = new System.Windows.Forms.Padding(2);
            this.SellPrice.Name = "SellPrice";
            this.SellPrice.Size = new System.Drawing.Size(198, 29);
            this.SellPrice.TabIndex = 1;
            // 
            // MedicineGridView
            // 
            this.MedicineGridView.AllowUserToAddRows = false;
            this.MedicineGridView.AllowUserToDeleteRows = false;
            this.MedicineGridView.AllowUserToOrderColumns = true;
            this.MedicineGridView.BackgroundColor = System.Drawing.Color.White;
            this.MedicineGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MedicineGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.MedicineGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MedicineGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.MedicineGridView.GridColor = System.Drawing.Color.DarkGray;
            this.MedicineGridView.Location = new System.Drawing.Point(271, 10);
            this.MedicineGridView.Margin = new System.Windows.Forms.Padding(2);
            this.MedicineGridView.Name = "MedicineGridView";
            this.MedicineGridView.ReadOnly = true;
            this.MedicineGridView.RowHeadersWidth = 51;
            this.MedicineGridView.RowTemplate.Height = 24;
            this.MedicineGridView.Size = new System.Drawing.Size(998, 526);
            this.MedicineGridView.TabIndex = 2;
            this.MedicineGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MedicineGridView_CellContentClick);
            // 
            // ExpireDate
            // 
            this.ExpireDate.CalendarForeColor = System.Drawing.Color.DarkGreen;
            this.ExpireDate.CalendarTitleForeColor = System.Drawing.Color.DarkGreen;
            this.ExpireDate.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExpireDate.Location = new System.Drawing.Point(17, 409);
            this.ExpireDate.Margin = new System.Windows.Forms.Padding(2);
            this.ExpireDate.Name = "ExpireDate";
            this.ExpireDate.Size = new System.Drawing.Size(198, 19);
            this.ExpireDate.TabIndex = 3;
            // 
            // CompanySelect
            // 
            this.CompanySelect.FormattingEnabled = true;
            this.CompanySelect.Items.AddRange(new object[] {
            "MediLab",
            "Biochem",
            "Emerald",
            "W. Corp.",
            "Wayne Pharmaceuticals"});
            this.CompanySelect.Location = new System.Drawing.Point(17, 349);
            this.CompanySelect.Margin = new System.Windows.Forms.Padding(2);
            this.CompanySelect.Name = "CompanySelect";
            this.CompanySelect.Size = new System.Drawing.Size(198, 21);
            this.CompanySelect.TabIndex = 4;
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.Lime;
            this.Add.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.White;
            this.Add.Location = new System.Drawing.Point(17, 432);
            this.Add.Margin = new System.Windows.Forms.Padding(2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(90, 32);
            this.Add.TabIndex = 5;
            this.Add.Text = "ADD";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.Lime;
            this.Update.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.ForeColor = System.Drawing.Color.White;
            this.Update.Location = new System.Drawing.Point(125, 432);
            this.Update.Margin = new System.Windows.Forms.Padding(2);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(90, 32);
            this.Update.TabIndex = 5;
            this.Update.Text = "UPDATE";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Red;
            this.Back.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.White;
            this.Back.Location = new System.Drawing.Point(11, 542);
            this.Back.Margin = new System.Windows.Forms.Padding(2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(90, 32);
            this.Back.TabIndex = 5;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Red;
            this.Delete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.Location = new System.Drawing.Point(1072, 543);
            this.Delete.Margin = new System.Windows.Forms.Padding(2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(197, 32);
            this.Delete.TabIndex = 5;
            this.Delete.Text = "DELETE";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Medicine Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Buying Price";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Selling Price";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Quantity";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Company Name";
            this.label6.Click += new System.EventHandler(this.label2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(15, 389);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Expiration Date";
            this.label7.Click += new System.EventHandler(this.label2_Click);
            // 
            // MedicineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1280, 585);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.CompanySelect);
            this.Controls.Add(this.ExpireDate);
            this.Controls.Add(this.MedicineGridView);
            this.Controls.Add(this.SellPrice);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.BuyPrice);
            this.Controls.Add(this.MedicineName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MedicineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MedicineForm";
            this.Load += new System.EventHandler(this.MedicineForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MedicineGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MedicineName;
        private System.Windows.Forms.TextBox BuyPrice;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.TextBox SellPrice;
        private System.Windows.Forms.DataGridView MedicineGridView;
        private System.Windows.Forms.DateTimePicker ExpireDate;
        private System.Windows.Forms.ComboBox CompanySelect;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}