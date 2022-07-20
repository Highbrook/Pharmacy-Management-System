using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class MainForm : Form
    {
        private int passedID;
        private SqlConnection conn;
        public MainForm(int userID, SqlConnection conn)
        {
            InitializeComponent();
            this.passedID = userID;
            this.conn = conn;
            string spName = @"dbo.spFetchEmployeeName";
            QueryExecution(spName, passedID, this.conn);
        }

        private void QueryExecution(string query, int userID, SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserID", userID);
            cmd.Parameters.Add("@UserName", SqlDbType.VarChar, 50);
            cmd.Parameters["@UserName"].Direction = ParameterDirection.Output;
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                string userName = Convert.ToString(cmd.Parameters["@UserName"].Value);
                WelcomeNameLabel.Text = userName.ToString();
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

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
        private void MedicineStockBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MedicineForm medicineForm = new MedicineForm(passedID, conn);
            medicineForm.Show();
        }

        private void MedManufBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MedicineManufacturersForm medicineManufacturers = new MedicineManufacturersForm(passedID, conn);
            medicineManufacturers.Show();
        }

        private void EmployeePageBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employees employees = new Employees(passedID, conn);
            employees.Show();
        }

        private void OrderListBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrdersForm ordersForm = new OrdersForm(passedID, conn);
            ordersForm.Show();
        }
    }
}
