using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public Form1(int passedUserID)
        {
            InitializeComponent();
            userID = passedUserID;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            startPoint++;
            progressBar1.Value = startPoint;
            label4.Text = startPoint + " %";
            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 100;
                timer1.Stop();
                label2.Text = "Complete";

                MainForm mainForm = new MainForm(userID);
                this.Hide();
                mainForm.Show();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
