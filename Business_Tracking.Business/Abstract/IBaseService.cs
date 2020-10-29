using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business_Tracking.Business.Abstract
{
    public interface IBaseService<T>
    {
        List<T> GetAll();

        List<T> GetAll(Expression<Func<T, bool>> expression);

        T GetByid(int id);

        T GetOne(Expression<Func<T, bool>> expression);

        void Add(T entity);

        void Delete(T entity);

        void Update(T entity);

    }
}
