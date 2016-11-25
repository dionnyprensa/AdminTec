using System.Collections.Generic;

namespace AdminTec.Domain.Entities
{
    public class DetailVisit
    {
        public string Comments { get; set; }
        public int VisitId { get; set; }

        public virtual ICollection<Part> Parts { get; set; }
        public virtual ICollection<Toner> Toners { get; private set; }

        public virtual Visit Visit { get; set; }
    }
}