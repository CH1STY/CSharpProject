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
using CSPharma.DataLayer;
using CSPharma.EntityLayer;
using CSPharma.RepoLayer;

namespace CSPharma.GUI
{
    public partial class InventoryForm : Form
    {
        private Admin admin;
        private InventoryRepo IRepo { get; set; }

        public InventoryForm(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
            IRepo = new InventoryRepo();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private DataAccess Da { get; set; }
        

        private void PopulateGridView1()
        {
            this.dgvMain.AutoGenerateColumns = false;
            this.dgvMain.DataSource = IRepo.GetAll().ToList();
        }

        private void PopulateGridView(string sql = "select * from Medicine;")
        {

            var dt = DataAccess.GetDataTable(sql);

            this.dgvMain.AutoGenerateColumns = false;

            this.dgvMain.DataSource = dt;

        }
        private void Cleartxt()
        {
            
            this.txtName.Text = null;
            this.txtStock.Text = null;
            this.txtPrice.Text = null;
        }



        private bool CheckName(string name)
        {
            long n;
            bool isNumeric = Int64.TryParse(name, out n);


            if (name.Length < 3 || char.IsWhiteSpace(name[0]) || name.Equals("NAME") || isNumeric || String.IsNullOrWhiteSpace(name) || name.IndexOf("'") != -1)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private bool CheckStock(int stock)
        {
            int input;
            
            string text = this.txtStock.Text;
            try
            {
                input = int.Parse(this.txtStock.Text);
            }
            catch (Exception)
            {
                this.lblStockErr.Text = "!Invalid Stock Value";
                return false;
            }
            if (stock+input >= 999)
            {
                this.lblStockErr.Text = "!Reached Max Limit";
                return false;

            }

            
           
            return true;
           

        }
        private bool CheckStock()
        {

            int input;

            string text = this.txtStock.Text;
            try
            {
                input = int.Parse(this.txtStock.Text);
            }
            catch (Exception)
            {
                this.lblStockErr.Text = "!Invalid Stock Value";
                return false;
            }
            return true;
        }
    

        private void btnAdd_Click(object sender, EventArgs e)
        {

            {

                string name = this.txtName.Text.ToString();
                int price = 0;
                    
                string adminId = this.admin.id;
                bool operationSuccess;
                bool nameFlag = this.CheckName(name);
                uint quantity = 0;
                bool stockFlag;
                bool priceFlag = true;
                try
                {
                    price= Int32.Parse(this.txtPrice.Text);
                    if (price < 0) { price = 0; }
                    lblPriceErr.Visible = false;
                }
                catch (Exception)
                {
                    priceFlag = false;
                    lblPriceErr.Visible = true;
                }
                try
                {
                     quantity = uint.Parse(this.txtStock.Text);
                     
                }
                catch(Exception)
                {
                    lblStockErr.Text = "!Invalid Stock Value";
                    lblStockErr.Visible = true;
                    
                    stockFlag = false;
                }

                stockFlag = this.CheckStock();

                if (!nameFlag)
                {
                    this.lblNameError.Visible = true;
                }
                else
                {
                    this.lblNameError.Visible = false;
                }
                if (!stockFlag)
                {
                    this.lblStockErr.Visible = true;
                }
                else
                {
                    this.lblStockErr.Visible = false;
                }
                if (nameFlag && stockFlag && priceFlag)
                {
                    var newItem = new Product();
                    newItem.medicineId = Product.AutoGenerateId();
                    newItem.name = name;
                    newItem.price = price;
                    newItem.quantity = int.Parse(quantity.ToString());
                    newItem.adminId = this.admin.id;

                    operationSuccess = newItem.CreateMedicine();
                    if (operationSuccess)
                    {
                        MessageBox.Show("ID Succesfully Created", "DONE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("CRITICAL DATABASE ERROR!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    this.Cleartxt();
                }
                this.PopulateGridView1();
                this.txtAutoSearch_TextChanged_1(null, null);
            }
        }


        private void btnRestock_Click(object sender, EventArgs e)
        {
            if (this.txtId.Text.Equals(null) || this.txtId.Text.Equals(""))
            {
                MessageBox.Show("INVALID REQUEST", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                int a, sum = 0, b = 0;
                bool stockFlag = true;
                bool priceFlag = true;
                int p = 0;
                try
                {
                    p = Int32.Parse(txtPrice.Text);
                    if (p < 0) { p = 0; }
                    lblPriceErr.Visible = false;
                }
                catch (Exception)
                {
                    priceFlag = false;
                    lblPriceErr.Visible = true;
                }
                try
                {
                    b = int.Parse(this.dgvMain.CurrentRow.Cells["quantity"].Value.ToString());
                    a = int.Parse(this.txtStock.Text);
                    sum = a + b;
                }
                catch (Exception)
                {
                    stockFlag = false;
                    lblStockErr.Text = "!invalid Stock Value";
                }

                if (stockFlag)
                {
                    stockFlag = this.CheckStock(b);
                }
                bool nameFlag = this.CheckName(this.txtName.Text);

                if (!nameFlag)
                {
                    this.lblNameError.Visible = true;
                }
                else
                {
                    this.lblNameError.Visible = false;
                }
                if (!stockFlag)
                {
                    this.lblStockErr.Visible = true;
                }
                else
                {
                    this.lblStockErr.Visible = false;
                }
                if (stockFlag && nameFlag && priceFlag)
                {
                    if (sum < 0)
                    {
                        sum = 0;
                    }
                    string query = "update Medicine set quantity = " + sum.ToString() + ",price='" + p.ToString() + "' where MedicineId = '" + this.txtId.Text + "';";
                    int count = DataAccess.ExecuteUpdateQuery(query);

                    if (count == 1)
                        MessageBox.Show(this.txtId.Text + " has been updated successfully.");
                    else
                        MessageBox.Show("ReStock failed.");

                    this.Cleartxt();
                }
                this.PopulateGridView1();
                this.txtAutoSearch_TextChanged_1(null, null);
            }
        }
        private void txtAutoSearch_TextChanged_1(object sender, EventArgs e)
        {
            

            if (this.txtAutoSearch.Text.IndexOf("'") ==-1)
            {

                var query = "select * from Medicine where Name like '%" + this.txtAutoSearch.Text + "%';";
                this.PopulateGridView(query);

            }
            else
            {

                MessageBox.Show("Invalid Search Input", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtAutoSearch.Text = null;

            }
        }

        private void dgvMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtId.Text = this.dgvMain.CurrentRow.Cells["MedicineId"].Value.ToString();
            this.txtName.Text = this.dgvMain.CurrentRow.Cells["name"].Value.ToString();
            
            this.txtPrice.Text = this.dgvMain.CurrentRow.Cells["price"].Value.ToString();
        }

        

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm a1 = new AdminForm(this.admin);
            a1.ShowDialog();
            this.Close();
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            this.PopulateGridView1();
        }

        

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Cleartxt();
            this.lblPriceErr.Visible = false;
            this.lblNameError.Visible = false;
            this.lblStockErr.Visible = false;
            this.txtAutoSearch.Text = null;
        }
    }
}
