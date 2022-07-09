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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.MedicineName = new System.Windows.Forms.TextBox();
            this.BuyPrice = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.SellPrice = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MedName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpireDate = new System.Windows.Forms.DateTimePicker();
            this.CompanySelect = new System.Windows.Forms.ComboBox();
            this.Add = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.MedicineName.Location = new System.Drawing.Point(15, 55);
            this.MedicineName.Margin = new System.Windows.Forms.Padding(2);
            this.MedicineName.Name = "MedicineName";
            this.MedicineName.Size = new System.Drawing.Size(198, 29);
            this.MedicineName.TabIndex = 1;
            this.MedicineName.Text = "Medicine Name";
            this.MedicineName.TextChanged += new System.EventHandler(this.MedicineName_TextChanged);
            // 
            // BuyPrice
            // 
            this.BuyPrice.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BuyPrice.ForeColor = System.Drawing.Color.DarkGreen;
            this.BuyPrice.Location = new System.Drawing.Point(15, 88);
            this.BuyPrice.Margin = new System.Windows.Forms.Padding(2);
            this.BuyPrice.Name = "BuyPrice";
            this.BuyPrice.Size = new System.Drawing.Size(198, 29);
            this.BuyPrice.TabIndex = 1;
            this.BuyPrice.Text = "Buying Price";
            // 
            // Quantity
            // 
            this.Quantity.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Quantity.ForeColor = System.Drawing.Color.DarkGreen;
            this.Quantity.Location = new System.Drawing.Point(15, 153);
            this.Quantity.Margin = new System.Windows.Forms.Padding(2);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(198, 29);
            this.Quantity.TabIndex = 1;
            this.Quantity.Text = "Quantity";
            // 
            // SellPrice
            // 
            this.SellPrice.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SellPrice.ForeColor = System.Drawing.Color.DarkGreen;
            this.SellPrice.Location = new System.Drawing.Point(15, 120);
            this.SellPrice.Margin = new System.Windows.Forms.Padding(2);
            this.SellPrice.Name = "SellPrice";
            this.SellPrice.Size = new System.Drawing.Size(198, 29);
            this.SellPrice.TabIndex = 1;
            this.SellPrice.Text = "Selling Price";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MedName,
            this.BPrice,
            this.SPrice,
            this.Quant,
            this.ExpDate,
            this.Company});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridView1.Location = new System.Drawing.Point(271, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(675, 566);
            this.dataGridView1.TabIndex = 2;
            // 
            // MedName
            // 
            this.MedName.HeaderText = "Medicine";
            this.MedName.MinimumWidth = 6;
            this.MedName.Name = "MedName";
            this.MedName.ToolTipText = "List of medical items";
            this.MedName.Width = 200;
            // 
            // BPrice
            // 
            this.BPrice.HeaderText = "Buy Price";
            this.BPrice.MinimumWidth = 6;
            this.BPrice.Name = "BPrice";
            this.BPrice.ToolTipText = "Purchase price of item";
            this.BPrice.Width = 125;
            // 
            // SPrice
            // 
            this.SPrice.HeaderText = "Sell Price";
            this.SPrice.MinimumWidth = 6;
            this.SPrice.Name = "SPrice";
            this.SPrice.ToolTipText = "Selling price of item";
            this.SPrice.Width = 125;
            // 
            // Quant
            // 
            this.Quant.HeaderText = "Quantity";
            this.Quant.MinimumWidth = 6;
            this.Quant.Name = "Quant";
            this.Quant.ToolTipText = "Quantity of item";
            this.Quant.Width = 125;
            // 
            // ExpDate
            // 
            this.ExpDate.HeaderText = "Exp. Date";
            this.ExpDate.MinimumWidth = 6;
            this.ExpDate.Name = "ExpDate";
            this.ExpDate.ToolTipText = "Expiration date of item";
            this.ExpDate.Width = 125;
            // 
            // Company
            // 
            this.Company.HeaderText = "Company";
            this.Company.MinimumWidth = 6;
            this.Company.Name = "Company";
            this.Company.ToolTipText = "Manufacturer of item";
            this.Company.Width = 125;
            // 
            // ExpireDate
            // 
            this.ExpireDate.CalendarForeColor = System.Drawing.Color.DarkGreen;
            this.ExpireDate.CalendarTitleForeColor = System.Drawing.Color.DarkGreen;
            this.ExpireDate.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExpireDate.Location = new System.Drawing.Point(15, 210);
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
            this.CompanySelect.Location = new System.Drawing.Point(15, 185);
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
            this.Add.Location = new System.Drawing.Point(15, 392);
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
            this.Update.Location = new System.Drawing.Point(122, 392);
            this.Update.Margin = new System.Windows.Forms.Padding(2);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(90, 32);
            this.Update.TabIndex = 5;
            this.Update.Text = "UPDATE";
            this.Update.UseVisualStyleBackColor = false;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Red;
            this.Back.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.White;
            this.Back.Location = new System.Drawing.Point(15, 543);
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
            this.Delete.Location = new System.Drawing.Point(15, 430);
            this.Delete.Margin = new System.Windows.Forms.Padding(2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(197, 32);
            this.Delete.TabIndex = 5;
            this.Delete.Text = "DELETE";
            this.Delete.UseVisualStyleBackColor = false;
            // 
            // MedicineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(960, 585);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.CompanySelect);
            this.Controls.Add(this.ExpireDate);
            this.Controls.Add(this.dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MedicineName;
        private System.Windows.Forms.TextBox BuyPrice;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.TextBox SellPrice;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker ExpireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quant;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.ComboBox CompanySelect;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Delete;
    }
}