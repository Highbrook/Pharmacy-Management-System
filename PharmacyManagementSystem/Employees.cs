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
                string spName = @"dbo.spPopulateEmployee";
                SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter(spName, conn);
                var dataSet = new DataSet();
                mySqlDataAdapter.Fill(dataSet);
                EmployeeGridView.ReadOnly = true;
                EmployeeGridView.DataSource = dataSet.Tables[0];
                conn.Close();
            }
            catch
            {
                MessageBox.Show("An Error occurred while loading Employee list");
                conn.Close();
            }
        }


        public void searchPopulate(string query)
        {
            SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter(query, conn);
            var dataSet = new DataSet();
            mySqlDataAdapter.Fill(dataSet);
            EmployeeGridView.ReadOnly = true;
            EmployeeGridView.DataSource = dataSet.Tables[0];
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
            string spName = @"dbo.spSearchEmployee";
            QueryExecutionSearch(spName);
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            EmpID.Text = "";
            EmpName.Text = "";
            EmpSal.Text = "";
            EmpAge.Text = "";
            EmpPhone.Text = "";
            EmpGen.Text = "";
            PasswordHash.Text = "";
            populate();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string spName = @"dbo.spDeleteEmployee";
            QueryExecutionDelete(spName);
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
            if (errorMsg == 1)
            {
                MessageBox.Show("An Error occurred while adding Employee data.");
            }
            else
            {
                MessageBox.Show(EmpName.Text + " Added.", "Success");
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
            cmd.Parameters.AddWithValue("@ERR", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            int errorMsg = (int)cmd.Parameters["@ERR"].Value;
            if (errorMsg == 1)
            {
                MessageBox.Show("Cannot change Employee ID");
            }
            else
            {
                MessageBox.Show(EmpName.Text + " Updated.", "Success");
            }
            conn.Close();
            populate();
        }
        private void QueryExecutionDelete(string query)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to delete " + EmpName.Text + " ?", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmployeeID", EmpID.Text);
                cmd.Parameters.AddWithValue("@EmployeeName", EmpName.Text);
                cmd.Parameters.AddWithValue("@ERR", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                cmd.ExecuteNonQuery();
                int errorMsg = int.Parse(cmd.Parameters["@ERR"].Value.ToString());
                if (errorMsg == 1)
                {
                    MessageBox.Show("No employee with Name " + EmpName.Text + " or ID " + EmpID.Text + " found.");
                }
                else
                {
                    MessageBox.Show(EmpName.Text + " Deleted.", "Success");
                }
                conn.Close();
                populate();
            }
        }

        private void QueryExecutionSearch(string query)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmployeeID", EmpID.Text);
            cmd.Parameters.AddWithValue("@EmployeeName", EmpName.Text);
            cmd.Parameters.AddWithValue("@EmployeeSalary", EmpSal.Text);
            cmd.Parameters.AddWithValue("@EmployeeAge", EmpAge.Text);
            cmd.Parameters.AddWithValue("@EmployeePhone", EmpPhone.Text);
            if (EmpGen.SelectedItem == null)
            {
                cmd.Parameters.AddWithValue("@EmployeeGender", "");
            }
            else
            {
                cmd.Parameters.AddWithValue("@EmployeeGender", EmpGen.SelectedItem.ToString());
            }
            cmd.Parameters.AddWithValue("@ERR", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            int errorMsg = (int)cmd.Parameters["@ERR"].Value;
            if (errorMsg == 1)
            {
                MessageBox.Show("Cannot find any Employee with given data");
            }

            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            DataTable dt = new DataTable();
            dt.Load(dr);
            EmployeeGridView.ReadOnly = true;
            EmployeeGridView.DataSource = dt;
            conn.Close();
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
            PasswordHash.Text = "";
        }

    }
}
