using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSPharma.DataLayer;

namespace CSPharma.EntityLayer
{
    class Doctor
    {
        internal string id { get; set; }
        internal string name { get; set; }
        internal string phone { get; set; }
        internal string adminId { get; set; }
        internal DateTime hireDate { get; set; }
        internal DateTime resignDate { get; set; }

        public bool CreateDoctor()
        {

            string InsertQuery = "Insert INTO Doctor (DoctorId,name,phone,AdminId,hiredate) Values('" + this.id + "','" + this.name + "','" + this.phone + "','" + this.adminId + "','" + this.hireDate.ToString("yyyy-MM-dd").Substring(0, 10) + "')";
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
            //Auto Generation of ID using the Value of Last Added DOCTOR ID
            string query = "Select Max(DoctorId) as DoctorId from Doctor";
            var dt = DataAccess.GetDataTable(query);
            string prevId = dt.Rows[0]["DoctorId"].ToString();
            prevId = prevId.Substring(1, 3);
            int id = Int32.Parse(prevId);
            id++;
            return ("D" + id);
        }

        public static string GetDoctorId(string name) {

            string query = "Select DoctorId as DoctorId from Doctor where name = '"+name+"' ;";
            var dt = DataAccess.GetDataTable(query);

            return dt.Rows[0]["DoctorId"].ToString();
        
        } 

    }
}

