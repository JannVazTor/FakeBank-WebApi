using System;
using System.Collections.Generic;
using System.Linq;
using FakeBank.Data.Entities;
using System.Text;
using System.Threading.Tasks;

namespace FakeBank.Data.Business
{
    public class GenericMethods<T> : IGenericRepository<T> where T:class
    {
        public T Create(T obj)
        {
            using (var context = new FAKE_BANKEntities())
            {
                var result = context.Set<T>().Add(obj);
                context.SaveChanges();

                return result;
            }
        }
        public void Remove(T entity)
        {

            using (var context = new FAKE_BANKEntities())
            {
                context.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }

        }
        public void Update(T entity)
        {

            using (var context = new FAKE_BANKEntities())
            {
                context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }

        }
        public T GetById(object id)
        {

            using (var context = new FAKE_BANKEntities())
            {
                var result = context.Set<T>().Find(id);
                return result;
            }
        }

        public List<T> GetAll()
        {
            using (var context = new FAKE_BANKEntities())
            {
                var result = context.Set<T>().ToList();
                return result;
            }
        }
    }
}
