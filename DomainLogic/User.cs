using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLogic
{
    public class User
    {
        int id { get; set; }   
        string phoneNumber { get; set; }
        string name { get; set; }  
        enum Role 
        {
            User,
            Admin
        }
    }
}
