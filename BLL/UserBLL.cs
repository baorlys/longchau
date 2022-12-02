using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class UserBLL
    {
        UserDAL userDAL = new UserDAL();

        public string checkLogin(User user)
        {
            if (user.email == "")
            {
                return "required email";
            }
            if (user.password == "")
            {
                return "required password";
            }
            string info = userDAL.checkLogin(user);
            return info;
        }
    }
}
