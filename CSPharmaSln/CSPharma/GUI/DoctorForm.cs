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

namespace CSPharma.GUI
{
    public partial class DoctorForm : Form
    {
        private Admin admin;
        public DoctorForm(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
            this.txtPhone.MaxLength = 11;
            this.txtName.MaxLength = 32;
            this.dtpHireDate.Value = DateTime.Now;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        
        private void PopulateGridView(string sql = "select * from Doctor ;")
        {
           
            var dt = DataAccess.GetDataTable(sql);

            this.dgvMain.AutoGenerateColumns = false;
            
            this.dgvMain.DataSource = dt;
            
        }
       
       

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            

            if (this.txtAutoSearch.Text.IndexOf("'")==-1)
            {

                var query = "select * from Doctor where Name like '%" + this.txtAutoSearch.Text + "%';";
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
            this.txtPhone.Text = null;
            this.txtToolStrip.Text = null;
            
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            {
                string name = this.txtName.Text.ToString();
                string phone = this.txtPhone.Text.ToString();
                string adminId = this.admin.id;
                bool nameFlag, phoneFlag;
                nameFlag = this.CheckName(name);
                phoneFlag = this.CheckPhoneNumber(phone);
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

                bool operationSuccess;

                if(nameFlag && phoneFlag)
                {
                    this.Cleartxt();
                    var newUser = new Doctor();
                    newUser.id = Doctor.AutoGenerateId();
                    newUser.name = name;
                    newUser.phone = phone;
                    newUser.adminId = this.admin.id;
                    newUser.hireDate = DateTime.Parse(dtpHireDate.Value.ToString("yyyy-MM-dd"));
                    operationSuccess = newUser.CreateDoctor();
                    if (operationSuccess)
                    {
                        
                        MessageBox.Show("ID Succesfully Created", "DONE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("CRITICAL DATABASE ERROR!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

                
                this.PopulateGridView();
                this.txtAutoSearch_TextChanged(null, null);
            }
            
        }

        private bool CheckName(string name)
        {

            var nameCheck = new Regex("^[ a-zA-Z.]*$");
            long n;
            bool isNumeric = Int64.TryParse(name, out n);


            if (name[0] == '.' || name.Length < 3 || char.IsWhiteSpace(name[0]) || name.Equals("NAME") || isNumeric || String.IsNullOrWhiteSpace(name) || !nameCheck.IsMatch(name))
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

            string sql = "SELECT phone From admin where phone ='" + phone + "' UNION Select phone from Receptionist where phone='" + phone + "' UNION select phone from Pharmacist where phone = '" + phone + "'";
            var dt = DataAccess.GetDataTable(sql);
            bool isAlreadyExist;
            try
            {
                string phoneNumber = dt.Rows[0]["phone"].ToString();
                isAlreadyExist = true;
            }
            catch (Exception)
            {
                isAlreadyExist = false;
            }
            if (isAlreadyExist)
            {
                this.lblPhoneErr.Text = "!Number Already Exist";
                return false;
            }


            return true;


        }

        

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm a1 = new AdminForm(this.admin);
            a1.ShowDialog();
            this.Close();
        }

        private void editPhoneNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string phone = txtToolStrip.Text;
            bool phoneFlag=this.CheckPhoneNumber(phone);

            if (!phoneFlag)
            {
                MessageBox.Show("Invalid Phone Number", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string sql = @"update Doctor set phone = '" + this.txtToolStrip.Text + "' where DoctorId = '" + this.dgvMain.CurrentRow.Cells["DoctorId"].Value.ToString() + "'";

                int count = DataAccess.ExecuteUpdateQuery(sql);
                if (count == 1)
                    MessageBox.Show("'" + this.dgvMain.CurrentRow.Cells["DoctorId"].Value.ToString() + "' updated successfully.");
                else
                    MessageBox.Show("Data update failed.");

                this.Cleartxt();
            }
            this.PopulateGridView();
        }

        private void resignationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string id = this.dgvMain.CurrentRow.Cells["DoctorId"].Value.ToString();
            if (id.Substring(0, 4).Equals("D100"))
            {
                MessageBox.Show("Cannot change base value", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {


                string sql = "Select resigndate from Doctor where DoctorId = '" + this.dgvMain.CurrentRow.Cells["DoctorId"].Value.ToString() + "' and resignDate IS NOT NULL ;";
                var dt = DataAccess.GetDataTable(sql);
                int count = dt.Rows.Count;
                if (count == 1)
                {
                    sql = @"update Doctor set resigndate = NULL where DoctorId = '" + this.dgvMain.CurrentRow.Cells["DoctorId"].Value.ToString() + "';";
                    count = DataAccess.ExecuteUpdateQuery(sql);
                    if (count == 1)
                        MessageBox.Show("'" + this.dgvMain.CurrentRow.Cells["DoctorId"].Value.ToString() + "' updated successfully.");
                    else
                        MessageBox.Show("Data update failed.");
                }
                else
                {
                    sql = @"update Doctor set resigndate = '" + this.dtpResignDate.Value.ToString("yyyy-MM-dd") + "' where DoctorId = '" + this.dgvMain.CurrentRow.Cells["DoctorId"].Value.ToString() + "';";

                    count = DataAccess.ExecuteUpdateQuery(sql);
                    if (count == 1)
                        MessageBox.Show("'" + this.dgvMain.CurrentRow.Cells["DoctorId"].Value.ToString() + "' updated successfully.");
                    else
                        MessageBox.Show("Data update failed.");
                }
                this.Cleartxt();
                this.PopulateGridView();
            }
        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            this.PopulateGridView();
            
        }

        private void editNameToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string name = this.txtToolStrip.Text;
            bool nameFlag = this.CheckName(name);


            if (!nameFlag)
            {
                MessageBox.Show("Invalid Name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string sql = @"update Doctor set name = '" + this.txtToolStrip.Text + "' where DoctorId = '" + this.dgvMain.CurrentRow.Cells["DoctorId"].Value.ToString() + "'";

                int count = DataAccess.ExecuteUpdateQuery(sql);
                if (count == 1)
                    MessageBox.Show("'" + this.dgvMain.CurrentRow.Cells["DoctorId"].Value.ToString() + "' updated successfully.");
                else
                    MessageBox.Show("Data update failed.");

                this.Cleartxt();
            }
            this.PopulateGridView();
        }

        
    }
}
