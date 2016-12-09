using AdminTec.Domain.Entities;
using AdminTec.Domain.Interfaces;

namespace AdminTec.Application.Interfaces
{
    public interface IPart : IRepository<Part>, IAppService<Part>
    {
    }
}
