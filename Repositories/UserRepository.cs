using DomainLogic.IRepositories;
using DomainLogic;
using Contexts;
using Models;
using Microsoft.EntityFrameworkCore;
using DomainLogic;

namespace Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserContext _context;

        public UserRepository (UserContext context)
        {
            _context = context;
        }

        public User? GetByLogin(string login)
        {
            var user = _context.Users.FirstOrDefault(u => u.login == login);
            return user?.ToDomain();
        }

        public User? Create(UserModel user)
        {
            _context.Users.Add(user);
            return user?.ToDomain();
        }

        public User? GetById(int id)
        {
            var user = _context.Users.FirstOrDefault(u => u.id == id);
            return user?.ToDomain();
        }

        public bool IsExist(User user)
        {
            var userI = _context.Users.FirstOrDefault(u => u.id == user.id);
            return userI is null ? false : true;
        }

        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    this._context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void InsertTest()
        {
            UserModel userModel = new UserModel();
            userModel.id = 1;
            userModel.name = "Артём";
            userModel.login = "Rikugou";
            userModel.phone_number = "88005553535";
            _context.Users.Add(userModel);
            _context.SaveChanges();
        }
    }
}