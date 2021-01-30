using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSPharma.GUI;
using CSPharma.DataLayer;
using CSPharma.EntityLayer;


namespace CSPharma.GUI
{
    public partial class SaleDetails : Form
    {
        private Pharmacist pharmacist;
        private SalesRecord saleRecord;

        public SaleDetails(Pharmacist pharmacist,SalesRecord saleRecord)
        {
            InitializeComponent();
            this.pharmacist = pharmacist;
            this.saleRecord = saleRecord;
            this.lblTotalCost.Text += saleRecord.totalCost.ToString();
            this.lblDate.Text += saleRecord.date.ToString("dd-MM-yyyy HH:mm");
            this.PopulateGridView();

            this.lblSeller.Text += this.GetSellerName() + " ID: " + this.saleRecord.pharmacistId;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var newForm = new PharmacistForm(this.pharmacist);
            this.Hide();
            newForm.ShowDialog();
            newForm.Close();
        }

        private string GetSellerName() { 
        
            string sql = "Select name From Pharmacist where pharmacistId='"+this.saleRecord.pharmacistId+"';";

            var dt = DataAccess.GetDataTable(sql);
            return dt.Rows[0]["name"].ToString();
        
        }

        private void PopulateGridView() {

           
            string sql = "Select *from MedicineList where SalesId ='" + this.saleRecord.salesID + "';";
            var dt = DataAccess.GetDataTable(sql);
            for (int index = 0; index < dt.Rows.Count; index++) {

                string medicineID, medicineName, quantity, price;
                medicineID = dt.Rows[index]["medicineID"].ToString();
                quantity = dt.Rows[index]["quantity"].ToString();

                sql = "Select name,price from Medicine where medicineId ='"+medicineID+"';";
                var dt2 = DataAccess.GetDataTable(sql);

                medicineName = dt2.Rows[0]["name"].ToString();
                price = dt2.Rows[0]["price"].ToString();

                this.dgvMain.Rows.Add(medicineID,medicineName,quantity,price);
            
            }
        
        }
    }
}
