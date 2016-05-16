using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeBank.Data.Business
{
    public interface IGenericRepository<T> where T:class
    {
        List<T> GetAll();
        void Remove(T entity);
        T Create(T entity);
        void Update(T entity);
    }
}
