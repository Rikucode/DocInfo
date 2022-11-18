using System;
using System.Collections.Generic;
using DomainLogic;
using Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public static class UserModelToDomain
    {
        public static User? ToDomain(this UserModel model)
        {
            return new User
            {
                id = model.id,
                name = model.name,
                login = model.login,
                phone_number = model.phone_number,
                password = model.password,
                role = model.role == "Admin" ? User.Role.Admin : User.Role.User
            };
        }
    }
}
