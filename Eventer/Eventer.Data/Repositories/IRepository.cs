﻿namespace Eventer.Data.Repositories
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;
    public interface IRepository<T>
    {
        IQueryable<T> All();
        IQueryable<T> Find(Expression<Func<T, bool>> expression);
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);
        void Delete(object id);
        int SaveChanges();
    }
}
