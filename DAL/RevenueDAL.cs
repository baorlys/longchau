using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RevenueDAL
    {
        private static RevenueDAL instance;
        public static RevenueDAL Instance
        {
            get { if (instance == null) instance = new RevenueDAL(); return instance; }
            set { RevenueDAL.instance = value; }
        }

        public List<Revenue> loadRevenue(DateTime from, DateTime to)
        {
            List<Revenue> list = new List<Revenue>();
            string query = "exec dbo.getRevenue @from , @to";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { from, to });
            foreach (DataRow item in data.Rows)
            {
                Revenue rev = new Revenue(item);
                list.Add(rev);
            }
            return list;
        }

        public int countNumberTrans(List<Revenue> list) { 
            return list.Count();
        }

        public int getTotalPriceRev(List<Revenue> list)
        {
            int totalPriceRev = 0;
            foreach (Revenue rev in list)
            {
                totalPriceRev += rev.TotalPrice;
            }
            return totalPriceRev;
        }
    }
}
