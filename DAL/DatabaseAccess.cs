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
        public static string checkLoginDTO(User user)
        {
            string userInfo = null;
            SqlConnection conn = SQLConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("signIn", conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@email", user.email);
            command.Parameters.AddWithValue("@password", user.password);
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while(reader.Read())
                {
                    userInfo = reader.GetString(0);
                    return userInfo;
                }
                reader.Close();
                conn.Close();
            }
            else
            {
                return "invalid email/pass";
            }
            return userInfo;

        }
    }
}
