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
    public partial class CartForm : Form
    {
        private Pharmacist pharmacist { set; get; }
        private int totalCost { set; get; }
        private string salesId { set; get; }
        public CartForm(Pharmacist pharmacist)
        {
            InitializeComponent();
            this.pharmacist = pharmacist;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            
          

        }
  
        private void PopulateGridView(string sql = "select * from medicine;")
        {
            var dt = DataAccess.GetDataTable(sql);

            this.dgvMain.AutoGenerateColumns = false;
            this.dgvCart.AutoGenerateColumns = false;
            this.dgvMain.DataSource = dt;
            
        }
        private void CartForm_Load(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {

            if (this.txtAutoSearch.Text.IndexOf("'")==-1)
            {

                var query = "select * from medicine where Name like '%" + this.txtAutoSearch.Text + "%';";
                this.PopulateGridView(query);

            }
            else
            {

                MessageBox.Show("Invalid Search Input", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtAutoSearch.Text = null;
                
            }
           
        }

        
        private void PopulateCartView(string sql = "select * from Medicine;")
        {
            var dt = DataAccess.GetDataTable(sql);
           
            
            this.dgvCart.AutoGenerateColumns = false;
            
            this.dgvCart.DataSource = dt;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool quantityFlag = true, isSelectedFlag = true ;
            int quantity = 0;
            try {
                
                quantity = int.Parse( this.txtQuantity.Text);
                if (quantity <= 0)
                {
                    throw new Exception();
                }
            
            }catch(Exception){
                quantityFlag = false;
            }
            


            if (!quantityFlag)
            {

                MessageBox.Show("Invalid Quantity", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (this.dgvMain.SelectedRows.Count <= 0)
                {
                    isSelectedFlag = false;
                    MessageBox.Show("No Row Selected Please Select a Row From Medicine Table", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else {

                    isSelectedFlag = true;
                        
                }

                if (isSelectedFlag) {
                    if (int.Parse(dgvMain.CurrentRow.Cells["Stock"].Value.ToString()) <= 0)
                    {
                        MessageBox.Show("Product Out of Stock", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        quantityFlag = false;
                    }
                    else if ((int.Parse(dgvMain.CurrentRow.Cells["Stock"].Value.ToString()) - quantity) < 0)
                    {
                        MessageBox.Show("Invalid Quantity", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        quantityFlag = false;
                    }
                
                }


                if (quantityFlag && isSelectedFlag) {
                    string searchValue = this.dgvMain.CurrentRow.Cells["medicineId"].Value.ToString();

                    int rowIndex = -1;
                    foreach (DataGridViewRow row in this.dgvCart.Rows)
                    {
                        if (row.Cells[0].Value.ToString().Equals(searchValue))
                        {
                            rowIndex = row.Index;
                            break;
                        }
                    }



                    if (rowIndex == -1)
                    {
                        this.dgvMain.CurrentRow.Cells["Stock"].Value = (int.Parse(this.dgvMain.CurrentRow.Cells["Stock"].Value.ToString()) - int.Parse(this.txtQuantity.Text)).ToString();
                        this.dgvCart.Rows.Add(dgvMain.CurrentRow.Cells["MedicineID"].Value.ToString(), dgvMain.CurrentRow.Cells["name"].Value.ToString(), this.txtQuantity.Text, dgvMain.CurrentRow.Cells["price"].Value.ToString());

                        this.txtQuantity.Text = "";

                    }
                    else {
                        this.dgvMain.CurrentRow.Cells["Stock"].Value = (int.Parse(this.dgvMain.CurrentRow.Cells["Stock"].Value.ToString()) - int.Parse(this.txtQuantity.Text)).ToString();

                        this.dgvCart.Rows[rowIndex].Cells["quantity"].Value = int.Parse(this.dgvCart.Rows[rowIndex].Cells["quantity"].Value.ToString()) + int.Parse(this.txtQuantity.Text);

                        this.txtQuantity.Text = "";
                    }
                }

            
            }

            this.UpdateTotalCost();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new PharmacistForm(this.pharmacist);
            newForm.ShowDialog();
            this.Close();
        }

        

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvCart.SelectedRows.Count <= 0)
            {

                MessageBox.Show("No Row Selected Please Select a Row From CART Table", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                int quantity = int.Parse(dgvCart.CurrentRow.Cells["quantity"].Value.ToString());
                string searchValue = this.dgvCart.CurrentRow.Cells["medicineIDCart"].Value.ToString();
                foreach (DataGridViewRow row in this.dgvCart.SelectedRows)
                {
                    this.dgvCart.Rows.RemoveAt(row.Index);
                }


                int rowIndex = -1;
                foreach (DataGridViewRow row in this.dgvMain.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(searchValue))
                    {
                        rowIndex = row.Index;
                        break;
                    }
                }
                this.dgvMain.Rows[rowIndex].Cells["Stock"].Value = int.Parse(this.dgvMain.Rows[rowIndex].Cells["Stock"].Value.ToString())+quantity;
            
            }
            this.UpdateTotalCost();
        }
        
        private void UpdateTotalCost(){
            this.totalCost =0;
            try { 
                
                foreach (DataGridViewRow row in this.dgvCart.Rows)
                {
                    this.totalCost+=(int.Parse(this.dgvCart.Rows[row.Index].Cells["priceCart"].Value.ToString()) * int.Parse(this.dgvCart.Rows[row.Index].Cells["quantity"].Value.ToString()));
                }


            }
            catch(Exception){
                totalCost = 0;
            }

            this.lblTotalCost.Text = "Total Cost :" + this.totalCost.ToString();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (this.dgvCart.RowCount <= 0)
            {
                MessageBox.Show("NO SALES PERFORMED", "NO EVENT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.btnCancel_Click(null, null);
            }
            else
            {
                this.UpdateDBMedicineTable();
                this.CreateSalesRecord();

                this.UpdateSoldMedicineList();

                MessageBox.Show("SALE SUCCESSFUL", "DONE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.btnCancel_Click(null, null);
            }


           
        }

        private void UpdateDBMedicineTable() {

            foreach (DataGridViewRow row in this.dgvMain.Rows)
            {
                var product = new Product();
                product.medicineId = this.dgvMain.Rows[row.Index].Cells["medicineID"].Value.ToString();
                product.quantity = int.Parse(this.dgvMain.Rows[row.Index].Cells["Stock"].Value.ToString());
                try
                {
                    product.UpdateProduct();
                }
                catch (Exception) {
                    MessageBox.Show("CRITICAL DATABASE ERRO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                }
            }
        
        }
        private void CreateSalesRecord()
        {

            var newSalesRecord = new SalesRecord();
            newSalesRecord.pharmacistId = this.pharmacist.id;
            newSalesRecord.salesID = SalesRecord.AutoGenerateID();
            newSalesRecord.date = DateTime.Now;
            newSalesRecord.totalCost = this.totalCost;

            newSalesRecord.CreateSalesRecord();
            this.salesId = newSalesRecord.salesID;

        }
        private void UpdateSoldMedicineList() {

            
           
            foreach (DataGridViewRow row in this.dgvCart.Rows)
            {
                var newSale = new MedicineList();
                newSale.medicineId = this.dgvCart.Rows[row.Index].Cells["medicineIDCart"].Value.ToString();
                newSale.quantity = int.Parse(this.dgvCart.Rows[row.Index].Cells["quantity"].Value.ToString());
                newSale.salesID = this.salesId;

                newSale.CreateNewSale();
               
            }
        
        }

 
    
    }

}
