using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string query = "select * from medicine";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, null);
            foreach(DataRow item in data.Rows) {
                Medicine med = new Medicine(item);
                list.Add(med);
            }
            return list;
        }

        public DataTable loadMedicineToDt()
        {
            string query = "select * from medicine";
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

    }
}
