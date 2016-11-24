using System.Collections.Generic;

namespace AdminTec.Domain.Entities
{
    public class Stock
    {
        public virtual ICollection<Article<Equipment>> Equipments { get; set; }
        public virtual ICollection<Article<Toner>> Toners { get; set; }
        public virtual ICollection<Article<Part>> Parts { get; set; }
    }
}