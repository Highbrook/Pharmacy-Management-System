namespace PharmacyManagementSystem
{
    partial class OrdersForm
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
            this.OrderLabel = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.ItemQuantityLabel = new System.Windows.Forms.Label();
            this.MedicineItemNameLabel = new System.Windows.Forms.Label();
            this.ItemBuyPriceLabel = new System.Windows.Forms.Label();
            this.DeliveredLabel = new System.Windows.Forms.Label();
            this.OrderNumberLabel = new System.Windows.Forms.Label();
            this.Manufacturer = new System.Windows.Forms.ComboBox();
            this.ItemBuyPrice = new System.Windows.Forms.TextBox();
            this.ItemQuantity = new System.Windows.Forms.TextBox();
            this.MedicineItemName = new System.Windows.Forms.TextBox();
            this.OrderNumber = new System.Windows.Forms.TextBox();
            this.Delivered = new System.Windows.Forms.ComboBox();
            this.CreateOrderBtn = new System.Windows.Forms.Button();
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
            // OrderLabel
            // 
            this.OrderLabel.AutoSize = true;
            this.OrderLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderLabel.ForeColor = System.Drawing.Color.White;
            this.OrderLabel.Location = new System.Drawing.Point(11, 11);
            this.OrderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OrderLabel.Name = "OrderLabel";
            this.OrderLabel.Size = new System.Drawing.Size(126, 37);
            this.OrderLabel.TabIndex = 16;
            this.OrderLabel.Text = "Orders";
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
            this.Delete.Location = new System.Drawing.Point(1073, 542);
            this.Delete.Margin = new System.Windows.Forms.Padding(2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(197, 32);
            this.Delete.TabIndex = 30;
            this.Delete.Text = "DELETE";
            this.Delete.UseVisualStyleBackColor = false;
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ManufacturerLabel.ForeColor = System.Drawing.Color.White;
            this.ManufacturerLabel.Location = new System.Drawing.Point(16, 295);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(98, 18);
            this.ManufacturerLabel.TabIndex = 44;
            this.ManufacturerLabel.Text = "Manufacturer";
            // 
            // ItemQuantityLabel
            // 
            this.ItemQuantityLabel.AutoSize = true;
            this.ItemQuantityLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ItemQuantityLabel.ForeColor = System.Drawing.Color.White;
            this.ItemQuantityLabel.Location = new System.Drawing.Point(16, 178);
            this.ItemQuantityLabel.Name = "ItemQuantityLabel";
            this.ItemQuantityLabel.Size = new System.Drawing.Size(97, 18);
            this.ItemQuantityLabel.TabIndex = 42;
            this.ItemQuantityLabel.Text = "Item Quantity";
            // 
            // MedicineItemNameLabel
            // 
            this.MedicineItemNameLabel.AutoSize = true;
            this.MedicineItemNameLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MedicineItemNameLabel.ForeColor = System.Drawing.Color.White;
            this.MedicineItemNameLabel.Location = new System.Drawing.Point(16, 122);
            this.MedicineItemNameLabel.Name = "MedicineItemNameLabel";
            this.MedicineItemNameLabel.Size = new System.Drawing.Size(151, 18);
            this.MedicineItemNameLabel.TabIndex = 43;
            this.MedicineItemNameLabel.Text = "Medicine Item Name";
            // 
            // ItemBuyPriceLabel
            // 
            this.ItemBuyPriceLabel.AutoSize = true;
            this.ItemBuyPriceLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ItemBuyPriceLabel.ForeColor = System.Drawing.Color.White;
            this.ItemBuyPriceLabel.Location = new System.Drawing.Point(16, 236);
            this.ItemBuyPriceLabel.Name = "ItemBuyPriceLabel";
            this.ItemBuyPriceLabel.Size = new System.Drawing.Size(108, 18);
            this.ItemBuyPriceLabel.TabIndex = 40;
            this.ItemBuyPriceLabel.Text = "Item Buy Price";
            // 
            // DeliveredLabel
            // 
            this.DeliveredLabel.AutoSize = true;
            this.DeliveredLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeliveredLabel.ForeColor = System.Drawing.Color.White;
            this.DeliveredLabel.Location = new System.Drawing.Point(16, 343);
            this.DeliveredLabel.Name = "DeliveredLabel";
            this.DeliveredLabel.Size = new System.Drawing.Size(75, 18);
            this.DeliveredLabel.TabIndex = 39;
            this.DeliveredLabel.Text = "Delivered";
            // 
            // OrderNumberLabel
            // 
            this.OrderNumberLabel.AutoSize = true;
            this.OrderNumberLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OrderNumberLabel.ForeColor = System.Drawing.Color.White;
            this.OrderNumberLabel.Location = new System.Drawing.Point(17, 64);
            this.OrderNumberLabel.Name = "OrderNumberLabel";
            this.OrderNumberLabel.Size = new System.Drawing.Size(107, 18);
            this.OrderNumberLabel.TabIndex = 38;
            this.OrderNumberLabel.Text = "Order Number";
            // 
            // Manufacturer
            // 
            this.Manufacturer.FormattingEnabled = true;
            this.Manufacturer.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Transgender",
            "Other"});
            this.Manufacturer.Location = new System.Drawing.Point(18, 315);
            this.Manufacturer.Margin = new System.Windows.Forms.Padding(2);
            this.Manufacturer.Name = "Manufacturer";
            this.Manufacturer.Size = new System.Drawing.Size(198, 21);
            this.Manufacturer.TabIndex = 37;
            // 
            // ItemBuyPrice
            // 
            this.ItemBuyPrice.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ItemBuyPrice.ForeColor = System.Drawing.Color.DarkGreen;
            this.ItemBuyPrice.Location = new System.Drawing.Point(18, 256);
            this.ItemBuyPrice.Margin = new System.Windows.Forms.Padding(2);
            this.ItemBuyPrice.Name = "ItemBuyPrice";
            this.ItemBuyPrice.Size = new System.Drawing.Size(198, 29);
            this.ItemBuyPrice.TabIndex = 35;
            // 
            // ItemQuantity
            // 
            this.ItemQuantity.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ItemQuantity.ForeColor = System.Drawing.Color.DarkGreen;
            this.ItemQuantity.Location = new System.Drawing.Point(18, 198);
            this.ItemQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.ItemQuantity.Name = "ItemQuantity";
            this.ItemQuantity.Size = new System.Drawing.Size(198, 29);
            this.ItemQuantity.TabIndex = 33;
            // 
            // MedicineItemName
            // 
            this.MedicineItemName.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MedicineItemName.ForeColor = System.Drawing.Color.DarkGreen;
            this.MedicineItemName.Location = new System.Drawing.Point(18, 142);
            this.MedicineItemName.Margin = new System.Windows.Forms.Padding(2);
            this.MedicineItemName.Name = "MedicineItemName";
            this.MedicineItemName.Size = new System.Drawing.Size(198, 29);
            this.MedicineItemName.TabIndex = 34;
            // 
            // OrderNumber
            // 
            this.OrderNumber.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OrderNumber.ForeColor = System.Drawing.Color.DarkGreen;
            this.OrderNumber.Location = new System.Drawing.Point(18, 84);
            this.OrderNumber.Margin = new System.Windows.Forms.Padding(2);
            this.OrderNumber.Name = "OrderNumber";
            this.OrderNumber.Size = new System.Drawing.Size(198, 29);
            this.OrderNumber.TabIndex = 36;
            // 
            // Delivered
            // 
            this.Delivered.FormattingEnabled = true;
            this.Delivered.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Transgender",
            "Other"});
            this.Delivered.Location = new System.Drawing.Point(18, 363);
            this.Delivered.Margin = new System.Windows.Forms.Padding(2);
            this.Delivered.Name = "Delivered";
            this.Delivered.Size = new System.Drawing.Size(198, 21);
            this.Delivered.TabIndex = 45;
            // 
            // CreateOrderBtn
            // 
            this.CreateOrderBtn.BackColor = System.Drawing.Color.Lime;
            this.CreateOrderBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateOrderBtn.ForeColor = System.Drawing.Color.White;
            this.CreateOrderBtn.Location = new System.Drawing.Point(272, 542);
            this.CreateOrderBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CreateOrderBtn.Name = "CreateOrderBtn";
            this.CreateOrderBtn.Size = new System.Drawing.Size(197, 32);
            this.CreateOrderBtn.TabIndex = 46;
            this.CreateOrderBtn.Text = "CREATE ORDER";
            this.CreateOrderBtn.UseVisualStyleBackColor = false;
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1280, 585);
            this.Controls.Add(this.CreateOrderBtn);
            this.Controls.Add(this.Delivered);
            this.Controls.Add(this.ManufacturerLabel);
            this.Controls.Add(this.ItemQuantityLabel);
            this.Controls.Add(this.MedicineItemNameLabel);
            this.Controls.Add(this.ItemBuyPriceLabel);
            this.Controls.Add(this.DeliveredLabel);
            this.Controls.Add(this.OrderNumberLabel);
            this.Controls.Add(this.Manufacturer);
            this.Controls.Add(this.ItemBuyPrice);
            this.Controls.Add(this.ItemQuantity);
            this.Controls.Add(this.MedicineItemName);
            this.Controls.Add(this.OrderNumber);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.OrderLabel);
            this.Controls.Add(this.EmployeeGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrdersForm";
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EmployeeGridView;
        private System.Windows.Forms.Label OrderLabel;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Label ItemQuantityLabel;
        private System.Windows.Forms.Label MedicineItemNameLabel;
        private System.Windows.Forms.Label ItemBuyPriceLabel;
        private System.Windows.Forms.Label DeliveredLabel;
        private System.Windows.Forms.Label OrderNumberLabel;
        private System.Windows.Forms.ComboBox Manufacturer;
        private System.Windows.Forms.TextBox ItemBuyPrice;
        private System.Windows.Forms.TextBox ItemQuantity;
        private System.Windows.Forms.TextBox MedicineItemName;
        private System.Windows.Forms.TextBox OrderNumber;
        private System.Windows.Forms.ComboBox Delivered;
        private System.Windows.Forms.Button CreateOrderBtn;
    }
}