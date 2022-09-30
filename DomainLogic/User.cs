using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLogic
{
    internal class User
    {
        int id;
        string phoneNumber;
        string name;
        enum Role
        {
            User,
            Admin
        };
    }
}
