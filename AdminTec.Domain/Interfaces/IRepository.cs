using System.Collections.Generic;

namespace AdminTec.Domain.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Create(T entity);

        void Update(T entity);

        void Delete(T entity);

        T Get(T entity);

        T GetById(int id);

        ICollection<T> ToList { get; }
    }
}