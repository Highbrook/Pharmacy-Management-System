namespace PharmacyManagementSystem
{
    partial class Employees
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
            this.Search = new System.Windows.Forms.Button();
            this.EmpGendLabel = new System.Windows.Forms.Label();
            this.EmpSalLabel = new System.Windows.Forms.Label();
            this.EmpAgeLabel = new System.Windows.Forms.Label();
            this.EmpNameLabel = new System.Windows.Forms.Label();
            this.EmpIDLabel = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.EmpGen = new System.Windows.Forms.ComboBox();
            this.EmployeeGridView = new System.Windows.Forms.DataGridView();
            this.EmpAge = new System.Windows.Forms.TextBox();
            this.EmpSal = new System.Windows.Forms.TextBox();
            this.EmpName = new System.Windows.Forms.TextBox();
            this.EmpID = new System.Windows.Forms.TextBox();
            this.EployeesLabel = new System.Windows.Forms.Label();
            this.EmpPhone = new System.Windows.Forms.TextBox();
            this.EmpPhoneLabel = new System.Windows.Forms.Label();
            this.PasswordHash = new System.Windows.Forms.TextBox();
            this.EmpPWLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.Lime;
            this.Search.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.Color.White;
            this.Search.Location = new System.Drawing.Point(18, 505);
            this.Search.Margin = new System.Windows.Forms.Padding(2);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(198, 32);
            this.Search.TabIndex = 24;
            this.Search.Text = "SEARCH";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // EmpGendLabel
            // 
            this.EmpGendLabel.AutoSize = true;
            this.EmpGendLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EmpGendLabel.ForeColor = System.Drawing.Color.White;
            this.EmpGendLabel.Location = new System.Drawing.Point(15, 402);
            this.EmpGendLabel.Name = "EmpGendLabel";
            this.EmpGendLabel.Size = new System.Drawing.Size(134, 18);
            this.EmpGendLabel.TabIndex = 23;
            this.EmpGendLabel.Text = "Employee Gender";
            // 
            // EmpSalLabel
            // 
            this.EmpSalLabel.AutoSize = true;
            this.EmpSalLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EmpSalLabel.ForeColor = System.Drawing.Color.White;
            this.EmpSalLabel.Location = new System.Drawing.Point(15, 232);
            this.EmpSalLabel.Name = "EmpSalLabel";
            this.EmpSalLabel.Size = new System.Drawing.Size(126, 18);
            this.EmpSalLabel.TabIndex = 22;
            this.EmpSalLabel.Text = "Employee Salary";
            // 
            // EmpAgeLabel
            // 
            this.EmpAgeLabel.AutoSize = true;
            this.EmpAgeLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EmpAgeLabel.ForeColor = System.Drawing.Color.White;
            this.EmpAgeLabel.Location = new System.Drawing.Point(15, 177);
            this.EmpAgeLabel.Name = "EmpAgeLabel";
            this.EmpAgeLabel.Size = new System.Drawing.Size(110, 18);
            this.EmpAgeLabel.TabIndex = 21;
            this.EmpAgeLabel.Text = "Employee Age";
            // 
            // EmpNameLabel
            // 
            this.EmpNameLabel.AutoSize = true;
            this.EmpNameLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EmpNameLabel.ForeColor = System.Drawing.Color.White;
            this.EmpNameLabel.Location = new System.Drawing.Point(15, 119);
            this.EmpNameLabel.Name = "EmpNameLabel";
            this.EmpNameLabel.Size = new System.Drawing.Size(124, 18);
            this.EmpNameLabel.TabIndex = 20;
            this.EmpNameLabel.Text = "Employee Name";
            // 
            // EmpIDLabel
            // 
            this.EmpIDLabel.AutoSize = true;
            this.EmpIDLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EmpIDLabel.ForeColor = System.Drawing.Color.White;
            this.EmpIDLabel.Location = new System.Drawing.Point(16, 64);
            this.EmpIDLabel.Name = "EmpIDLabel";
            this.EmpIDLabel.Size = new System.Drawing.Size(97, 18);
            this.EmpIDLabel.TabIndex = 19;
            this.EmpIDLabel.Text = "Employee ID";
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Red;
            this.Delete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.Location = new System.Drawing.Point(1073, 544);
            this.Delete.Margin = new System.Windows.Forms.Padding(2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(197, 32);
            this.Delete.TabIndex = 17;
            this.Delete.Text = "DELETE";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Red;
            this.Back.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.White;
            this.Back.Location = new System.Drawing.Point(18, 541);
            this.Back.Margin = new System.Windows.Forms.Padding(2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(90, 32);
            this.Back.TabIndex = 18;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.Lime;
            this.Update.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.ForeColor = System.Drawing.Color.White;
            this.Update.Location = new System.Drawing.Point(126, 469);
            this.Update.Margin = new System.Windows.Forms.Padding(2);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(90, 32);
            this.Update.TabIndex = 16;
            this.Update.Text = "UPDATE";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.Lime;
            this.Add.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.White;
            this.Add.Location = new System.Drawing.Point(18, 469);
            this.Add.Margin = new System.Windows.Forms.Padding(2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(90, 32);
            this.Add.TabIndex = 15;
            this.Add.Text = "ADD";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // EmpGen
            // 
            this.EmpGen.FormattingEnabled = true;
            this.EmpGen.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Transgender",
            "Other"});
            this.EmpGen.Location = new System.Drawing.Point(17, 422);
            this.EmpGen.Margin = new System.Windows.Forms.Padding(2);
            this.EmpGen.Name = "EmpGen";
            this.EmpGen.Size = new System.Drawing.Size(198, 21);
            this.EmpGen.TabIndex = 14;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.EmployeeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeeGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.EmployeeGridView.GridColor = System.Drawing.Color.DarkGray;
            this.EmployeeGridView.Location = new System.Drawing.Point(272, 11);
            this.EmployeeGridView.Margin = new System.Windows.Forms.Padding(2);
            this.EmployeeGridView.Name = "EmployeeGridView";
            this.EmployeeGridView.ReadOnly = true;
            this.EmployeeGridView.RowHeadersWidth = 40;
            this.EmployeeGridView.RowTemplate.Height = 24;
            this.EmployeeGridView.Size = new System.Drawing.Size(998, 526);
            this.EmployeeGridView.TabIndex = 13;
            this.EmployeeGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeGridView_CellContentClick);
            // 
            // EmpAge
            // 
            this.EmpAge.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EmpAge.ForeColor = System.Drawing.Color.DarkGreen;
            this.EmpAge.Location = new System.Drawing.Point(17, 197);
            this.EmpAge.Margin = new System.Windows.Forms.Padding(2);
            this.EmpAge.Name = "EmpAge";
            this.EmpAge.Size = new System.Drawing.Size(198, 29);
            this.EmpAge.TabIndex = 11;
            // 
            // EmpSal
            // 
            this.EmpSal.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EmpSal.ForeColor = System.Drawing.Color.DarkGreen;
            this.EmpSal.Location = new System.Drawing.Point(17, 252);
            this.EmpSal.Margin = new System.Windows.Forms.Padding(2);
            this.EmpSal.Name = "EmpSal";
            this.EmpSal.Size = new System.Drawing.Size(198, 29);
            this.EmpSal.TabIndex = 10;
            // 
            // EmpName
            // 
            this.EmpName.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EmpName.ForeColor = System.Drawing.Color.DarkGreen;
            this.EmpName.Location = new System.Drawing.Point(17, 139);
            this.EmpName.Margin = new System.Windows.Forms.Padding(2);
            this.EmpName.Name = "EmpName";
            this.EmpName.Size = new System.Drawing.Size(198, 29);
            this.EmpName.TabIndex = 9;
            // 
            // EmpID
            // 
            this.EmpID.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EmpID.ForeColor = System.Drawing.Color.DarkGreen;
            this.EmpID.Location = new System.Drawing.Point(17, 84);
            this.EmpID.Margin = new System.Windows.Forms.Padding(2);
            this.EmpID.Name = "EmpID";
            this.EmpID.Size = new System.Drawing.Size(198, 29);
            this.EmpID.TabIndex = 12;
            // 
            // EployeesLabel
            // 
            this.EployeesLabel.AutoSize = true;
            this.EployeesLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EployeesLabel.ForeColor = System.Drawing.Color.White;
            this.EployeesLabel.Location = new System.Drawing.Point(10, 8);
            this.EployeesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EployeesLabel.Name = "EployeesLabel";
            this.EployeesLabel.Size = new System.Drawing.Size(186, 37);
            this.EployeesLabel.TabIndex = 8;
            this.EployeesLabel.Text = "Employees";
            // 
            // EmpPhone
            // 
            this.EmpPhone.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EmpPhone.ForeColor = System.Drawing.Color.DarkGreen;
            this.EmpPhone.Location = new System.Drawing.Point(18, 309);
            this.EmpPhone.Margin = new System.Windows.Forms.Padding(2);
            this.EmpPhone.Name = "EmpPhone";
            this.EmpPhone.Size = new System.Drawing.Size(198, 29);
            this.EmpPhone.TabIndex = 10;
            // 
            // EmpPhoneLabel
            // 
            this.EmpPhoneLabel.AutoSize = true;
            this.EmpPhoneLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EmpPhoneLabel.ForeColor = System.Drawing.Color.White;
            this.EmpPhoneLabel.Location = new System.Drawing.Point(16, 289);
            this.EmpPhoneLabel.Name = "EmpPhoneLabel";
            this.EmpPhoneLabel.Size = new System.Drawing.Size(127, 18);
            this.EmpPhoneLabel.TabIndex = 22;
            this.EmpPhoneLabel.Text = "Employee Phone";
            // 
            // PasswordHash
            // 
            this.PasswordHash.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PasswordHash.ForeColor = System.Drawing.Color.DarkGreen;
            this.PasswordHash.Location = new System.Drawing.Point(17, 366);
            this.PasswordHash.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordHash.Name = "PasswordHash";
            this.PasswordHash.Size = new System.Drawing.Size(198, 29);
            this.PasswordHash.TabIndex = 10;
            // 
            // EmpPWLabel
            // 
            this.EmpPWLabel.AutoSize = true;
            this.EmpPWLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EmpPWLabel.ForeColor = System.Drawing.Color.White;
            this.EmpPWLabel.Location = new System.Drawing.Point(15, 346);
            this.EmpPWLabel.Name = "EmpPWLabel";
            this.EmpPWLabel.Size = new System.Drawing.Size(152, 18);
            this.EmpPWLabel.TabIndex = 22;
            this.EmpPWLabel.Text = "Employee Password";
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1280, 585);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.EmpGendLabel);
            this.Controls.Add(this.EmpPWLabel);
            this.Controls.Add(this.EmpPhoneLabel);
            this.Controls.Add(this.EmpSalLabel);
            this.Controls.Add(this.EmpAgeLabel);
            this.Controls.Add(this.EmpNameLabel);
            this.Controls.Add(this.EmpIDLabel);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.EmpGen);
            this.Controls.Add(this.EmployeeGridView);
            this.Controls.Add(this.EmpAge);
            this.Controls.Add(this.PasswordHash);
            this.Controls.Add(this.EmpPhone);
            this.Controls.Add(this.EmpSal);
            this.Controls.Add(this.EmpName);
            this.Controls.Add(this.EmpID);
            this.Controls.Add(this.EployeesLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label EmpGendLabel;
        private System.Windows.Forms.Label EmpSalLabel;
        private System.Windows.Forms.Label EmpAgeLabel;
        private System.Windows.Forms.Label EmpNameLabel;
        private System.Windows.Forms.Label EmpIDLabel;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.ComboBox EmpGen;
        private System.Windows.Forms.DataGridView EmployeeGridView;
        private System.Windows.Forms.TextBox EmpAge;
        private System.Windows.Forms.TextBox EmpSal;
        private System.Windows.Forms.TextBox EmpName;
        private System.Windows.Forms.TextBox EmpID;
        private System.Windows.Forms.Label EployeesLabel;
        private System.Windows.Forms.TextBox EmpPhone;
        private System.Windows.Forms.Label EmpPhoneLabel;
        private System.Windows.Forms.TextBox PasswordHash;
        private System.Windows.Forms.Label EmpPWLabel;
    }
}