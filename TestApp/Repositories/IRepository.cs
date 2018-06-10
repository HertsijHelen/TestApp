using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace TestApp.Repositories
{
    public interface IRepository<T>:IDisposable
        where T : class
    {
        IEnumerable<T> GetAll();
        T Create(T item); 
        bool Update(int id,T item); 
        bool Delete(int id); 
    }
}
