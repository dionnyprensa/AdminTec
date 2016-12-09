using AdminTec.Domain.Entities;
using AdminTec.Domain.Interfaces;

namespace AdminTec.Application.Interfaces
{
    public interface IToner : IRepository<Toner>, IAppService<Toner>
    {
    }
}