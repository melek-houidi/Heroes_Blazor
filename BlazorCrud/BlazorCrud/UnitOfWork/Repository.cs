using BlazorCrud.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCrud.UnitOfWork
{
    public class Repository<T> : IRepository<T> where T : Student
    {
        private readonly AppDbContext _appDbContext;
        private DbSet<T> entities;
        public Repository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            entities = _appDbContext.Set<T>();
        }
        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            _appDbContext.SaveChanges();
        }

        public List<T> GetAll()
        {
            return entities.ToList();
        }

        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            _appDbContext.SaveChanges();
        }

        public void Remove(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
        }

        public void SaveChanges()
        {
            _appDbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Update(entity);
            _appDbContext.SaveChanges();
        }
    }
}
