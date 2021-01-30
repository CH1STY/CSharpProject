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
using CSPharma.DataLayer;
using CSPharma.EntityLayer;

namespace CSPharma.GUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
     
            InitializeComponent();
            this.ActiveControl = this.lblLogo;
            this.KeyPreview = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            
        }

       

        private void txtUserId_Enter(object sender, EventArgs e)
        {
            if (this.txtUserId.Text.Equals("USERID")) {

                this.txtUserId.Text = "";
                this.txtUserId.ForeColor = Color.White;
            }
        }

        private void txtUserId_Leave(object sender, EventArgs e)
        {
            if (this.txtUserId.Text.Equals(""))
            {

                this.txtUserId.ForeColor = Color.Silver;
                this.txtUserId.Text = "USERID";
                
            }
        }

        private void txtLoginPass_Enter(object sender, EventArgs e)
        {
            if (this.txtLoginPass.Text.Equals("PASSWORD"))
            {

                this.txtLoginPass.Text = "";
                this.txtLoginPass.UseSystemPasswordChar = true;
                this.txtLoginPass.ForeColor = Color.White;
            }
        }

        private void txtLoginPass_Leave(object sender, EventArgs e)
        {
            if (this.txtLoginPass.Text.Equals(""))
            {

                this.txtLoginPass.Text = "PASSWORD";
                this.txtLoginPass.UseSystemPasswordChar = false;
                this.txtLoginPass.ForeColor = Color.Silver;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            var checkIdString = new Regex("^[ a-zA-Z0-9]*$");
            string id = txtUserId.Text.ToString();
            string password = txtLoginPass.Text.ToString();
            string query;
            bool isResigned = false;
            
            if (!checkIdString.IsMatch(id) || password.IndexOf("'")!=-1) {


                MessageBox.Show(" USER ID CAN NOT CONTAIN SPECIAL CHARACTER\n AND PASSWORD CAN NOT CONTAIN "+ " ' "+"(Single Quotation)", "INPUT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
              
                
                    
            }
            else
            {

                if (id != "" && password != "")
                {
                    if (id[0].Equals('A'))
                    {
                        query = "Select * from admin where adminid = '" + id + "' and password = '" + password + "';";
                        var dt = DataAccess.GetDataTable(query);
                        if (dt.Rows.Count == 0)
                            lblError.Visible = true;
                        else
                        {
                            lblError.Visible = false;
                            var admin = new Admin();
                            admin.id = id;
                            admin.password = password;
                            admin.name = dt.Rows[0]["name"].ToString();
                            admin.phone = dt.Rows[0]["phone"].ToString();
                            admin.hireDate = DateTime.Parse(dt.Rows[0]["hiredate"].ToString());
                            try
                            {
                                admin.resignDate = DateTime.Parse(dt.Rows[0]["resigndate"].ToString());
                                isResigned = true;
                            }
                            catch (Exception)
                            {
                                isResigned = false;
                            }
                            if (isResigned == true)
                            {
                                MessageBox.Show("Resigned Employee Can't Login", "Resigned Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                MessageBox.Show("Login Successfull", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                var newForm = new AdminForm(admin);
                                newForm.ShowDialog();
                                this.Close();
                            }


                        }
                    }
                    else if (id[0].Equals('R'))
                    {

                        query = "Select * from Receptionist where ReceptionistId = '" + id + "' and password = '" + password + "';";
                        var dt = DataAccess.GetDataTable(query);
                        if (dt.Rows.Count == 0)
                            lblError.Visible = true;
                        else
                        {
                            lblError.Visible = false;
                            var receptionist = new Receptionist();
                            receptionist.id = id;
                            receptionist.password = password;
                            receptionist.name = dt.Rows[0]["name"].ToString();
                            receptionist.phone = dt.Rows[0]["phone"].ToString();
                            receptionist.adminId = dt.Rows[0]["AdminId"].ToString();
                            receptionist.hireDate = DateTime.Parse(dt.Rows[0]["hiredate"].ToString());
                            try
                            {
                                receptionist.resignDate = DateTime.Parse(dt.Rows[0]["resigndate"].ToString());
                                isResigned = true;
                            }
                            catch (Exception)
                            {
                                isResigned = false;
                            }
                            if (isResigned == true)
                            {
                                MessageBox.Show("Resigned Employee Can't Login", "Resigned Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {

                                MessageBox.Show("Login Successfull", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                var newForm = new ReceptionistForm(receptionist);
                                newForm.ShowDialog();
                                this.Close();

                            }


                        }

                    }
                    else if (id[0].Equals('P'))
                    {
                        query = "Select * from Pharmacist where PharmacistId = '" + id + "' and password = '" + password + "';";
                        var dt = DataAccess.GetDataTable(query);
                        if (dt.Rows.Count == 0)
                            lblError.Visible = true;
                        else
                        {
                            lblError.Visible = false;
                            var pharmacist = new Pharmacist();
                            pharmacist.id = id;
                            pharmacist.password = password;
                            pharmacist.name = dt.Rows[0]["name"].ToString();
                            pharmacist.phone = dt.Rows[0]["phone"].ToString();
                            pharmacist.adminId = dt.Rows[0]["AdminId"].ToString();
                            pharmacist.hireDate = DateTime.Parse(dt.Rows[0]["hiredate"].ToString());
                            try
                            {
                                pharmacist.resignDate = DateTime.Parse(dt.Rows[0]["resigndate"].ToString());
                                isResigned = true;
                            }
                            catch (Exception)
                            {
                                isResigned = false;
                            }
                            if (isResigned == true)
                            {
                                MessageBox.Show("Resigned Employee Can't Login", "Resigned Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {

                                MessageBox.Show("Login Successfull", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                var newForm = new PharmacistForm(pharmacist);
                                newForm.ShowDialog();
                                this.Close();
                            }


                        }

                    }
                    else
                    {
                        lblError.Text = "!Invalid Credentials";
                        lblError.Visible = true;
                    }

                }
                else
                {
                    lblError.Text = "!Invalid Credentials";
                    lblError.Visible = true;
                }

            }

        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                this.btnLogin_Click(new object(), new EventArgs());
            
            }
        }

        
        }

    }

