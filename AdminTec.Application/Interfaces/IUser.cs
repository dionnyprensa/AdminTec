using AdminTec.Domain.Entities;
using AdminTec.Domain.Interfaces;

namespace AdminTec.Application.Interfaces
{
    public interface IUser : IRepository<User>, IAppService<User>
    {
    }
}