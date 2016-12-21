using System;
using System.Collections.Generic;

namespace AdminTec.Domain.Entities
{
    public class Part
    {
        #region Propiedades

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long Target { get; set; }
        public int StockId { get; set; }

        #endregion Propiedades

        #region Propiedades Virtuales

        public virtual ICollection<Equipment> Equipments { get; set; }
        public virtual ICollection<DetailsVisit> DetailsVisit { get; set; }
        public virtual Stock Stock { get; set; }

        #endregion Propiedades Virtuales

        #region Estado

        public bool IsSoftDelete { get; set; }
        public bool IsActive { get; set; }
        public byte[] RowVersion { get; set; }

        #endregion Estado

        #region Auditoria

        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime LastModified { get; set; }

        #endregion Auditoria
    }
}