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
    public partial class PerscriptionsForm : Form
    {
        private int passedID;
        private SqlConnection conn;
        public PerscriptionsForm(int userID, SqlConnection conn)
        {
            InitializeComponent();
            this.passedID = userID;
            this.conn = new SqlConnection(conn.ConnectionString);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm(passedID, this.conn);
            mainForm.Show();
        }
    }
}
