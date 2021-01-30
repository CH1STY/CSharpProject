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
    public partial class AppointmentForm : Form
    {
        private Receptionist receptionist;
        private Appointment appointment;
        private bool isUpdate;
        
        public AppointmentForm(Receptionist receptionist, Appointment appointment) {
            InitializeComponent();
            isUpdate = true;
            this.ActiveControl = this.lblAppointmentForm;
            this.receptionist = receptionist;
            this.appointment = appointment;
            this.txtPatientAge.MaxLength = 2;
            this.txtPatientPhone.MaxLength = 11;
            this.dtpAppointmentDate.Value = DateTime.Now;
            this.dtpAppointmentDate.MinDate = DateTime.Now;
            this.txtPatientName.Text = appointment.name;
            this.txtPatientName.Enabled = false;
            this.txtPatientAge.Text = appointment.age.ToString();
            this.txtPatientPhone.Text = appointment.phone.Substring(0,11);
            this.btnCreate.Text = "UPDATE";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;


        }

        public AppointmentForm(Receptionist receptionist)
        {
            InitializeComponent();
            isUpdate = false;
            this.ActiveControl = this.lblAppointmentForm;
            this.receptionist = receptionist;
            this.txtPatientAge.MaxLength = 2;
            this.txtPatientPhone.MaxLength = 11;
            this.dtpAppointmentDate.Value = DateTime.Now;
            this.dtpAppointmentDate.MinDate = DateTime.Now;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;


        }

        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            this.FillComboBoxDoctor();
        }


        private void FillComboBoxDoctor() {

            string query = ("Select *from Doctor where doctorId != 'D100' and resignDate is NULL");
            var dt = DataAccess.GetDataTable(query);
            for (int index = 0; index < dt.Rows.Count; index++) {

                this.comboBoxDoctor.Items.Add(dt.Rows[index]["name"]);
            
            }

        }

     
        private void txtPatientName_Leave(object sender, EventArgs e)
        {
            if (this.txtPatientName.Text.Equals(""))
            {

                this.txtPatientName.Text = "NAME";
                this.txtPatientName.ForeColor = Color.Silver;
            }
        }

        private void txtPatientName_Enter(object sender, EventArgs e)
        {
            if (this.txtPatientName.Text.Equals("NAME"))
            {

                this.txtPatientName.Text = "";
                this.txtPatientName.ForeColor = Color.White;
            }
        }

        private void txtPatientPhone_Leave(object sender, EventArgs e)
        {
            if (this.txtPatientPhone.Text.Equals(""))
            {

                this.txtPatientPhone.Text = "PHONE";
                this.txtPatientPhone.ForeColor = Color.Silver;
            }
        }

        private void txtPatientPhone_Enter(object sender, EventArgs e)
        {
            if (this.txtPatientPhone.Text.Equals("PHONE"))
            {

                this.txtPatientPhone.Text = "";
                this.txtPatientPhone.ForeColor = Color.White;
            }
        }

        private void txtPatientAge_Leave(object sender, EventArgs e)
        {
            if (this.txtPatientAge.Text.Equals(""))
            {

                this.txtPatientAge.Text = "AGE";
                this.txtPatientAge.ForeColor = Color.Silver;
            }
        }

        private void txtPatientAge_Enter(object sender, EventArgs e)
        {
            if (this.txtPatientAge.Text.Equals("AGE"))
            {

                this.txtPatientAge.Text = "";
                this.txtPatientAge.ForeColor = Color.White;
            }
        }
        

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string name = this.txtPatientName.Text;
            string phone = this.txtPatientPhone.Text;
            string age = this.txtPatientAge.Text;
            string doctorName = "";
            try{
            doctorName = this.comboBoxDoctor.SelectedItem.ToString();
            }
            catch(Exception){}

            bool nameFlag, phoneFlag, ageFlag, doctorFlag=true, operationSuccess;
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

            phoneFlag = this.CheckPhoneNumber(phone);
            if (!phoneFlag)
            {
                this.lblPhoneErr.Visible = true;
            }
            else
            {
                this.lblPhoneErr.Visible = false;
            }
            ageFlag = this.CheckAge(age);
            if (!ageFlag)
            {
                this.lblAgeError.Visible = true;
            }
            else
            {
                this.lblAgeError.Visible = false;
            }
            
            
            if (doctorName == null || doctorName == "")
            {
                doctorFlag = false;
            }
            if (!doctorFlag)
            {
                this.lblDoctorErr.Visible = true;
            }
            else 
            {
                this.lblDoctorErr.Visible = false;
            
            }

            //END OF ERROR CHECK

            if (nameFlag && phoneFlag && ageFlag && doctorFlag)
            {
                operationSuccess = true;
                var newAppointment = new Appointment();
                newAppointment.name = name;
                newAppointment.phone = phone;
                newAppointment.age = short.Parse(age);
                newAppointment.receptionistId = this.receptionist.id;
                try
                {
                    newAppointment.appointmentDate = DateTime.Parse(this.dtpAppointmentDate.Value.ToString("yyyy-MM-dd"));
                    newAppointment.id = Appointment.AutoGenerateId();
                    newAppointment.doctorId = Doctor.GetDoctorId(doctorName);
                }
                catch (Exception) { operationSuccess = false; }
                if (operationSuccess)
                {
                    if (isUpdate)
                    {
                        newAppointment.id = this.appointment.id;
                        operationSuccess = newAppointment.UpdateAppointment();
                    }
                    else
                    {
                        operationSuccess = newAppointment.CreateAppointment();
                    }
                }
                if (operationSuccess)
                {
                    if (isUpdate)
                    {
                        MessageBox.Show("Appointment Succesfully Updated Check List \nAppointmentID:\t" + newAppointment.id, "DONE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();
                        var newForm = new ReceptionistForm(this.receptionist);
                        newForm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Appointment Succesfully Created \nAppointmentID:\t" + newAppointment.id, "DONE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.ClearTxt();
                    }
                }
                else
                {
                    MessageBox.Show("CRITICAL DATABASE ERROR!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

              
                
                
            }
        
        }

        private void ClearTxt() {
            this.txtPatientAge.ForeColor = Color.Silver;
            this.txtPatientAge.Text = "AGE";
            this.txtPatientName.ForeColor = Color.Silver;
            this.txtPatientName.Text = "NAME";
            this.txtPatientAge.ForeColor = Color.Silver;
            this.txtPatientAge.Text = "AGE";
            this.txtPatientPhone.ForeColor = Color.Silver;
            this.txtPatientPhone.Text = "PHONE";
            this.comboBoxDoctor.ResetText();
            this.comboBoxDoctor.SelectedIndex = -1;
            this.dtpAppointmentDate.Value = DateTime.Now;

        
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

            return true;


        }

        private bool CheckName(string name)
        {
            var nameCheck = new Regex("^[ a-zA-Z.]*$");
            long n;
            bool isNumeric = Int64.TryParse(name, out n);


            if (name[0]=='.'||name.Length < 3 || char.IsWhiteSpace(name[0]) || name.Equals("NAME") || isNumeric || String.IsNullOrWhiteSpace(name) || !nameCheck.IsMatch(name))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private bool CheckAge(string age) {
            long n;
            bool isNumeric = Int64.TryParse(age, out n);

            if (!isNumeric || Char.IsWhiteSpace(age[0]))
            {
                this.lblAgeError.Text = "!Enter A Valid Age";
                return false;

            }

            return true;

        
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReceptionistForm receptionistForm = new ReceptionistForm(this.receptionist);
            receptionistForm.ShowDialog();
            this.Close();
        }
    }
}
