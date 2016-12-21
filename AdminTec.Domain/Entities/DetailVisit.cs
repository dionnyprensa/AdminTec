using System;
using System.Collections.Generic;

namespace AdminTec.Domain.Entities
{
    public class DetailsVisit
    {
        public int Id { get; set; }
        public string Comments { get; set; }
        public int VisitId { get; set; }

        public virtual ICollection<Part> Parts { get; set; }
        public virtual ICollection<Toner> Toners { get; set; }

        public virtual Visit Visit { get; set; }

        #region Auditoria
        
        public string ModifiedBy { get; set; }
        public DateTime LastModified { get; set; }

        #endregion Auditoria
    }
}