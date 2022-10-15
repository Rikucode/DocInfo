using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLogic
{
    public interface IDocRepository<T> : IDisposable
        where T : class
    {
        T? GetByLogin(string login);
        T? GetById(int id);
        T Create(T item);
        bool IsExist(T item);
        
    }
}
