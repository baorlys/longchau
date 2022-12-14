using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ImportDAL
    {
        private static ImportDAL instance;

        private ImportDAL() { }
        public static ImportDAL Instance
        {
            get { if (instance == null) instance = new ImportDAL(); return instance; }
            set { ImportDAL.instance = value; }
        }

        public bool importMed(string mdcId, int quantity)
        {
            string query = "exec dbo.createRequestImport @mdcId , @quantity";
            DataProvider.Instance.ExecuteQuery(query, new object[] {mdcId, quantity});
            return true;
        }
    }
}
