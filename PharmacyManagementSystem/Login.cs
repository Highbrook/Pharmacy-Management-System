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
    public partial class Login : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Highbrook\Documents\Pharmacy_db.mdf;Integrated Security=True;Connect Timeout=30");

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string spName = @"dbo.spLogin";
            QueryExecution(spName);
        }

        private void QueryExecution(string query)
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Username", Username.Text);
            cmd.Parameters.AddWithValue("@Password", Password.Text);
            cmd.Parameters.AddWithValue("@Success", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                int success = int.Parse(cmd.Parameters["@Success"].Value.ToString());
                if (success == 0)
                {
                    this.errorText.Show();
                }
                else if (success > 0)
                {
                    this.errorText.Hide();
                    Form1 loadingPage = new Form1(success, conn);
                    this.Hide();
                    loadingPage.Show();
                }
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

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
