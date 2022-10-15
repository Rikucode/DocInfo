using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DomainLogic
{
    public class UserRepository: IDocRepository<User>
    {
        private UserContext db;

        public UserRepository()
        {
            this.db = new UserContext();
        }
        public User? GetByLogin(string login)
        {
            return db.Users.Find(login);
        }
        public User? GetById(int id)
        {
            return db.Users.Find(id);
        }
        public User Create(User user)
        {
            db.Users.Add(user);
            return user;
        }
        public bool IsExist(User user)
        {
            return db.Users.Find(user) is not null;
        }
        
        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if(!this.disposed)
            {
                if (disposing)
                {
                    this.db.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
