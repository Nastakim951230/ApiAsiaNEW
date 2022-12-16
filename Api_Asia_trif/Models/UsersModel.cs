using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api_Asia_trif.Models
{
    public class UsersModel
    {
        public UsersModel(Users users)
        {
            IdUser = users.IdUser;
            Nickname = users.Nickname;
            Login = users.Login;
            Password = users.Password;
            PhotoUsers = users.PhotoUsers;
            Role=(int)users.Role;
        }
        public int IdUser { get; set; }
        public string Nickname { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string PhotoUsers { get; set; }
        public int Role { get; set; }
    }
}