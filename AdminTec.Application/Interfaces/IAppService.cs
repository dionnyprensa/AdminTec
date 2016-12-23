using AdminTec.Application.Concrete;
using AdminTec.Domain.Interfaces;
using System.Collections.Generic;

namespace AdminTec.Application.Interfaces
{
    public interface IAppService<T> : IRepository<T>
    {
        bool isValid(T entity);
        IList<ErrorMessage> Errors(T entity);
    }
}