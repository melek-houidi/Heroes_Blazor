﻿using Microsoft.EntityFrameworkCore;
using RepositoryCrud_Uow.Core.Interfaces;
using RepositoryCrud_Uow.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryCrud_Uow.Core
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _DbContext;
        private readonly DbSet<T> _DbSet;

        public GenericRepository(ApplicationDbContext context)
        {
            this._DbContext = context;
            this._DbSet = this._DbContext.Set<T>();
        }


        public IEnumerable<T> GetAll()
        {
            return this._DbSet.ToList();
        }

        public T GetById(int id)
        {
            return this._DbSet.Find(id);
        }

        public void Add(T entity)
        {
            this._DbSet.Add(entity);
        }

        public void Update(T entity)
        {
            this._DbSet.Attach(entity);
            this._DbContext.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            this._DbSet.Remove(entity);
        }
    }
}
