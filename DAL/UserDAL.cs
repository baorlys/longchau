﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using static System.Net.WebRequestMethods;

namespace DAL
{
    public class UserDAL 
    {
        private static UserDAL instance;
        private static MD5Hash md5 = new MD5Hash();
        private UserDAL() { }
        public static UserDAL Instance
        {
            get { if (instance == null) instance = new UserDAL(); return instance; }
            set { UserDAL.instance = value; }
        }
        public bool checkLogin(User user)
        {
            string query = "exec dbo.signIn @email , @password";
            string password = md5.GetHash(user.Password);
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { user.Email, password });
            if (data != null)
            {
                if (data.Rows.Count > 0)
                {
                    return true;
                }
                else return false;
            }
            return false;
        }

        public User getUserByEmail(string email)
        {
            string query = "exec dbo.checkEmail @email";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { email });
            foreach(DataRow item in data.Rows)
            {
                return new User(item);
            }
            return null;
        }
        public MessageHandler checkSignUp(User user)
        {
            MessageHandler message = new MessageHandler("", true);

            string query = "exec dbo.checkEmail @email";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { user.Email });
            if (result.Rows.Count > 0)
            {
                message.setMessage("Email đã tồn tại");
                message.setStatus(false);
                return message;
            }

            query = "exec dbo.checkPhone @phone";
            result = DataProvider.Instance.ExecuteQuery(query, new object[] { user.Phone });
            if (result.Rows.Count > 0)
            {
                message.setMessage("Số điện thoại đã tồn tại");
                message.setStatus(false);
                return message;
            }

            query = "exec dbo.signUp @email , @name , @phone , @password";
            string password = md5.GetHash(user.Password);
            result = DataProvider.Instance.ExecuteQuery(query, new object[] { user.Email, user.Name, user.Phone, password });
            message.setMessage("Đăng ký thành công");
            message.setStatus(true);
            return message;
        }

        public bool updateUserAddress(string email, string address) {
            string query = "exec dbo.updateUserAddress @email , @address";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { email, address });
            return true;
        }

        public bool updateUserInfo(string email, string name, string phone, string address)
        {
            string query = "exec dbo.updateUserInfo @email , @name , @phone , @address";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { email, name, phone, address });
            return true;
        }

        public bool sendOTP(string email,string otp)
        {
            string query = "exec dbo.checkEmail @email";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { email });
            if (result.Rows.Count == 0)
            {
                return false;
            }
            string query1 = "exec dbo.sendOTP @email , @otp";
            DataTable data = DataProvider.Instance.ExecuteQuery(query1, new object[] { email,otp });
            return true;
        }

        public bool checkOTP(string email,string otp)
        {
            string query = "exec dbo.checkOTP @email , @otp";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { email, otp });
            if (data.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        
        
    }
}
