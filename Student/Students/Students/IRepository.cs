using Students.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Students
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetData();
        TEntity GetDataByID(int id);
        TEntity AddData(TEntity entity);
        TEntity UpdateData(TEntity entity1, TEntity entity);
        TEntity DeleteData(int id);
    }
    public class Repository<T> : IRepository<T> where T : class
    {
        public StudentsContext context { get; set; }
        public Repository(StudentsContext studentcontext)
        {
            context = studentcontext;
        }

        public IEnumerable<T> GetData()
        {
            return context.Set<T>().ToList();
        }

        public T GetDataByID(int id)
        {
            return context.Set<T>().Find(id);
        }

        public T AddData(T entity)
        {
            context.Add(entity);
            context.SaveChanges();
            return entity;
        }

        public T UpdateData(T entity1, T entity)
        {
            context.Entry<T>(entity1).CurrentValues.SetValues(entity);
            context.SaveChanges();
            return entity;
        }

        public T DeleteData(int id)
        {
            var did = context.Set<T>().Find(id);
            context.Remove<T>(did);
            context.SaveChanges();
            return did;
        }
    }
}
