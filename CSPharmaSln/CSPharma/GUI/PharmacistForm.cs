using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using CSPharma.GUI;
using CSPharma.EntityLayer;
using CSPharma.DataLayer;


namespace CSPharma.GUI
{
    public partial class PharmacistForm : Form
    {
        private Pharmacist pharmacist { set; get; }
        public PharmacistForm(Pharmacist pharmacist)
        {
            InitializeComponent();
            this.pharmacist = pharmacist;
            this.lblPharmacistName.Text = pharmacist.name;
            this.lblPharmacistId.Text = pharmacist.id;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private void btnEditPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new ChangeUserPasswordForm(this.pharmacist);
            newForm.ShowDialog();
            this.Close();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm newForm = new LoginForm();
            newForm.ShowDialog();
            this.Close();
        }
        private void txtSalesID_Enter(object sender, EventArgs e)
        {
           
            if (this.txtSalesID.Text.Equals("SALE ID"))
            {

                this.txtSalesID.Text = "";
                this.txtSalesID.ForeColor = Color.White;
            }
        }

        private void txtSalesID_Leave(object sender, EventArgs e)
        {
            if (this.txtSalesID.Text.Equals(""))
            {

                this.txtSalesID.ForeColor = Color.Silver;
                this.txtSalesID.Text = "SALE ID";

            }
        }

        private void lblSellMedicine_MouseHover(object sender, EventArgs e)
        {
            this.lblSellMedicine.ForeColor = Color.PaleGreen;

        }

        private void lblSellMedicine_MouseLeave(object sender, EventArgs e)
        {
            this.lblSellMedicine.ForeColor = Color.White;
        }

        private void lblSellMedicine_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new CartForm(this.pharmacist);
            newForm.ShowDialog();
            this.Close();
        }

        private void lblViewSalesList_MouseHover(object sender, EventArgs e)
        {
            this.lblViewSalesList.ForeColor = Color.PaleGreen;
        }

        private void lblViewSalesList_MouseLeave(object sender, EventArgs e)
        {
            this.lblViewSalesList.ForeColor = Color.White;

        }

        private void lblViewSalesList_Click(object sender, EventArgs e)
        {
            var newForm = new SalesTableForm(this.pharmacist);
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }

        private void lblViewSaleDetails_MouseHover(object sender, EventArgs e)
        {
            this.lblViewSaleDetails.ForeColor = Color.PaleGreen;
        }

        private void lblViewSaleDetails_MouseLeave(object sender, EventArgs e)
        {
            this.lblViewSaleDetails.ForeColor = Color.White;

        }

        private void lblViewSaleDetails_Click(object sender, EventArgs e)
        {
            var checkIdString = new Regex("^[a-zA-Z0-9]*$");

            string SaleId = this.txtSalesID.Text;
            bool isSaleIdValid;
            isSaleIdValid = checkIdString.IsMatch(SaleId);
            if (isSaleIdValid)
            {
                isSaleIdValid = this.ValidateSaleId(SaleId);
            }
           
            
            
            if (isSaleIdValid)
            {


                this.lblSaleIdErr.Visible = false;


                string query = "Select *from SalesRecord where SalesId ='"+SaleId+"' ;";
                var dt = DataAccess.GetDataTable(query);
                var newSale = new SalesRecord();
                newSale.salesID = SaleId;
                newSale.date = DateTime.Parse(dt.Rows[0]["date"].ToString());
                newSale.totalCost = float.Parse(dt.Rows[0]["TotalCost"].ToString());
                newSale.pharmacistId = dt.Rows[0]["PharmacistId"].ToString();

                var newForm = new SaleDetails(this.pharmacist, newSale);
                this.Hide();
                newForm.ShowDialog();
                this.Close();



            }
            else
            {
                this.lblSaleIdErr.Visible = true;
            
            }


            

        }

        private bool ValidateSaleId(string SaleId)
        {
            string query = "Select SalesId from SalesRecord where SalesId = '" + SaleId + "' ;";
            var dt = DataAccess.GetDataTable(query);
            if (dt.Rows.Count > 0)
                return true;
            else
            {
                return false;
            }
        }

    }
}
