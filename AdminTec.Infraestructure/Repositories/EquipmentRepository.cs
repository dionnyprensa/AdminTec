using AdminTec.Domain.Entities;
using AdminTec.Infraestructure.Context;

namespace AdminTec.Infraestructure.Repositories
{
    public class EquipmentRepository : TRepository<Equipment>
    {
        public EquipmentRepository(AdminTecContext context) : base(context)
        {
        }
    }
}