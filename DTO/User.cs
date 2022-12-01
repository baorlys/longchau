using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class User
    {
        public int userId { get; set; }
        public string email { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public string phone { get; set; }
        public DateTime birthday { get; set; }
        public string address { get; set; }
        public string dataExpire { get; set; }
        public int roleId { get; set; }


    }
}
