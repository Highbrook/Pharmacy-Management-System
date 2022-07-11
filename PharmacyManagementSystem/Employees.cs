using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PharmacyManagementSystem
{
    public partial class Employees : Form
    {
        // laptop
        //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DL4QMRJ\SQLEXPRESS;Initial Catalog=Pharmacy_db;Integrated Security=True");

        // pc
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Highbrook\Documents\Pharmacy_db.mdf;Integrated Security=True;Connect Timeout=30");
        public void populate()
        {
            try
            {
                conn.Open();
                string myQyery = "SELECT EmpID AS 'Employee ID', EmpName AS 'Employee Name', EmpSal AS 'Emplyee Salary', EmpAge AS 'Employee Age', EmpPhone AS 'Employee Phone', EmpGen AS 'Employee Gender' FROM Employee_tbl";
                SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter(myQyery, conn);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(mySqlDataAdapter);
                var dataSet = new DataSet();
                mySqlDataAdapter.Fill(dataSet);
                EmployeeGridView.ReadOnly = true;
                EmployeeGridView.DataSource = dataSet.Tables[0];
                conn.Close();
            }
            catch
            {
                MessageBox.Show("An Error occurred while loading Medicine item");
                conn.Close();
            }
        }
        public Employees()
        {
            InitializeComponent();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            EmployeeGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            populate();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (EmployeeFieldCheck() == true)
            {
                //string myQuery = "INSERT INTO Employee_tbl VALUES('" + EmpID.Text + "', '" + EmpName.Text + "', '" + EmpSal.Text + "', '" + EmpAge.Text + "', '" + EmpPhone.Text + "', '" + EmpGen.SelectedItem.ToString() + "', HASHBYTES('SHA2_256'," + PasswordHash.Text +"));";
                //string myQuery = "INSERT INTO Employee_tbl VALUES('" + EmpID.Text + "', '" + EmpName.Text + "', '" + EmpSal.Text + "', '" + EmpAge.Text + "', '" + EmpPhone.Text + "', '" + EmpGen.SelectedItem.ToString() + "', '" + PasswordHash.Text +"');";
                string spName = @"dbo.spAddEmployee";
                QueryExecutionAdd(spName);
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            string spName = @"dbo.spUpdateEmployee";
            QueryExecutionUpdate(spName);
        }

        private void Search_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {

        }

        private void QueryExecutionAdd(string query)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmployeeID", EmpID.Text);
            cmd.Parameters.AddWithValue("@EmployeeName", EmpName.Text);
            cmd.Parameters.AddWithValue("@EmployeeSalary", EmpSal.Text);
            cmd.Parameters.AddWithValue("@EmployeeAge", EmpAge.Text);
            cmd.Parameters.AddWithValue("@EmployeePhone", EmpPhone.Text);
            cmd.Parameters.AddWithValue("@EmployeeGender", EmpGen.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@EmployeePasswordHash", PasswordHash.Text);
            cmd.Parameters.AddWithValue("@ERR", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            int errorMsg = int.Parse(cmd.Parameters["@ERR"].Value.ToString());
            if (errorMsg == 0)
            {
                MessageBox.Show("An Error occurred while updating Employee data.");
            }
            else
            {
                MessageBox.Show(EmpName.Text + " Updated.", "Success");
            }
            conn.Close();
            populate();
        }

        private void QueryExecutionUpdate(string query)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmployeeID", EmpID.Text);
            cmd.Parameters.AddWithValue("@EmployeeName", EmpName.Text);
            cmd.Parameters.AddWithValue("@EmployeeSalary", EmpSal.Text);
            cmd.Parameters.AddWithValue("@EmployeeAge", EmpAge.Text);
            cmd.Parameters.AddWithValue("@EmployeePhone", EmpPhone.Text);
            cmd.Parameters.AddWithValue("@EmployeeGender", EmpGen.SelectedItem.ToString());
            cmd.ExecuteNonQuery();
            int errorMsg = (int)cmd.Parameters["@ERR"].Value;
            MessageBox.Show(errorMsg.ToString());
            if (errorMsg == 0)
            {
                MessageBox.Show("An Error occurred while updating Employee data.");
            }
            else
            {
                MessageBox.Show(EmpName.Text + " Updated.", "Success");
            }
            conn.Close();
            populate();
        }

        private bool EmployeeFieldCheck()
        {
            if (EmpID.Text == "" || EmpName.Text == "" || EmpAge.Text == "" || EmpSal.Text == "" || EmpPhone.Text == "" || EmpGen.Text == "" || PasswordHash.Text == "")
            {
                MessageBox.Show("Missing Data, please fill in all the information.");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void EmployeeGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpID.Text = EmployeeGridView.SelectedRows[0].Cells[0].Value.ToString();
            EmpName.Text = EmployeeGridView.SelectedRows[0].Cells[1].Value.ToString();
            EmpSal.Text = EmployeeGridView.SelectedRows[0].Cells[2].Value.ToString();
            EmpAge.Text = EmployeeGridView.SelectedRows[0].Cells[3].Value.ToString();
            EmpPhone.Text = EmployeeGridView.SelectedRows[0].Cells[4].Value.ToString();
            EmpGen.Text = EmployeeGridView.SelectedRows[0].Cells[5].Value.ToString();
        }
    }
}
