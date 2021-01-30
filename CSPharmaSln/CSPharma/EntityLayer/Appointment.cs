using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSPharma.DataLayer;

namespace CSPharma.EntityLayer
{
    public class Appointment
    {
        internal string id { get; set; }
        internal string name { get; set; }
        internal string phone { get; set; }
        internal short age { get; set; }
        internal string receptionistId;
        internal string doctorId { get; set; }
        internal DateTime appointmentDate { get; set; }

        public bool CreateAppointment()
        {

            string InsertQuery = "Insert INTO appointment (AppointmentId,PatientName,phone,PatientAge,Date,ReceptionistId,DoctorId) Values('" + this.id + "','" + this.name + "','" + this.phone + "'," + this.age + ",'" + this.appointmentDate.ToString("yyyy-MM-dd").Substring(0, 10) + "','"+this.receptionistId+"', '"+this.doctorId+"')";
            try
            {
                DataAccess.ExecuteUpdateQuery(InsertQuery);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }


        public static string AutoGenerateId()
        {
            //Auto Generation of ID using the Value of Last Added Appointment ID
            string query = "Select Max(AppointmentId) as AppointmentId from Appointment";
            var dt = DataAccess.GetDataTable(query);
            string prevId = dt.Rows[0]["AppointmentId"].ToString();
            prevId = prevId.Substring(2, 4);
            int id = Int32.Parse(prevId);
            id++;
            return ("AP" + id);
        }

        public bool UpdateAppointment() {
            string UpdateQuery = "Update appointment Set patientName = '"+this.name+"', patientAge ="+this.age+ ", phone ='"+this.phone+"', DoctorId = '"+this.doctorId+"', ReceptionistId ='"+this.receptionistId+"', Date ='"+this.appointmentDate.ToString("yyyy-MM-dd").Substring(0,10)+"'  where AppointmentId ='"+this.id+"';"; 
            
            try
            {
                DataAccess.ExecuteUpdateQuery(UpdateQuery);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    
    }

   
}
