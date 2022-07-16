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
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Username", Username.Text);
            cmd.Parameters.AddWithValue("@Password", Password.Text);
            cmd.Parameters.AddWithValue("@Success", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.AddWithValue("@ReturnedID", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            // TODO Fix this
            int userID = int.Parse(cmd.Parameters["@ReturnedID"].Value.ToString());
            int success = int.Parse(cmd.Parameters["@Success"].Value.ToString());
            if (success == 1)
            {
                this.errorText.Hide();
                Form1 loadingPage = new Form1(userID);
                this.Hide();
                loadingPage.Show();
            }
            else
            {
                this.errorText.Show();
            }
            conn.Close();
        }
    }
}
