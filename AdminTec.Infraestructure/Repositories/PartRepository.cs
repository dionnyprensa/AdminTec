using AdminTec.Domain.Entities;
using AdminTec.Infraestructure.Context;

namespace AdminTec.Infraestructure.Repositories
{
    public class PartRepository : TRepository<Part>
    {
        public PartRepository(AdminTecContext context) : base(context)
        {
        }
    }
}