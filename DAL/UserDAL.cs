using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class UserDAL : DatabaseAccess
    {
        public String checkLogin(User user)
        {
            string userInfo = checkLoginDTO(user);
            return userInfo;
        }
    }
}
