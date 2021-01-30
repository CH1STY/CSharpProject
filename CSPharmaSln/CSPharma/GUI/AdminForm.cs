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
    public partial class AdminForm : Form
    {
        private Admin admin;

        public AdminForm(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
            this.lblAdminName.Text = this.admin.name;
            this.lblAdminId.Text = this.admin.id;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private void RegistrationLabel_MouseHover(object sender, EventArgs e)
        {
            lblRegistration.ForeColor=Color.PaleGreen;
        }

        private void lblRegistration_MouseLeave(object sender, EventArgs e)
        {
            lblRegistration.ForeColor = Color.White;
        }

        private void lblEditDoctor_MouseHover(object sender, EventArgs e)
        {
            lblEditDoctor.ForeColor = Color.PaleGreen;
        }

        private void lblEditDoctor_MouseLeave(object sender, EventArgs e)
        {
            lblEditDoctor.ForeColor = Color.White;
        }

        private void lblEditUser_MouseHover(object sender, EventArgs e)
        {
            lblEditUser.ForeColor = Color.PaleGreen;
        }

        private void lblEditUser_MouseLeave(object sender, EventArgs e)
        {
            lblEditUser.ForeColor = Color.White;
        }

        private void lblEditInventory_MouseHover(object sender, EventArgs e)
        {
            lblEditInventory.ForeColor = Color.PaleGreen;
        }

        private void lblEditInventory_MouseLeave(object sender, EventArgs e)
        {
            lblEditInventory.ForeColor = Color.White;
        }

        private void lblRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserRegistration u1 = new UserRegistration(admin);
            u1.ShowDialog();
            this.Close();
        }

        private void lblEditInventory_Click(object sender, EventArgs e)
        {
            this.Hide();
            InventoryForm i1 = new InventoryForm(this.admin);
            i1.ShowDialog();
            this.Close();
        }

        private void lblEditDoctor_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorForm d1 = new DoctorForm(this.admin);
            d1.ShowDialog();
            this.Close();
        }

       

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm d1 = new LoginForm();
            d1.ShowDialog();
            this.Close();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangeUserPasswordForm f1 = new ChangeUserPasswordForm(this.admin);
            f1.ShowDialog();
            this.Close();
            
        }

        private void lblEditUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new GeneralUpdateForm(this.admin);
            newForm.ShowDialog();
            this.Close();
        }
    }
}
