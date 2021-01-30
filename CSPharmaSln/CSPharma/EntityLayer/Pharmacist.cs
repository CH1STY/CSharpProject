using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSPharma.DataLayer;

namespace CSPharma.EntityLayer
{
    public class Pharmacist
    {
        internal string id { get; set; }
        internal string name { get; set; }
        internal string phone { get; set; }
        internal string password { get; set; }
        internal string adminId { get; set; }
        internal DateTime hireDate { get; set; }
        internal DateTime resignDate { get; set; }

        public bool CreatePharmacist() {
            string InsertQuery = "Insert INTO Pharmacist (pharmacistId,name,phone,password,hiredate,AdminId) Values('" + this.id + "','" + this.name + "','" + this.phone + "','" + this.password + "','" + this.hireDate.ToString("yyyy-MM-dd").Substring(0, 10) + "','" + this.adminId + "')";
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
            //Auto Generation of ID using the Value of Last Added Admin ID
            string query = "Select Max(PharmacistId) as PharmacistId from Pharmacist";
            var dt = DataAccess.GetDataTable(query);
            string prevId = dt.Rows[0]["PharmacistId"].ToString();
            prevId = prevId.Substring(1, 3);
            int id = Int32.Parse(prevId);
            id++;
            return ("P" + id);
        }

    }
}
