using System;
using System.Collections.Generic;

namespace AdminTec.Domain.Entities
{
    public class Toner
    {
        #region Propiedades

        public int TonerId { get; set; }
        public string Code { get; set; }
        public long Target { get; set; }
        public Enums.TonerType TonerType { get; set; }
        public int StockId { get; set; }
        public bool IsSoftDelete { get; set; }

        #endregion Propiedades

        public virtual ICollection<Equipment> RelatedEquipments { get; set; }
        public virtual ICollection<DetailsVisit> DetailsVisit { get; set; }
        public virtual Stock Stock { get; set; }

        #region Estado

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