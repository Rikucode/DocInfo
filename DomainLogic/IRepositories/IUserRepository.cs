using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DomainLogic.Contexts;
using DomainLogic.Models;

namespace DomainLogic.IRepositories
{
    public interface IUserRepository : IDisposable
    {
        public User? GetByLogin(string login);
        public User? GetById(int id);
        public User? Create(User user);
        public bool IsExist(User user);
    }
}
