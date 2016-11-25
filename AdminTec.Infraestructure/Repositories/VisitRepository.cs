using AdminTec.Domain.Entities;
using AdminTec.Infraestructure.Context;

namespace AdminTec.Infraestructure.Repositories
{
    public class VisitRepository : TRepository<Visit>
    {
        public VisitRepository(AdminTecContext context) : base(context)
        {
        }
    }
}