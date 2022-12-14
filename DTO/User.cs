using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class User
    {


        private int userId;
        private string email;
        private string name;
        private string password;
        private string phone;
        private DateTime birthday;
        private string address;
        private DateTime dateExpire;
        private int roleId;

        public User(DataRow row)
        {
            this.UserId = (int)row["userId"];
            this.Email = row["email"].ToString();
            this.Name = row["name"].ToString();
            this.Password = row["password"].ToString();
            this.Phone = row["phone"].ToString();
            this.Address = row["address"].ToString();
            this.roleId = (int)row["roleId"];
        }

        public User() { }

        public int UserId { get => userId; set => userId = value; }
        public string Email { get => email; set => email = value; }
        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
        public string Phone { get => phone; set => phone = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
        public string Address { get => address; set => address = value; }
        public DateTime DateExpire { get => dateExpire; set => dateExpire = value; }
        public int RoleId { get => roleId; set => roleId = value; }
    }
}
