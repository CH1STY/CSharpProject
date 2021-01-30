using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSPharma.DataLayer;
using CSPharma.RepoLayer;

namespace CSPharma.EntityLayer
{
    public class Product
    {
        public string medicineId { get; set; }
        public string name { get; set; }
        public int quantity { get; set; }
        public int price { get; set; }
        public string adminId { get; set; }

        private InventoryRepo IRepo { get; set; }
        

        public bool CreateMedicine()
        {
            IRepo = new InventoryRepo();
            return IRepo.CreateMedicine(this);
        }

        public static string AutoGenerateId()
        {
            return InventoryRepo.AutoGenerateId();
        }

        public void UpdateProduct() {

            IRepo = new InventoryRepo();
            IRepo.UpdateMedicine(this);
            
                    
        }

    }



}
