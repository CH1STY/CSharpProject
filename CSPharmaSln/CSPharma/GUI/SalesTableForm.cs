using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSPharma.EntityLayer;
using CSPharma.DataLayer;
using CSPharma.GUI;

namespace CSPharma.GUI
{
    public partial class SalesTableForm : Form
    {
        private Pharmacist pharmacist { set; get; }
        public SalesTableForm(Pharmacist pharmacist)
        {
            InitializeComponent();
            this.pharmacist = pharmacist;
            this.PopulateGridView();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var newForm = new PharmacistForm(this.pharmacist);
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }


        private void PopulateGridView()
        {

            string query = "Select * from SalesRecord;";

            var dt = DataAccess.GetDataTable(query);

            this.dgvMain.DataSource = dt;

        }
    }
}
