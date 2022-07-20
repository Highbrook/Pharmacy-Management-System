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
        private int passedID;
        private SqlConnection conn;
        public MedicineForm(int userID, SqlConnection conn)
        {
            InitializeComponent();
            this.passedID = userID;
            this.conn = conn;
        }

        private void MedicineForm_Load(object sender, EventArgs e)
        {
            MedicineGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            populate();
        }
        public void populate()
        {
            try
            {
                this.conn.Open();
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
                this.conn.Close();
            }
        }


        private void MedicineName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MedicineGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MedName.Text = MedicineGridView.SelectedRows[0].Cells[0].Value.ToString();
            BuyPrice.Text = MedicineGridView.SelectedRows[0].Cells[1].Value.ToString();
            SellPrice.Text = MedicineGridView.SelectedRows[0].Cells[2].Value.ToString();
            MedQty.Text = MedicineGridView.SelectedRows[0].Cells[3].Value.ToString();
            Company.Text = MedicineGridView.SelectedRows[0].Cells[4].Value.ToString();
            ExpDate.Text = MedicineGridView.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            
            if (MedicineFieldCheck() == true)
            {
                string myQuery = "insert into Medicine_tbl values('" + MedName.Text + "', " + BuyPrice.Text + ", " + SellPrice.Text + ", " + MedQty.Text + ", '" + ExpDate.Text + "', '" + Company.SelectedItem.ToString() + "')";
                try
                {
                    QueryExecution(myQuery);
                    MessageBox.Show(MedName.Text + " Added.", "Success");
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
                string myQuery = "UPDATE Medicine_tbl SET BuyPrice = " + BuyPrice.Text + ", SellPrice = " + SellPrice.Text + ", MedQty = " + MedQty.Text + ", ExpDate = '" + ExpDate.Text + "', Company = '" + Company.SelectedItem.ToString() + "' WHERE MedName='" + MedName.Text + "'";
                try
                {
                    QueryExecution(myQuery);
                    MessageBox.Show(MedName.Text + " Updated.", "Success");
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
            if (MedicineFieldCheck() == true)
            {
                string myQuery = "delete from Medicine_tbl WHERE MedName='" + MedName.Text + "'";
                DialogResult dialogResult = MessageBox.Show("Are you sure you wish to delete " + MedName.Text + " ?", "Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        QueryExecution(myQuery);
                        MessageBox.Show(MedName.Text + " deleted.", "Success");
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
        }
        private void Search_Click(object sender, EventArgs e)
        {
            List<string> list = MedicineSearchCheck();
            //string colName = list[0];
            //string colValue = list[1];

            //foreach (DataGridViewRow row in MedicineGridView.Rows)
            //{
            //    MessageBox.Show(row.Cells[0].ToString());
            //    if (row.ToString().Contains(list[1]))
            //    {
            //        MedicineGridView.ClearSelection();
            //        int indexOfRow = row.ToString().IndexOf(list[1]);
            //        MedicineGridView.Rows[indexOfRow].Selected = true;
            //        MessageBox.Show(colName + " Searched with: " + colValue);
            //    }
            //}


            //foreach (DataGridViewTextBoxColumn column in MedicineGridView.Columns)
            //{
            //    if (list.Contains(column.Name))
            //    {
            //        DataGridViewRowCollection rows = MedicineGridView.Rows;
            //        string colName = column.Name.ToString();
            //        string colValue = list[1];

            //            MedicineGridView.ClearSelection();
            //            int indexOfRow = rows.IndexOf(colName);
            //            MedicineGridView.Rows[indexOfCol].Selected = true;
            //            MessageBox.Show(colName + " Searched with: " + colValue);

            //        //MedicineGridView.Rows[1].Selected = true;
            //        //MedicineGridView.SelectAll();
            //    }
            //}
        }

        private void QueryExecution(string query)
        {
            try
            {
                this.conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                this.conn.Close();
                populate();
            }
            catch
            {
                this.conn.Close();
            }
        }
        private bool MedicineFieldCheck()
        {
            if (MedName.Text == "" || BuyPrice.Text == "" || SellPrice.Text == "" || MedQty.Text == "" || ExpDate.Text == "" || Company.SelectedItem == null)
            {
                MessageBox.Show("Missing Data, please fill in all the information.");
                return false;
            }
            else
            {
                return true;
            }
        }

        private List<string> MedicineSearchCheck()
        {
            List<string> list = new List<string>();
            if (MedName.Text != "")
            {
                list.Add(MedName.Name);
                list.Add(MedName.Text);
            }
            else if (BuyPrice.Text != "")
            {
                list.Add(BuyPrice.Name);
                list.Add(BuyPrice.Text);
            }
            else if (SellPrice.Text != "")
            {
                list.Add(SellPrice.Name);
                list.Add(SellPrice.Text);
            }
            else if (MedQty.Text != "")
            {
                list.Add(MedQty.Name);
                list.Add(MedQty.Text);
            }
            else if (ExpDate.Text != "")
            {
                list.Add(ExpDate.Name);
                list.Add(ExpDate.Text);
            }
            else if (Company.SelectedItem != null)
            {
                list.Add(Company.SelectedItem.ToString());
                list.Add(Company.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Missing Data, please fill in any information.");
            }
            return list;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm(passedID, conn);
            mainForm.Show();
        }
    }
}
