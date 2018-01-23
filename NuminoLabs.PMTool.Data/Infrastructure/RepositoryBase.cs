using Microsoft.EntityFrameworkCore;
using NuminoLabs.PMTool.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using NuminoLabs.PMTool.Model.Base;

namespace NuminoLabs.PMTool.Data.Infrastructure
{
    public class RepositoryBase<T> : IRepository<T> where T : BaseEntity
    {
        private readonly PMToolDbContext context;
        private DbSet<T> entities;
        string errorMessage = string.Empty;
        public RepositoryBase(PMToolDbContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }
        public T Get(int id)
        {
            return entities.SingleOrDefault(s => s.Id == id);
        }
        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            context.SaveChanges();
        }
        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Update(entity);
            context.SaveChanges();
        }
        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            context.SaveChanges();
        }
    }

    //public abstract class RepositoryBase<T> where T : class
    //{
    //    #region Properties
    //    private PMToolDbContext dataContext;
    //    private readonly DbSet<T> dbSet;

    //    protected IDbFactory DbFactory
    //    {
    //        get;
    //        private set;
    //    }

    //    protected PMToolDbContext DbContext
    //    {
    //        get { return dataContext ?? (dataContext = DbFactory.Init()); }
    //    }
    //    #endregion

    //    protected RepositoryBase(IDbFactory dbFactory)
    //    {
    //        DbFactory = dbFactory;
    //        dbSet = DbContext.Set<T>();
    //    }

    //    #region Implementation
    //    public virtual void Add(T entity)
    //    {
    //        dbSet.Add(entity);
    //    }

    //    public virtual void Update(T entity)
    //    {
    //        dbSet.Attach(entity);
    //        dataContext.Entry(entity).State = EntityState.Modified;
    //    }

    //    public virtual void Delete(T entity)
    //    {
    //        dbSet.Remove(entity);
    //    }

    //    public virtual void Delete(Expression<Func<T, bool>> where)
    //    {
    //        IEnumerable<T> objects = dbSet.Where<T>(where).AsEnumerable();
    //        foreach (T obj in objects)
    //            dbSet.Remove(obj);
    //    }

    //    //public virtual T GetById(int id)
    //    //{
    //    //    return dbSet.where.Find(id);
    //    //}

    //    public virtual IEnumerable<T> GetAll()
    //    {
    //        return dbSet.ToList();
    //    }

    //    public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> where)
    //    {
    //        return dbSet.Where(where).ToList();
    //    }

    //    public T Get(Expression<Func<T, bool>> where)
    //    {
    //        return dbSet.Where(where).FirstOrDefault<T>();
    //    }

    //    #endregion

    //}
}
