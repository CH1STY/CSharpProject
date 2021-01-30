using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSPharma.DataLayer;
using CSPharma.EntityLayer;

namespace CSPharma.GUI
{
    public partial class AppointmentListForm : Form
    {
        private Receptionist receptionist { set; get; }
        public AppointmentListForm(Receptionist receptionist)
        {
            InitializeComponent();
            this.receptionist = receptionist;
            this.PopulateGridView();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new ReceptionistForm(this.receptionist);
            newForm.ShowDialog();
            this.Close();
        }

        private void PopulateGridView() {

            string query = "Select * from Appointment;";

            var dt = DataAccess.GetDataTable(query);

            this.dgvMain.DataSource = dt;
        
        }


    }
}
