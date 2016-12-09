using AdminTec.Domain.Entities;
using AdminTec.Domain.Interfaces;

namespace AdminTec.Application.Interfaces
{
    public interface IRequest : IRepository<Request>, IAppService<Request>
    {
    }
}