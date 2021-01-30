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
using CSPharma.EntityLayer;
using CSPharma.DataLayer;
using CSPharma.GUI;

namespace CSPharma.GUI
{
    public partial class UserRegistration : Form
    {
        private Admin admin;

        public UserRegistration(Admin admin)
        {
            InitializeComponent();
            this.ActiveControl = this.lblRegistration;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            txtUserPassword.MaxLength = 20;
            txtUserPhone.MaxLength = 11;
            this.admin = admin;
            this.dtpHiredate.Value = DateTime.Now;
            this.KeyPreview = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (this.txtUserName.Text.Equals("NAME"))
            {

                this.txtUserName.Text = "";
                this.txtUserName.ForeColor = Color.White;
            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (this.txtUserName.Text.Equals(""))
            {

                this.txtUserName.Text = "NAME";
                this.txtUserName.ForeColor = Color.Silver;
            }
        }

        private void txtUserPhone_Enter(object sender, EventArgs e)
        {
            if (this.txtUserPhone.Text.Equals("PHONE"))
            {

                this.txtUserPhone.Text = "";
                this.txtUserPhone.ForeColor = Color.White;
            }
        }

        private void txtUserPhone_Leave(object sender, EventArgs e)
        {

            if (this.txtUserPhone.Text.Equals(""))
            {

                this.txtUserPhone.Text = "PHONE";
                this.txtUserPhone.ForeColor = Color.Silver;
            }
        }

        private void txtUserPassword_Enter(object sender, EventArgs e)
        {
            if (this.txtUserPassword.Text.Equals("PASSWORD"))
            {
                this.txtUserPassword.Text = "";
                this.txtUserPassword.UseSystemPasswordChar = true;
                this.txtUserPassword.ForeColor = Color.White;
            }
        }

        private void txtUserPassword_Leave(object sender, EventArgs e)
        {
            if (this.txtUserPassword.Text.Equals(""))
            {

                this.txtUserPassword.Text = "PASSWORD";
                this.txtUserPassword.UseSystemPasswordChar = false;
                this.txtUserPassword.ForeColor = Color.Silver;
            }
        }

        private void txtConfirmPass_Enter(object sender, EventArgs e)
        {
            if (this.txtConfirmPass.Text.Equals("CONFIRM PASSWORD"))
            {
                this.txtConfirmPass.Text = "";
                this.txtConfirmPass.UseSystemPasswordChar = true;
                this.txtConfirmPass.ForeColor = Color.White;
            }
        }

        private void txtConfirmPass_Leave(object sender, EventArgs e)
        {
            if (this.txtConfirmPass.Text.Equals(""))
            {

                this.txtConfirmPass.Text = "CONFIRM PASSWORD";
                this.txtConfirmPass.UseSystemPasswordChar = false;
                this.txtConfirmPass.ForeColor = Color.Silver;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            string name = this.txtUserName.Text.ToString();
            string phone = this.txtUserPhone.Text.ToString();
            string password = this.txtUserPassword.Text.ToString();
            string confirmPass = this.txtConfirmPass.Text.ToString();


            bool nameFlag, phoneFlag, passFlag, confirmPassFlag,radioButtonFlag,operationSuccess;
            
            //ERROR CHECK PART
            nameFlag = this.CheckName(name);
            if (!nameFlag)
            {
                this.lblNameError.Visible = true;
            }
            else
            {
                this.lblNameError.Visible = false;
            
            }

            //----
            phoneFlag = this.CheckPhoneNumber(phone);
            if (!phoneFlag)
            {
                this.lblPhoneErr.Visible = true;
            }
            else 
            {
                this.lblPhoneErr.Visible = false;
            
            }
            //-----
            passFlag = this.CheckPassword(password);
            if (!passFlag)
            {
                this.lblPasswordErr.Visible = true;
            }
            else
            {
                this.lblPasswordErr.Visible = false;
            }

            if (confirmPass.Equals(password))
            {

                this.lblConPassErr.Visible = false;
                confirmPassFlag = false;
            }
            else
                this.lblConPassErr.Visible = true;
                confirmPassFlag = true;

          
            if (!radioBtnAdmin.Checked && !radioBtnPharmacist.Checked && !radioBtnReceptionist.Checked)
            {

                this.lblUserTypeErr.Visible = true;
                radioButtonFlag = false;
            }
            else
            {
                lblUserTypeErr.Visible = false;
                radioButtonFlag = true;
            }

            //----- END OF ERROR CHECK

            if(nameFlag && phoneFlag && passFlag && confirmPassFlag && radioButtonFlag){

                if (radioBtnAdmin.Checked) {
                    var newUser = new Admin();
                    newUser.id = Admin.AutoGenerateId();
                    newUser.name = name;
                    newUser.phone = phone;
                    newUser.password = password; 
                    newUser.hireDate = DateTime.Parse(dtpHiredate.Value.ToString("yyyy-MM-dd"));
                    operationSuccess = newUser.CreateAdmin();
                    if (operationSuccess)
                    {
                        MessageBox.Show("ID Succesfully Created \nUserID:\t" + newUser.id + "\nPassword:\t" + newUser.password + "\nSave This Information For Future Usage", "DONE", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        this.ClearTxt();
                    }
                    else
                    {
                        MessageBox.Show("CRITICAL DATABASE ERROR!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //Should Go Back to Admin HomePage
                    

                }
                else if(radioBtnPharmacist.Checked){
                    var newUser = new Pharmacist();
                    newUser.id = Pharmacist.AutoGenerateId();
                    newUser.name = name;
                    newUser.phone = phone;
                    newUser.password = password;
                    newUser.hireDate = DateTime.Parse(dtpHiredate.Value.ToString("yyyy-MM-dd").Substring(0, 10));
                    newUser.adminId = this.admin.id;
                    operationSuccess = newUser.CreatePharmacist();
                    if (operationSuccess)
                    {
                        MessageBox.Show("ID Succesfully Created \nUserID:\t" + newUser.id + "\nPassword:\t" + newUser.password + "\nSave This Information For Future Usage", "DONE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.ClearTxt();
                    }
                    else
                    {
                        MessageBox.Show("CRITICAL DATABASE ERROR!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //Should Go Back to Admin HomePage
                    
                }
                else if (radioBtnReceptionist.Checked)
                {
                    var newUser = new Receptionist();
                    newUser.id = Receptionist.AutoGenerateId();
                    newUser.name = name;
                    newUser.phone = phone;
                    newUser.password = password;
                    newUser.hireDate = DateTime.Parse(dtpHiredate.Value.ToShortDateString().Substring(0,9));
                    newUser.adminId = this.admin.id;
                    operationSuccess = newUser.CreateReceptionist();
                    if (operationSuccess)
                    {
                        MessageBox.Show("ID Succesfully Created \nUserID:\t" + newUser.id + "\nPassword:\t" + newUser.password + "\nSave This Information For Future Usage", "DONE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.ClearTxt();
                    }
                    else
                    {
                        MessageBox.Show("CRITICAL DATABASE ERROR!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                   
                  


                }
            }
      
        
        
        }
        private void ClearTxt() {

            this.txtUserName.Text = "NAME";
            this.txtUserPhone.Text = "PHONE";
            this.txtUserPassword.UseSystemPasswordChar = false;
            this.txtConfirmPass.UseSystemPasswordChar = false;
            this.txtUserPassword.Text = "PASSWORD";
            this.txtConfirmPass.Text = "CONFIRM PASSWORD";
            this.dtpHiredate.Value = DateTime.Now;
            this.txtUserName.ForeColor = Color.Silver;
            this.txtUserPhone.ForeColor = Color.Silver;
            this.txtUserPassword.ForeColor = Color.Silver;
            this.txtConfirmPass.ForeColor = Color.Silver;

        }
        private bool CheckName(string name) {

            var nameCheck = new Regex("^[ a-zA-Z.]*$");
            long n;
            bool isNumeric = Int64.TryParse(name, out n);


            if (name[0]=='.' || name.Length < 3 || char.IsWhiteSpace(name[0]) || name.Equals("NAME") || isNumeric || String.IsNullOrWhiteSpace(name)|| !nameCheck.IsMatch(name))
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

            string sql = "SELECT phone From admin where phone ='"+phone+"' UNION Select phone from Receptionist where phone='"+phone+"' UNION select phone from Pharmacist where phone = '"+phone+"'";
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
        private bool CheckPassword(string password)
        {
            bool isWhite = String.IsNullOrWhiteSpace(password);
            if (password.Length < 4 || isWhite || password.Equals("PASSWORD")|| password.IndexOf("'")!=-1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new AdminForm(this.admin);
            newForm.ShowDialog();
            this.Close();
        }

        private void UserRegistration_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                this.btnRegister_Click(new object(), new EventArgs());
            }
          
        }
      
    }
}
