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
    public partial class Form1 : Form
    {
        int startPoint = 0;
        int userID;
        SqlConnection conn;
        public Form1(int passedUserID, SqlConnection conn)
        {
            InitializeComponent();
            this.userID = passedUserID;
            this.conn = conn;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            startPoint += 5;
            progressBar1.Value = startPoint;
            label4.Text = startPoint + " %";
            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 100;
                timer1.Stop();
                label2.Text = "Complete";

                this.Hide();
                MainForm mainForm = new MainForm(this.userID, this.conn);
                mainForm.Show();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
