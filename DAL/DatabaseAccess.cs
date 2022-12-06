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
            string strCon = "Data Source=LAPTOP-M3S86HF2\\XBINH;Initial Catalog=longchau;Integrated Security=True";
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

        public static MessageHandler CheckSignUpDTO(User user)
        {
            MessageHandler message = new MessageHandler("", true);
            SqlConnection conn = SQLConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("checkEmail", conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@email", user.email);
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                message.setMessage("Email đã tồn tại");
                message.setStatus(false);
                reader.Close();
                conn.Close();
                return message;
            }
            reader.Close();

            SqlCommand command1 = new SqlCommand("checkPhone", conn);
            command1.CommandType = System.Data.CommandType.StoredProcedure;
            command1.Parameters.AddWithValue("@phone", user.phone);
            command1.Connection = conn;
            SqlDataReader reader1 = command1.ExecuteReader();
            if (reader1.HasRows)
            {
                message.setMessage("Số điện thoại đã tồn tại");
                message.setStatus(false);
                reader1.Close();
                conn.Close();
                return message;
            }
            reader1.Close();

            SqlCommand command3 = new SqlCommand("signUp", conn);
            command3.CommandType = System.Data.CommandType.StoredProcedure;
            command3.Parameters.AddWithValue("@email", user.email);
            command3.Parameters.AddWithValue("@name", user.name);
            command3.Parameters.AddWithValue("@phone", user.phone);
            command3.Parameters.AddWithValue("@password", user.password);
            command3.Connection = conn;
            command3.ExecuteNonQuery();
            message.setMessage("Đăng ký thành công");
            message.setStatus(true);
            conn.Close();
            return message;

        }
    }
}
