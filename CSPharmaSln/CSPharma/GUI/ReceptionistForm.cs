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
    public partial class ReceptionistForm : Form
    {
        private Receptionist receptionist;

        public ReceptionistForm(Receptionist receptionist)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.receptionist = receptionist;
            this.lblReceptionistName.Text = receptionist.name;
            this.lblReceptionistId.Text = receptionist.id;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnEditPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new ChangeUserPasswordForm(receptionist);
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

        private void lblCreateAnAppointMent_MouseHover(object sender, EventArgs e)
        {
            this.lblCreateAnAppointMent.ForeColor = Color.PaleGreen;

        }

        private void lblCreateAnAppointMent_MouseLeave(object sender, EventArgs e)
        {
            this.lblCreateAnAppointMent.ForeColor = Color.White;
        }

   
        private void lblUpdateAnAppointment_MouseHover(object sender, EventArgs e)
        {
            this.lblUpdateAnAppointment.ForeColor = Color.PaleGreen;
        }

        private void lblUpdateAnAppointment_MouseLeave(object sender, EventArgs e)
        {
            this.lblUpdateAnAppointment.ForeColor = Color.White;
        }

        private void lblCreateAnAppointMent_Click(object sender, EventArgs e)
        {
            this.Hide();
            AppointmentForm newForm = new AppointmentForm(this.receptionist);
            newForm.ShowDialog();
            this.Close();
        }


        private void lblUpdateAnAppointment_Click(object sender, EventArgs e)
        {
            var checkIdString = new Regex("^[a-zA-Z0-9]*$");
            
            string AppointmentId = this.txtAppointmentID.Text;
            bool isAptIDValid;
            isAptIDValid = checkIdString.IsMatch(AppointmentId);
            if (isAptIDValid)
            {
                isAptIDValid = this.ValidateAptId(AppointmentId);
            }
            
            if (isAptIDValid)
            {
                if(!char.IsDigit(AppointmentId[0])){
                this.lblAptIdError.Visible = false;
                string query = "Select * from Appointment where appointmentid = '"+AppointmentId+"';";
                var dt = DataAccess.GetDataTable(query);
                var aptObj = new Appointment();
                aptObj.id = AppointmentId;
                aptObj.name = dt.Rows[0]["PatientName"].ToString();
                aptObj.phone = dt.Rows[0]["Phone"].ToString();
                aptObj.age = short.Parse(dt.Rows[0]["PatientAge"].ToString());
                aptObj.doctorId = dt.Rows[0]["DoctorId"].ToString();
                aptObj.receptionistId = dt.Rows[0]["ReceptionistId"].ToString();

                this.Hide();
                var newForm = new AppointmentForm(receptionist, aptObj);
                newForm.ShowDialog();
                this.Close();

                }
                else{
                     this.lblAptIdError.Visible = true;
                }

            }
            else
            {
                this.lblAptIdError.Visible = true;
            }


        }

        private void lblViewAptList_MouseHover(object sender, EventArgs e)
        {
            this.lblViewAptList.ForeColor = Color.PaleGreen;
           
        }

        private void lblViewAptList_MouseLeave(object sender, EventArgs e)
        {
            this.lblViewAptList.ForeColor = Color.White;
        }

        private void txtAppointmentID_Enter(object sender, EventArgs e)
        {
            if (this.txtAppointmentID.Text.Equals("APPOINTMENT ID"))
            {

                this.txtAppointmentID.Text = "";
                this.txtAppointmentID.ForeColor = Color.White;
            }
        }

        private void txtAppointmentID_Leave(object sender, EventArgs e)
        {
            if (this.txtAppointmentID.Text.Equals(""))
            {

                this.txtAppointmentID.ForeColor = Color.Silver;
                this.txtAppointmentID.Text = "APPOINTMENT ID";

            }
        }

        private void lblViewAptList_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new AppointmentListForm(this.receptionist);
            newForm.ShowDialog();
            this.Close();

        }

        private bool ValidateAptId(string AppointmentId) {
            string query = "Select appointmentId from Appointment where appointmentid = '"+AppointmentId+"' ;";
            var dt = DataAccess.GetDataTable(query);
            if (dt.Rows.Count > 0)
                return true;
            else {
                return false;            
            }

        }
       
    }
}
