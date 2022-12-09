﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using DAL;
using DTO;

namespace BLL
{
    public class UserBLL
    {

        public string checkLogin(User user)
        {
            if (user.Email == "")
            {
                return "required email";
            }
            if (user.Password == "")
            {
                return "required password";
            }
            if (UserDAL.Instance.checkLogin(user) == true) return "success";
            else return "invalid email/pass";
        }

        private bool isName(string val)
        {
            return Regex.IsMatch(val, @"^[A-Za-z\s]*$");
        }

        private bool isPhoneNumber(string phone)
        {
            return Regex.IsMatch(phone, @"(?<!\d)\d{10}(?!\d)");
        }

        private bool isEmail(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private MessageHandler validatePassword(string pass)
        {
            MessageHandler message = new MessageHandler("", true);
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum8Chars = new Regex(@".{8,}");
            if (!hasNumber.IsMatch(pass))
            {
                message.setMessage("Mật khẩu bao gồm ít nhất 1 chữ số");
                message.setStatus(false);
            }
            if (!hasUpperChar.IsMatch(pass))
            {
                message.setMessage("Mật khẩu bao gồm ít nhất 1 chữ hoa");
                message.setStatus(false);
            }
            if (!hasMinimum8Chars.IsMatch(pass))
            {
                message.setMessage("Mật khẩu bao gồm ít nhất 8 ký tự");
                message.setStatus(false);
            }
            return message;
        }

        public MessageHandler checkSignUp(User user,string confirmPassword)
        {
            MessageHandler message = new MessageHandler("", true);
            if (user.Name == "")
            {
                message.setMessage("Vui lòng nhập tên");
                message.setStatus(false);
                return message;
            }
            //if (!isName(user.Name))
            //{
            //    message.setMessage("Tên không hợp lệ");
            //    message.setStatus(false);
            //    return message;
            //}
            if (user.Phone == "")
            {
                message.setMessage("Vui lòng nhập số điện thoại");
                message.setStatus(false);
                return message;
            }
            //if (existPhone(phone))
            //{
            //    message.setMessage("Số điện thoại đã tồn tại");
            //    message.setStatus(false);
            //    return message;
            //}
            if (!isPhoneNumber(user.Phone))
            {
                message.setMessage("Số điện thoại không hợp lệ");
                message.setStatus(false);
                return message;
            }
            if (user.Email == "")
            {
                message.setMessage("Vui lòng nhập email");
                message.setStatus(false);
                return message;
            }
            if (!isEmail(user.Email))
            {
                message.setMessage("Email không hợp lệ");
                message.setStatus(false);
                return message;
            }
            if (user.Password == "")
            {
                message.setMessage("Vui lòng nhập mật khẩu");
                message.setStatus(false);
                return message;
            }

            MessageHandler validatePass = validatePassword(user.Password);
            if (!validatePass.getStatus())
            {
                message.setMessage(validatePass.getMessage());
                message.setStatus(false);
                return message;
            }
            if (confirmPassword == "")
            {
                message.setMessage("Vui lòng nhập lại xác nhận mật khẩu");
                message.setStatus(false);
                return message;
            }
            if (!user.Password.Equals(confirmPassword))
            {
                message.setMessage("Mật khẩu không khớp");
                message.setStatus(false);
                return message;
            }
            MessageHandler info = UserDAL.Instance.checkSignUp(user);
            return info;
        }
    }
}
