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
using CSPharma.GUI;


namespace CSPharma.GUI
{
    public partial class GeneralUpdateForm : Form
    {
        private Admin admin;
        public GeneralUpdateForm(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
            this.dtpHireDate.Value = DateTime.Now;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void PopulateGridView(string sql = "Select AdminId as id, name, phone, password, hiredate, resigndate from Admin UNION select ReceptionistId as id, name, phone, password, hiredate, resigndate from Receptionist UNION select PharmacistId as id, name, phone, password, hiredate, resigndate from Pharmacist;")


        {

            var dt = DataAccess.GetDataTable(sql);

            this.dgvMain.AutoGenerateColumns = false;

            this.dgvMain.DataSource = dt;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private bool CheckName(string name)
        {
            long n;
            bool isNumeric = Int64.TryParse(name, out n);


            if (name.Length < 3 || char.IsWhiteSpace(name[0]) || name.Equals("NAME") || isNumeric || String.IsNullOrWhiteSpace(name))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private bool CheckPhoneNumber(string phone)
        {
            long n;
            bool isNumeric = Int64.TryParse(phone, out n);

            if (phone.Length != 11 || !isNumeric || Char.IsWhiteSpace(phone[0]))
            {
                this.lblPhoneErr.Text = "!Enter A Valid Phone Number (11 Digit)";
                return false;

            }

            if (phone[0] != '0' || phone[1] != '1')
            {
                this.lblPhoneErr.Text = "!Enter a Bangladeshi Number";
                return false;

            }

            ////string sql = "SELECT phone From admin where phone ='" + phone + "' UNION Select phone from Receptionist where phone='" + phone + "' UNION select phone from Pharmacist where phone = '" + phone + "'";
            ////var dt = DataAccess.GetDataTable(sql);
            ////bool isAlreadyExist;
            ////try
            ////{
            ////    string phoneNumber = dt.Rows[0]["phone"].ToString();
            ////    isAlreadyExist = true;
            ////}
            ////catch (Exception)
            ////{
            ////    isAlreadyExist = false;
            ////}
            ////if (isAlreadyExist)
            ////{
            ////    this.lblPhoneErr.Text = "!Number Already Exist";
            ////    return false;
            ////}


            return true;


        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {



            if (this.txtAutoSearch.Text.IndexOf("'") == -1)
            {

                var query = "Select AdminId as id, name, phone, password, hiredate, resigndate from Admin where Name like '%" + this.txtAutoSearch.Text + "%' UNION select ReceptionistId as id, name, phone, password, hiredate, resigndate from Receptionist where Name like '%" + this.txtAutoSearch.Text + "%' UNION select PharmacistId as id, name, phone, password, hiredate, resigndate from Pharmacist where Name like '%" + this.txtAutoSearch.Text + "%';";
                this.PopulateGridView(query);

            }
            else
            {

                MessageBox.Show("Invalid Search Input", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtAutoSearch.Text = null;

            }


        }

        private void Cleartxt()
        {
            this.txtName.Text = null;
            this.txtID.Text = null;
            this.txtPhone.Text = null;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm a1 = new AdminForm(this.admin);
            a1.ShowDialog();
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name=this.txtName.Text;
            string phone = this.txtPhone.Text;
            bool nameFlag=this.CheckName(name), phoneFlag=this.CheckPhoneNumber(phone);
            if (!nameFlag)
            {
                this.lblNameError.Visible = true;
            }
            else
            {
                this.lblNameError.Visible = false;
            }
            if (!phoneFlag)
            {
                this.lblPhoneErr.Visible = true;
            }
            else
            {
                this.lblPhoneErr.Visible = false;
            }

            if (nameFlag && phoneFlag)
            {
                if (txtID.Text.Substring(0, 1).Equals("A"))
                {
                    string sql = @"update Admin set name = '" + this.txtName.Text + "',phone ='" + this.txtPhone.Text + "',hiredate = '" + dtpHireDate.Value.ToString("yyyy-MM-dd") + "' where AdminId = '" + this.txtID.Text + "'";

                    int count = DataAccess.ExecuteUpdateQuery(sql);
                    if (count == 1)
                        MessageBox.Show("'" + this.txtID.Text + "' updated successfully.");
                    else
                        MessageBox.Show("Data update failed.");
                }
                else if (txtID.Text.Substring(0, 1).Equals("R"))
                {
                    string sql = @"update Receptionist set name = '" + this.txtName.Text + "',phone ='" + this.txtPhone.Text + "',hiredate = '" + dtpHireDate.Value.ToString("yyyy-MM-dd") + "' where ReceptionistId = '" + this.txtID.Text + "'";

                    int count = DataAccess.ExecuteUpdateQuery(sql);
                    if (count == 1)
                        MessageBox.Show("'" + this.txtID.Text + "' updated successfully.");
                    else
                        MessageBox.Show("Data update failed.");
                }
                else if (txtID.Text.Substring(0, 1).Equals("P"))
                {
                    string sql = @"update Pharmacist set name = '" + this.txtName.Text + "',phone ='" + this.txtPhone.Text + "',hiredate = '" + dtpHireDate.Value.ToString("yyyy-MM-dd") + "' where PharmacistId = '" + this.txtID.Text + "'";

                    int count = DataAccess.ExecuteUpdateQuery(sql);
                    if (count == 1)
                        MessageBox.Show("'" + this.txtID.Text + "' updated successfully.");
                    else
                        MessageBox.Show("Data update failed.");
                }

                this.Cleartxt();
            }
           
            this.PopulateGridView();
            this.txtAutoSearch_TextChanged(null, null);
        }

        private void dgvMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtID.Text = this.dgvMain.CurrentRow.Cells["UserId"].Value.ToString();
            this.txtName.Text = this.dgvMain.CurrentRow.Cells["name"].Value.ToString();
            
            this.txtPhone.Text = this.dgvMain.CurrentRow.Cells["phone"].Value.ToString().Substring(0,11);
            this.dtpHireDate.Value = DateTime.Parse(this.dgvMain.CurrentRow.Cells["hiredate"].Value.ToString());
        }

        

        private void btnResign_Click(object sender, EventArgs e)
        {
            if (this.dgvMain.SelectedRows.Count <= 0 || this.txtID.Text.Equals(null)|| this.txtID.Text.Equals(""))
            {
                MessageBox.Show("No Rows Selected", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                string sql = "Select AdminId as id, name, phone, password, hiredate, resigndate from Admin UNION select ReceptionistId as id, name, phone, password, hiredate, resigndate from Receptionist UNION select PharmacistId as id, name, phone, password, hiredate, resigndate from Pharmacist;";

                //string sql = "Select resigndate from Receptionist where ReceptionistId = '" + this.txtID.Text + "' and resignDate IS NOT NULL ;";
                var dt = DataAccess.GetDataTable(sql);
                int count = dt.Rows.Count;

                if (txtID.Text.Substring(0, 1).Equals("R"))
                {
                    if (txtID.Text.Substring(0, 4).Equals("R100"))
                    {
                        MessageBox.Show("Cannot change base value'" + this.txtID.Text + "'", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    }
                    else
                    {
                        sql = "Select resigndate from Receptionist where ReceptionistId = '" + this.txtID.Text + "' and resignDate IS NOT NULL ;";
                        dt = DataAccess.GetDataTable(sql);
                        count = dt.Rows.Count;

                        if (count == 1)
                        {
                            sql = @"update Receptionist set resigndate = NULL where ReceptionistId = '" + this.txtID.Text + "';";
                            count = DataAccess.ExecuteUpdateQuery(sql);
                            if (count == 1)
                                MessageBox.Show("'" + this.txtID.Text + "' updated successfully.");
                            else
                                MessageBox.Show("Data update failed.");
                        }
                        else
                        {
                            sql = @"update Receptionist set resigndate = '" + this.dtpResignDate.Value.ToString("yyyy-MM-dd") + "' where ReceptionistId = '" + this.txtID.Text + "';";

                            count = DataAccess.ExecuteUpdateQuery(sql);
                            if (count == 1)
                                MessageBox.Show("'" + this.txtID.Text + "' updated successfully.");
                            else
                                MessageBox.Show("Data update failed.");
                        }
                    }
                }
                else if (txtID.Text.Substring(0, 1).Equals("P"))
                {
                    if (txtID.Text.Substring(0, 4).Equals("P100"))
                    {
                        MessageBox.Show("Cannot change base value'" + this.txtID.Text + "'", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        sql = "Select resigndate from Pharmacist where PharmacistId = '" + this.txtID.Text + "' and resignDate IS NOT NULL ;";
                        dt = DataAccess.GetDataTable(sql);
                        count = dt.Rows.Count;
                        if (count == 1)
                        {
                            sql = @"update Pharmacist set resigndate = NULL where PharmacistId = '" + this.txtID.Text + "';";

                            count = DataAccess.ExecuteUpdateQuery(sql);
                            if (count == 1)
                            {
                                MessageBox.Show("'" + this.txtID.Text + "' updated successfully.");
                                this.Cleartxt();
                            }
                            else
                                MessageBox.Show("Data update failed.");
                        }
                        else
                        {
                            sql = @"update Pharmacist set resigndate = '" + this.dtpResignDate.Value.ToString("yyyy-MM-dd") + "' where PharmacistId = '" + this.txtID.Text + "';";

                            count = DataAccess.ExecuteUpdateQuery(sql);
                            if (count == 1)
                            {
                                MessageBox.Show("'" + this.txtID.Text + "' updated successfully.");
                                this.Cleartxt();
                            }
                            else
                                MessageBox.Show("Data update failed.");
                        }
                    }
                }
                else if (txtID.Text.Substring(0, 1).Equals("A"))
                {
                    if (txtID.Text.Substring(0, 4).Equals("A100"))
                    {
                        MessageBox.Show("Cannot change base value'" + this.txtID.Text + "'", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        sql = "Select resigndate from Admin where AdminId = '" + this.txtID.Text + "' and resignDate IS NOT NULL ;";
                        dt = DataAccess.GetDataTable(sql);
                        count = dt.Rows.Count;
                        if (count == 1)
                        {
                            sql = @"update Admin set resigndate = NULL where AdminId = '" + this.txtID.Text + "';";

                            count = DataAccess.ExecuteUpdateQuery(sql);
                            if (count == 1)
                            {
                                MessageBox.Show("'" + this.txtID.Text + "' updated successfully.");
                                this.Cleartxt();
                            }
                            else
                                MessageBox.Show("Data update failed.");
                        }
                        else
                        {
                            sql = @"update Admin set resigndate = '" + this.dtpResignDate.Value.ToString("yyyy-MM-dd") + "' where AdminId = '" + this.txtID.Text + "';";

                            count = DataAccess.ExecuteUpdateQuery(sql);
                            if (count == 1)
                            {
                                MessageBox.Show("'" + this.txtID.Text + "' updated successfully.");
                                this.Cleartxt();
                            }
                            else
                                MessageBox.Show("Data update failed.");
                        }
                    }
                }

                
                this.PopulateGridView();
                this.txtAutoSearch_TextChanged(null,null);
            }
        }

        private void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtID.Text = this.dgvMain.CurrentRow.Cells["UserId"].Value.ToString();
            this.txtName.Text = this.dgvMain.CurrentRow.Cells["name"].Value.ToString();

            this.txtPhone.Text = this.dgvMain.CurrentRow.Cells["phone"].Value.ToString().Substring(0,11);
            this.dtpHireDate.Value = DateTime.Parse(this.dgvMain.CurrentRow.Cells["hiredate"].Value.ToString());
        }

        private void dgvMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtID.Text = this.dgvMain.CurrentRow.Cells["UserId"].Value.ToString();
            this.txtName.Text = this.dgvMain.CurrentRow.Cells["name"].Value.ToString();

            this.txtPhone.Text = this.dgvMain.CurrentRow.Cells["phone"].Value.ToString().Substring(0,11);
            this.dtpHireDate.Value = DateTime.Parse(this.dgvMain.CurrentRow.Cells["hiredate"].Value.ToString());
        }

        private void dgvMain_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtID.Text = this.dgvMain.CurrentRow.Cells["UserId"].Value.ToString();
            this.txtName.Text = this.dgvMain.CurrentRow.Cells["name"].Value.ToString();

            this.txtPhone.Text = this.dgvMain.CurrentRow.Cells["phone"].Value.ToString().Substring(0,11);
            this.dtpHireDate.Value = DateTime.Parse(this.dgvMain.CurrentRow.Cells["hiredate"].Value.ToString());
        }
    }
}
