﻿using System;
using RecipeSocial.Domain.Entities.Template;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace RecipeSocial.Domain.Database
{
    public interface IRepository<T> where T: Base
    {
        T Get(long id);

        ICollection<T> GetAll();

        ICollection<T> Find(Expression<Func<T, bool>> predicate);

        void Add(T entity);

        void AddRange(IEnumerable<T> entities);

        void Remove(T entity);

        void RemoveRange(IEnumerable<T> entities);

        void SaveChanges();
    }
}
