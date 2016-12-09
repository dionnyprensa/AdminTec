using AdminTec.Domain.Entities;
using AdminTec.Infraestructure.Context;

namespace AdminTec.Infraestructure.Repositories
{
    public class RequestRepository : TRepository<Request>
    {
        public RequestRepository(AdminTecContext context) : base(context)
        {
        }
    }
}