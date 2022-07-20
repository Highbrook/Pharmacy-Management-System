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

        private int passedID;
        private SqlConnection conn;
        public Employees(int userID, SqlConnection conn)
        {
            InitializeComponent();
            this.passedID = userID;
            this.conn = new SqlConnection(conn.ConnectionString);
        }
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        public void searchPopulate(string query)
        {
            try
            {
                conn.Open();
                SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter(query, conn);
                var dataSet = new DataSet();
                mySqlDataAdapter.Fill(dataSet);
                EmployeeGridView.ReadOnly = true;
                EmployeeGridView.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
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
            SqlCommand cmd = new SqlCommand(query, this.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmployeeID", EmpID.Text);
            cmd.Parameters.AddWithValue("@EmployeeName", EmpName.Text);
            cmd.Parameters.AddWithValue("@EmployeeSalary", EmpSal.Text);
            cmd.Parameters.AddWithValue("@EmployeeAge", EmpAge.Text);
            cmd.Parameters.AddWithValue("@EmployeePhone", EmpPhone.Text);
            cmd.Parameters.AddWithValue("@EmployeeGender", EmpGen.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@EmployeePasswordHash", PasswordHash.Text);
            cmd.Parameters.AddWithValue("@ERR", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            try
            {
                this.conn.Open();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.conn.Close();
            }
            populate();
        }

        private void QueryExecutionUpdate(string query)
        {
            SqlCommand cmd = new SqlCommand(query, this.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmployeeID", EmpID.Text);
            cmd.Parameters.AddWithValue("@EmployeeName", EmpName.Text);
            cmd.Parameters.AddWithValue("@EmployeeSalary", EmpSal.Text);
            cmd.Parameters.AddWithValue("@EmployeeAge", EmpAge.Text);
            cmd.Parameters.AddWithValue("@EmployeePhone", EmpPhone.Text);
            cmd.Parameters.AddWithValue("@EmployeeGender", EmpGen.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@ERR", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            try
            {
                this.conn.Open();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.conn.Close();
            }
            populate();
        }
        private void QueryExecutionDelete(string query)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to delete " + EmpName.Text + " ?", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand(query, this.conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmployeeID", EmpID.Text);
                cmd.Parameters.AddWithValue("@EmployeeName", EmpName.Text);
                cmd.Parameters.AddWithValue("@ERR", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                try
                {
                    this.conn.Open();
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    this.conn.Close();
                }
                populate();
            }
        }

        // TODO fix this Search bullshit
        private void QueryExecutionSearch(string query)
        {
            //SqlDataAdapter cmd = new SqlDataAdapter();
            //cmd.SelectCommand = new SqlCommand(query, conn);
            //cmd.SelectCommand.CommandType = CommandType.StoredProcedure;

            //SqlCommand cmd = new SqlCommand(query, conn);
            //cmd.CommandType = CommandType.StoredProcedure;

            //DataTable dtResult = new DataTable();
            SqlConnection connection = new SqlConnection(conn.ConnectionString);
            SqlCommand cmd = new SqlCommand(query);

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
            try
            {
                //conn.Open();
                connection.Open();
                //cmd.ExecuteNonQuery();
                int errorMsg = (int)cmd.Parameters["@ERR"].Value;
                if (errorMsg == 1)
                {
                    MessageBox.Show("Cannot find any Employee with given data");
                }

                SqlDataAdapter daAdapter = null;
                daAdapter = new SqlDataAdapter(cmd);
                var dataSet = new DataSet();
                daAdapter.Fill(dataSet);
                EmployeeGridView.ReadOnly = true;
                EmployeeGridView.DataSource = dataSet.Tables[0];

                //SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter(query, conn);
                //var dataSet = new DataSet();
                //mySqlDataAdapter.Fill(dataSet);
                //EmployeeGridView.ReadOnly = true;
                //EmployeeGridView.DataSource = dataSet.Tables[0];


                //SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                //DataTable dt = new DataTable();
                //dt.Load(dr);
                //EmployeeGridView.ReadOnly = true;
                //EmployeeGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //conn.Close();
                connection.Close();
            }
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

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm(passedID, this.conn);
            mainForm.Show();
        }
    }
}
