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
    public partial class MedicineManufacturersForm : Form
    {
        private int passedID;
        private SqlConnection conn;
        public MedicineManufacturersForm(int userID, SqlConnection conn)
        {
            InitializeComponent();
            this.passedID = userID;
            this.conn = conn;
        }

        private void MedicineManufacturersForm_Load(object sender, EventArgs e)
        {

        }
    }
}
