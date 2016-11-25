using AdminTec.Domain.Interfaces;
using AdminTec.Infraestructure.Context;
using System.Collections.Generic;
using System.Data.Entity;

namespace AdminTec.Infraestructure.Repositories
{
    public class TRepository<T> : IRepository<T> where T : class
    {
        private readonly AdminTecContext _context;

        public TRepository(AdminTecContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public T Find(T entity)
        {
            return _context.Set<T>().Find(entity);
        }

        public T FindById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public IEnumerable<T> ToList
        {
            get
            {
                return _context.Set<T>();
            }
        }

        public void SaveAll()
        {
            _context.SaveChanges();
        }
    }
}