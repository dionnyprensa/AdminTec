using AdminTec.Application.Concrete;
using System.Collections.Generic;

namespace AdminTec.Application.Interfaces
{
    public interface IAppService<T> where T : class
    {
        bool isValid(T entity);

        IList<ErrorMessage> Errors(T entity);
    }
}