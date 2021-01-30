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
    public partial class ChangeUserPasswordForm : Form
    {
        private Admin admin;
        private Receptionist receptionist;
        private Pharmacist pharmacist;

        private bool flagAdmin, flagReceptionist, flagPharmacist;


        public ChangeUserPasswordForm(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
            flagAdmin = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        public ChangeUserPasswordForm(Receptionist receptionist)
        {
            InitializeComponent();
            this.receptionist = receptionist;
            flagReceptionist = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        public ChangeUserPasswordForm(Pharmacist pharmacist)
        {
            InitializeComponent();
            this.pharmacist = pharmacist;
            flagPharmacist = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.lblPasswordErr.Visible = false;
            bool isPassword = this.CheckPassword(this.txtNewPass.Text);

            if (isPassword)
            {

                if (flagAdmin)
                {



                    string sql = @"update Admin set password = '" + this.txtNewPass.Text + "' where AdminId = '" + this.admin.id + "'";

                    int count = DataAccess.ExecuteUpdateQuery(sql);
                    if (count == 1)
                    {
                        MessageBox.Show("'" + this.admin.id + "' updated successfully.");
                        this.admin.password = this.txtNewPass.Text;
                    }
                    else
                        MessageBox.Show("Password update failed.");

                    this.Hide();
                    var newForm = new AdminForm(this.admin);
                    newForm.ShowDialog();
                    this.Close();


                }
                if (flagReceptionist)
                {
                    string sql = @"update Receptionist set password = '" + this.txtNewPass.Text + "' where ReceptionistId = '" + this.receptionist.id + "'";

                    int count = DataAccess.ExecuteUpdateQuery(sql);
                    if (count == 1)
                    {
                        MessageBox.Show("'" + this.receptionist.id + "' updated successfully.");
                        this.receptionist.password = this.txtNewPass.Text;
                    }
                    else
                        MessageBox.Show("Password update failed.");

                    this.Hide();
                    var newForm = new ReceptionistForm(this.receptionist);
                    newForm.ShowDialog();
                    this.Close();

                }
                if (flagPharmacist)
                {
                    string sql = @"update Pharmacist set password = '" + this.txtNewPass.Text + "' where PharmacistId = '" + this.pharmacist.id + "'";

                    int count = DataAccess.ExecuteUpdateQuery(sql);
                    if (count == 1)
                    {
                        MessageBox.Show("'" + this.pharmacist.id + "' updated successfully.");
                        this.pharmacist.password = this.txtNewPass.Text;
                    }
                    else
                        MessageBox.Show("Password update failed.");

                    this.Hide();
                    var newForm = new PharmacistForm(this.pharmacist);
                    newForm.ShowDialog();
                    this.Close();

                }

            }
            else {

                this.lblPasswordErr.Visible = true;
            }


            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (flagAdmin)
            {
                this.Hide();
                AdminForm a1 = new AdminForm(this.admin);
                a1.ShowDialog();
                this.Close();
            }
            if (flagReceptionist)
            {
                this.Hide();
                ReceptionistForm a1 = new ReceptionistForm(this.receptionist);
                a1.ShowDialog();
                this.Close();
            }
            if (flagPharmacist)
            {
                this.Hide();
                PharmacistForm a1 = new PharmacistForm(this.pharmacist);
                a1.ShowDialog();
                this.Close();
            }
        }


       

        private void txtNewPass_Enter(object sender, EventArgs e)
        {
            this.txtNewPass.Text = "";
            this.txtNewPass.UseSystemPasswordChar = true;
            this.txtNewPass.ForeColor = Color.White;
        }

        private void txtNewPass_Leave(object sender, EventArgs e)
        {
            this.txtNewPass.Text = "NEW PASSWORD";
            this.txtNewPass.UseSystemPasswordChar = false;
            this.txtNewPass.ForeColor = Color.Silver;
        }

        private bool CheckPassword(string password)
        {
            bool isWhite = String.IsNullOrWhiteSpace(password);
            if (password.Length < 4 || isWhite || password.Equals("PASSWORD") || password.IndexOf("'")!=-1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    
    }
}
