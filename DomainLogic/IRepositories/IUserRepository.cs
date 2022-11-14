using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DomainLogic.IRepositories
{
    public interface IUserRepository : IDisposable
    {
        public User? GetByLogin(string login);
        public User? GetById(int id);
        public User? Create(UserModel user);
        public bool IsExist(User user);
    }
}
