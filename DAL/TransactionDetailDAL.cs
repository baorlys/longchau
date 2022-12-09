using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TransactionDetailDAL
    {
        private static TransactionDetailDAL instance;

        private TransactionDetailDAL() { }
        public static TransactionDetailDAL Instance
        {
            get { if (instance == null) instance = new TransactionDetailDAL(); return instance; }
            set { TransactionDetailDAL.instance = value; }
        }

        public List<TransactionDetail> loadTransDetail(int transId)
        {
            List<TransactionDetail> transDetailList = new List<TransactionDetail>();
            string query = "exec dbo.getTransDetail @transId";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { transId });
            foreach (DataRow item in data.Rows)
            {
                TransactionDetail detail = new TransactionDetail(item);
                transDetailList.Add(detail);
            }
            return transDetailList;
        }
    }
}
