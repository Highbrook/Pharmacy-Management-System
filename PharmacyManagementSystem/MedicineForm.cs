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
    public partial class MedicineForm : Form
    {
        // laptop
        //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DL4QMRJ\SQLEXPRESS;Initial Catalog=Pharmacy_db;Integrated Security=True");
        
        // pc
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Highbrook\Documents\Pharmacy_db.mdf;Integrated Security=True;Connect Timeout=30");
        public MedicineForm()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Medicine_tbl values('"+MedicineName.Text+"', "+BuyPrice.Text+", "+SellPrice.Text+", "+Quantity.Text+", '"+ExpireDate.Text+"', '"+CompanySelect.SelectedItem.ToString()+"') ", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Medicine Added");
            conn.Close();
        }

        private void MedicineName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
