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
    public partial class OrdersForm : Form
    {
        private int passedID;
        private SqlConnection conn;
        public OrdersForm(int userID, SqlConnection conn)
        {
            InitializeComponent();
            this.passedID = userID;
            this.conn = conn;
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm(passedID, this.conn);
            mainForm.Show();
        }
    }
}
