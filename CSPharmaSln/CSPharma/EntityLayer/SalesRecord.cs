using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSPharma.DataLayer;

namespace CSPharma.EntityLayer
{
    public class SalesRecord
    {
        public string pharmacistId { get; set; }
        public string salesID { get; set; }
        public DateTime date { get; set; }
        public float totalCost { get; set; }


        public static string AutoGenerateID()
        {
            string query = "Select Max(SalesID) as SalesId from SalesRecord";
            var dt = DataAccess.GetDataTable(query);
            string prevId = dt.Rows[0]["SalesId"].ToString();
            prevId = prevId.Substring(1, 3);
            int id = Int32.Parse(prevId);
            id++;
            return ("S" + id);
        }

        public void CreateSalesRecord() {

            string InsertQuery = "Insert INTO SalesRecord (pharmacistId,salesId,TotalCost,date) Values('" + this.pharmacistId + "','" + this.salesID + "'," + this.totalCost + ",'"+this.date.ToString("yyyy-MM-dd HH:mm:ss")+"');";

            DataAccess.ExecuteUpdateQuery(InsertQuery);
        
        
        }


    }
}
