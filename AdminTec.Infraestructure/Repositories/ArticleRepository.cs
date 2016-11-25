using AdminTec.Domain.Entities;
using AdminTec.Infraestructure.Context;

namespace AdminTec.Infraestructure.Repositories
{
    public class ArticleRepository : TRepository<Article>
    {
        public ArticleRepository(AdminTecContext context) : base(context)
        {
        }
    }
}