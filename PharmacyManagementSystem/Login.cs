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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Username.Text == "admin" || this.Password.Text == "admin")
            {
                this.errorText.Hide();
                Form1 loadingPage = new Form1();
                this.Hide();
                loadingPage.Show();
            }
            else
            {
                this.errorText.Show();
            }
        }
    }
}
