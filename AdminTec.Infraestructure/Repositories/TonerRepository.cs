using AdminTec.Domain.Entities;
using AdminTec.Infraestructure.Context;

namespace AdminTec.Infraestructure.Repositories
{
    public class TonerRepository : TRepository<Toner>
    {
        public TonerRepository(AdminTecContext context) : base(context)
        {
        }
    }
}