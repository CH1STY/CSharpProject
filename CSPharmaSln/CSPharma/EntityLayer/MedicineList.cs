using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSPharma.DataLayer;

namespace CSPharma.EntityLayer
{
    class MedicineList
    {
        public string medicineId { get; set; }
        public string salesID { get; set; }
        public int quantity { get; set; }

        public void CreateNewSale() {

            string InsertQuery = "Insert INTO MedicineList (medicineId,salesId,quantity) Values('" + this.medicineId + "','" + this.salesID + "'," + this.quantity + ");";
           
                DataAccess.ExecuteUpdateQuery(InsertQuery);
                
           
        
        }
    }
}
