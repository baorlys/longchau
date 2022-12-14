using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL
{
    public class MedicineDAL
    {
        private static MedicineDAL instance;
        public static int MedWidth = 90;
        public static int MedHeight = 90;
        private MedicineDAL() { }
        public static MedicineDAL Instance
        {
            get { if (instance == null) instance = new MedicineDAL(); return instance; }
            set { MedicineDAL.instance = value; }
        }
        
        public List<Medicine> loadMedicine()
        {
            List<Medicine> list = new List<Medicine>();
            string query = "exec dbo.getAllMedicine";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, null);
            foreach(DataRow item in data.Rows) {
                Medicine med = new Medicine(item);
                list.Add(med);
            }
            return list;
        }

        public DataTable loadMedicineToDt()
        {
            string query = "exec dbo.getAllMedicine";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, null);
            return data;
        }

        public Medicine loadMedicineByMdcId(string mdcId)
        {
            string query = "exec dbo.getMdcById @mdcId";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { mdcId });
            foreach (DataRow item in data.Rows)
            {
                Medicine med = new Medicine(item);
                return med;
            }
            return null;
        }

        public List<Medicine> loadMedicineByName(string name)
        {
            List<Medicine> list = new List<Medicine>();
            string query = "exec dbo.getMdcByName @name";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] {name});
            foreach (DataRow item in data.Rows)
            {
                Medicine med = new Medicine(item);
                list.Add(med);
            }
            return list;
        }

        public DataTable loadMedicineByNameToDt(string name)
        {
            string query = "exec dbo.getMdcByName @name";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { name });
            return data;
        }

        public bool updateQuantity(string mdcId, int quantity)
        {
            string query = "exec dbo.updateMdcQuantity @mdcId , @quantity";
            DataProvider.Instance.ExecuteQuery(query, new object[] { mdcId, quantity });
            return true;
        }


        public DataTable getMdcAboutToExpire(int quantity)
        {
            string query = "exec dbo.getMdcAboutToExpire @quantity";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { quantity });
            return data;
        }
    }
}
