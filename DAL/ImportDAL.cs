using DTO;
using System;
using System.Collections.Generic;
using System.Data;
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

        public List<Import> GetImports(int status)
        {
            List<Import> imports = new List<Import>();
            string query = "exec dbo.getRequestImport @status";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { status });
            foreach (DataRow item in data.Rows)
            {
                imports.Add(new Import(item));
            }
            return imports;
        }

        public bool cancelImport(string importId)
        {
            string query = "exec dbo.cancleImportRequest @importId";
            DataProvider.Instance.ExecuteQuery(query, new object[] { importId });
            return true;
        }

        public bool updateImport(string importId)
        {
            string query = "exec dbo.updateRequestImport @importId";
            DataProvider.Instance.ExecuteQuery(query, new object[] { importId });
            return true;
        }
    }
}
