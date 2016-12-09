using AdminTec.Domain.Entities;
using AdminTec.Domain.Interfaces;

namespace AdminTec.Application.Interfaces
{
    public interface IEquipment : IRepository<Equipment>, IAppService<Equipment>
    {
    }
}