using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CSPharma.DataLayer;
using CSPharma.EntityLayer;

namespace CSPharma.RepoLayer
{
    public class InventoryRepo
    {
        public List<Product> GetAll()
        {
            var productList = new List<Product>();
            var sql = "select * from Medicine";
            var dt = DataAccess.GetDataTable(sql);
            for (int index = 0; index < dt.Rows.Count; index++)
            {
                Product p = ConvertToEntity(dt.Rows[index]);
                productList.Add(p);
            }
            return productList;
        }

        private Product ConvertToEntity(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            var p = new Product();
            p.medicineId = row["MedicineId"].ToString();
            p.name = row["name"].ToString();
            p.price = int.Parse(row["price"].ToString());
            p.quantity = int.Parse(row["quantity"].ToString());
            p.adminId = row["AdminId"].ToString();

            return p;
        }

        public bool CreateMedicine(Product product)
        {
            string InsertQuery = "Insert INTO Medicine (MedicineId,name,price,quantity,AdminId) Values('" + product.medicineId + "','" + product.name + "','" + product.price + "','" + product.quantity + "','" + product.adminId + "')";
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
            string query = "Select Max(MedicineId) as MedicineId from Medicine";
            var dt = DataAccess.GetDataTable(query);
            string prevId = dt.Rows[0]["MedicineId"].ToString();
            prevId = prevId.Substring(1, 3);
            int id = Int32.Parse(prevId);
            id++;
            return ("M" + id);
        }

        public void UpdateMedicine(Product product) {
            string query = "Update Medicine set quantity ="+product.quantity+" where MedicineId = '"+product.medicineId+"' ;";
            DataAccess.ExecuteUpdateQuery(query);
        
        }

    }
}
