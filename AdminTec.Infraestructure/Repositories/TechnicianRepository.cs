using AdminTec.Domain.Entities;
using AdminTec.Infraestructure.Context;

namespace AdminTec.Infraestructure.Repositories
{
    public class TechnicianRepository : TRepository<Technician>
    {
        public TechnicianRepository(AdminTecContext context) : base(context)
        {
        }
    }
}