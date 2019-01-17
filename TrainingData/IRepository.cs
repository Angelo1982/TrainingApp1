using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;

namespace TrainingData
{
    public interface IRepository<T>
                    where T : NotifyModel
    {
        void Add(T newEntity);
        void Remove(T entity);
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        T FindById(int id);
        IEnumerable<T> FindAll();
    }
}
