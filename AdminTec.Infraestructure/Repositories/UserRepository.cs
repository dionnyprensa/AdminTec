using AdminTec.Domain.Entities;
using AdminTec.Infraestructure.Context;

namespace AdminTec.Infraestructure.Repositories
{
    public class UserRepository : TRepository<User>
    {
        public UserRepository(AdminTecContext context) : base(context)
        {
        }
    }
}