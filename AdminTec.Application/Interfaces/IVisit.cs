using AdminTec.Domain.Entities;
using AdminTec.Domain.Interfaces;

namespace AdminTec.Application.Interfaces
{
    public interface IVisit : IRepository<Visit>, IAppService<Visit>
    {
    }
}