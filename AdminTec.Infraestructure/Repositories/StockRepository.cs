using AdminTec.Domain.Entities;
using AdminTec.Infraestructure.Context;

namespace AdminTec.Infraestructure.Repositories
{
    public class StockRepository : TRepository<Stock>
    {
        public StockRepository(AdminTecContext context) : base(context)
        {
        }
    }
}