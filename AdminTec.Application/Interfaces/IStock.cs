using AdminTec.Domain.Entities;
using AdminTec.Domain.Interfaces;

namespace AdminTec.Application.Interfaces
{
    public interface IStock : IRepository<Stock>, IAppService<Stock>
    {
    }
}