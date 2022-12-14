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

        public bool createTrans(DataTable medHandler, int userId, DateTime transDate, int totalPrice, int brandId)
        {

            string query = "exec dbo.createTransaction @medicineHandler , @userId , @transDate , @totalPrice , @brandId";
            DataTable data = DataProvider.Instance.ExecuteQueryForTrans(query, new object[] { medHandler, userId, transDate, totalPrice, brandId });
            return true;
        }

        public List<Transaction> loadTransListByUserId(string userId, int state)
        {
            List<Transaction> transList = new List<Transaction>();
            string query = "exec dbo.getTransactionByUserId @userId , @state";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { userId, state });
            foreach (DataRow item in data.Rows)
            {
                Transaction trans = new Transaction(item);
                transList.Add(trans);
            }
            return transList;
        }

        public bool confirmTrans(int transId, int state)
        {
            string query = "exec dbo.confirmTrans @transId , @state";
            DataProvider.Instance.ExecuteQuery(query, new object[] { transId, state });
            return true;
        }
    }
}
