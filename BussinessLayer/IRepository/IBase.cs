using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BussinessLayer.IRepository
{
    public interface IBase<T> where T : class
    {
        void Save(T model);

        void Remove(T model);

        List<T> Find(Expression<Func<T, bool>> predicate);

        List<T> FindAll();
    }
}