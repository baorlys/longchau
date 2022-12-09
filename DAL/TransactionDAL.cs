using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TransactionDAL
    {
        private static TransactionDAL instance;

        public static TransactionDAL Instance
        {
            get { if (instance == null) instance = new TransactionDAL(); return instance; }
            set { TransactionDAL.instance = value; }
        }
        public static int TransWidth = 90;
        public static int TransHeight = 90;

        private TransactionDAL() { }

        public List<Transaction> loadTransList(string date, int state)
        {
            List<Transaction> transList = new List<Transaction>();
            string query = "exec dbo.getTrans @date , @state";
            DataTable data;
            if (date == null)
            {
                data = DataProvider.Instance.ExecuteQuery(query, new object[] { DBNull.Value, state });
            }
            else data = DataProvider.Instance.ExecuteQuery(query, new object[] { date, state });
            foreach (DataRow item in data.Rows)
            {
                Transaction trans = new Transaction(item);
                transList.Add(trans);
            }
            return transList;
        }
    }
}
