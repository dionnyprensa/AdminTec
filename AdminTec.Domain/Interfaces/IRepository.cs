using System.Collections.Generic;

namespace AdminTec.Domain.Interfaces
{
    public interface IRepository<T>
    {
        void Add(T entity);

        void Update(T entity);

        void Remove(T entity);

        T Find(T entity);

        T FindById(int id);

        IEnumerable<T> ToList();
    }
}