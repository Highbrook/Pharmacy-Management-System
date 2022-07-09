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
        
        public void populate()
        {
            try
            {
                conn.Open();
                string myQyery = "select * from Medicine_tbl";
                SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter(myQyery, conn);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(mySqlDataAdapter);
                var dataSet = new DataSet();
                mySqlDataAdapter.Fill(dataSet);
                MedicineGridView.ReadOnly = true;
                MedicineGridView.DataSource = dataSet.Tables[0];
                conn.Close();
            }
            catch
            {
                MessageBox.Show("An Error occurred while loading Medicine item");
                conn.Close();
            }
        }
        public MedicineForm()
        {
            InitializeComponent();
        }

        private void MedicineName_TextChanged(object sender, EventArgs e)
        {

        }


        private void MedicineForm_Load(object sender, EventArgs e)
        {
            MedicineGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            populate();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MedicineGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MedicineName.Text = MedicineGridView.SelectedRows[0].Cells[0].Value.ToString();
            BuyPrice.Text = MedicineGridView.SelectedRows[0].Cells[1].Value.ToString();
            SellPrice.Text = MedicineGridView.SelectedRows[0].Cells[2].Value.ToString();
            Quantity.Text = MedicineGridView.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            
            if (MedicineFieldCheck() == true)
            {
                string myQuery = "insert into Medicine_tbl values('" + MedicineName.Text + "', " + BuyPrice.Text + ", " + SellPrice.Text + ", " + Quantity.Text + ", '" + ExpireDate.Text + "', '" + CompanySelect.SelectedItem.ToString() + "')";
                try
                {
                    QueryExecution(myQuery);
                    MessageBox.Show(MedicineName.Text + " Added.", "Success");
                }
                catch
                {
                    MessageBox.Show("An Error occurred while adding Medicine item.");
                    conn.Close();
                }
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (MedicineFieldCheck() == true)
            {
                string myQuery = "UPDATE Medicine_tbl SET BuyPrice = " + BuyPrice.Text + ", SellPrice = " + SellPrice.Text + ", MedQty = " + Quantity.Text + ", ExpDate = '" + ExpireDate.Text + "', Company = '" + CompanySelect.SelectedItem.ToString() + "' WHERE MedName='" + MedicineName.Text + "'";
                try
                {
                    QueryExecution(myQuery);
                    MessageBox.Show(MedicineName.Text + " Updated.", "Success");
                }
                catch
                {
                    MessageBox.Show("An Error occurred while updating Medicine item.");
                    conn.Close();
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string myQuery = "delete from Medicine_tbl WHERE MedName='" + MedicineName.Text + "'";
            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to delete " + MedicineName.Text + " ?", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    QueryExecution(myQuery);
                    MessageBox.Show(MedicineName.Text + " deleted.", "Success");
                }
                catch
                {
                    MessageBox.Show("An Error occurred while deleting Medicine item.");
                    conn.Close();
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                conn.Close();
            }
        }

        private void QueryExecution(string query)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                populate();
            }
            catch
            {
                conn.Close();
            }
        }
        private bool MedicineFieldCheck()
        {
            if (MedicineName.Text == "" || BuyPrice.Text == "" || SellPrice.Text == "" || Quantity.Text == "" || ExpireDate.Text == "" || CompanySelect.SelectedItem == null)
            {
                MessageBox.Show("Missing Data, please fill in all the information.");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
