namespace PharmacyManagementSystem
{
    partial class MainForm
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
            this.MedicineStockBtn = new System.Windows.Forms.Button();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.WelcomeNameLabel = new System.Windows.Forms.Label();
            this.EmployeePageBtn = new System.Windows.Forms.Button();
            this.MedManufBtn = new System.Windows.Forms.Button();
            this.OrderListBtn = new System.Windows.Forms.Button();
            this.PerscriptionsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MedicineStockBtn
            // 
            this.MedicineStockBtn.BackColor = System.Drawing.Color.Lime;
            this.MedicineStockBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicineStockBtn.ForeColor = System.Drawing.Color.White;
            this.MedicineStockBtn.Location = new System.Drawing.Point(108, 150);
            this.MedicineStockBtn.Margin = new System.Windows.Forms.Padding(2);
            this.MedicineStockBtn.Name = "MedicineStockBtn";
            this.MedicineStockBtn.Size = new System.Drawing.Size(399, 56);
            this.MedicineStockBtn.TabIndex = 8;
            this.MedicineStockBtn.Text = "Medicine Stock";
            this.MedicineStockBtn.UseVisualStyleBackColor = false;
            this.MedicineStockBtn.Click += new System.EventHandler(this.MedicineStockBtn_Click);
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.ForeColor = System.Drawing.Color.White;
            this.WelcomeLabel.Location = new System.Drawing.Point(4, 9);
            this.WelcomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(160, 37);
            this.WelcomeLabel.TabIndex = 9;
            this.WelcomeLabel.Text = "Welcome";
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.Red;
            this.LogoutBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.ForeColor = System.Drawing.Color.White;
            this.LogoutBtn.Location = new System.Drawing.Point(11, 445);
            this.LogoutBtn.Margin = new System.Windows.Forms.Padding(2);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(90, 32);
            this.LogoutBtn.TabIndex = 11;
            this.LogoutBtn.Text = "Log Out";
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Click += new System.EventHandler(this.Back_Click);
            // 
            // WelcomeNameLabel
            // 
            this.WelcomeNameLabel.AutoSize = true;
            this.WelcomeNameLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeNameLabel.ForeColor = System.Drawing.Color.White;
            this.WelcomeNameLabel.Location = new System.Drawing.Point(153, 9);
            this.WelcomeNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WelcomeNameLabel.Name = "WelcomeNameLabel";
            this.WelcomeNameLabel.Size = new System.Drawing.Size(97, 37);
            this.WelcomeNameLabel.TabIndex = 9;
            this.WelcomeNameLabel.Text = "Anon";
            // 
            // EmployeePageBtn
            // 
            this.EmployeePageBtn.BackColor = System.Drawing.Color.Lime;
            this.EmployeePageBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeePageBtn.ForeColor = System.Drawing.Color.White;
            this.EmployeePageBtn.Location = new System.Drawing.Point(108, 296);
            this.EmployeePageBtn.Margin = new System.Windows.Forms.Padding(2);
            this.EmployeePageBtn.Name = "EmployeePageBtn";
            this.EmployeePageBtn.Size = new System.Drawing.Size(399, 56);
            this.EmployeePageBtn.TabIndex = 8;
            this.EmployeePageBtn.Text = "Employee Page";
            this.EmployeePageBtn.UseVisualStyleBackColor = false;
            this.EmployeePageBtn.Click += new System.EventHandler(this.EmployeePageBtn_Click);
            // 
            // MedManufBtn
            // 
            this.MedManufBtn.BackColor = System.Drawing.Color.Lime;
            this.MedManufBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedManufBtn.ForeColor = System.Drawing.Color.White;
            this.MedManufBtn.Location = new System.Drawing.Point(108, 223);
            this.MedManufBtn.Margin = new System.Windows.Forms.Padding(2);
            this.MedManufBtn.Name = "MedManufBtn";
            this.MedManufBtn.Size = new System.Drawing.Size(399, 56);
            this.MedManufBtn.TabIndex = 8;
            this.MedManufBtn.Text = "Medicine Manufacturers";
            this.MedManufBtn.UseVisualStyleBackColor = false;
            this.MedManufBtn.Click += new System.EventHandler(this.MedManufBtn_Click);
            // 
            // OrderListBtn
            // 
            this.OrderListBtn.BackColor = System.Drawing.Color.Lime;
            this.OrderListBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderListBtn.ForeColor = System.Drawing.Color.White;
            this.OrderListBtn.Location = new System.Drawing.Point(108, 367);
            this.OrderListBtn.Margin = new System.Windows.Forms.Padding(2);
            this.OrderListBtn.Name = "OrderListBtn";
            this.OrderListBtn.Size = new System.Drawing.Size(399, 56);
            this.OrderListBtn.TabIndex = 8;
            this.OrderListBtn.Text = "Order List";
            this.OrderListBtn.UseVisualStyleBackColor = false;
            this.OrderListBtn.Click += new System.EventHandler(this.OrderListBtn_Click);
            // 
            // PerscriptionsBtn
            // 
            this.PerscriptionsBtn.BackColor = System.Drawing.Color.Lime;
            this.PerscriptionsBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PerscriptionsBtn.ForeColor = System.Drawing.Color.White;
            this.PerscriptionsBtn.Location = new System.Drawing.Point(108, 78);
            this.PerscriptionsBtn.Margin = new System.Windows.Forms.Padding(2);
            this.PerscriptionsBtn.Name = "PerscriptionsBtn";
            this.PerscriptionsBtn.Size = new System.Drawing.Size(399, 56);
            this.PerscriptionsBtn.TabIndex = 12;
            this.PerscriptionsBtn.Text = "Perscriptions";
            this.PerscriptionsBtn.UseVisualStyleBackColor = false;
            this.PerscriptionsBtn.Click += new System.EventHandler(this.PerscriptionsBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(600, 488);
            this.Controls.Add(this.PerscriptionsBtn);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.WelcomeNameLabel);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.MedManufBtn);
            this.Controls.Add(this.OrderListBtn);
            this.Controls.Add(this.EmployeePageBtn);
            this.Controls.Add(this.MedicineStockBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MedicineStockBtn;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Label WelcomeNameLabel;
        private System.Windows.Forms.Button EmployeePageBtn;
        private System.Windows.Forms.Button MedManufBtn;
        private System.Windows.Forms.Button OrderListBtn;
        private System.Windows.Forms.Button PerscriptionsBtn;
    }
}