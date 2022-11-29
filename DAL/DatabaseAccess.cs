using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class SQLConnectionData
    {
        public static SqlConnection Connect()
        {
            string strCon = "Data Source=BAORLYS\\SQLEXPRESS;Initial Catalog=longchau;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strCon);
            return conn;
        }
    }
    public class DatabaseAccess
    {
        public static string checkLogin(user user)
        {
            SqlConnection conn = SQLConnectionData.Connect();
            conn.Open();
            
        }
    }
}
