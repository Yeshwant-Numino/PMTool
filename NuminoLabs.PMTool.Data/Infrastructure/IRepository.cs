﻿using NuminoLabs.PMTool.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace NuminoLabs.PMTool.Data.Infrastructure
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
    //public interface IRepository<T> where T : class
    //{
    //    // Marks an entity as new
    //    void Add(T entity);
    //    // Marks an entity as modified
    //    void Update(T entity);
    //    // Marks an entity to be removed
    //    void Delete(T entity);
    //    void Delete(Expression<Func<T, bool>> where);
    //    // Get an entity by int id
    //    //T GetById(int id);
    //    // Get an entity using delegate
    //    T Get(Expression<Func<T, bool>> where);
    //    // Gets all entities of type T
    //    IEnumerable<T> GetAll();
    //    // Gets entities using delegate
    //    IEnumerable<T> GetMany(Expression<Func<T, bool>> where);
    //}
}
