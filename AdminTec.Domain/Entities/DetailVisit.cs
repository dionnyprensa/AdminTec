using System.Collections.Generic;

namespace AdminTec.Domain.Entities
{
    public class DetailVisit
    {
        public string Comments { get; set; }
        public IEnumerable<Part> Parts { get; set; }
        public Toner Toner { get; private set; }

        public virtual Visit Visit { get; set; }
    }
}