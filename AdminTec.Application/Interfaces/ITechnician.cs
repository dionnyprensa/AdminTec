using AdminTec.Domain.Entities;
using AdminTec.Domain.Interfaces;

namespace AdminTec.Application.Interfaces
{
    public interface ITechnician : IRepository<Technician>, IAppService<Technician>
    {
    }
}