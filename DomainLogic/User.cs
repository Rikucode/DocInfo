using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLogic
{
    public class User
    {
        public int id { get; set; }
        public string phone_number { get; set; }
        public string login { get; set; }
        public string name { get; set; }
        public enum Role
        {
            User,
            Admin
        }
        public Role role { get; set; }
        public string password { get; set; }
    }
}
