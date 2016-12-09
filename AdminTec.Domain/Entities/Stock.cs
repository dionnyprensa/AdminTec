using System;
using System.Collections.Generic;

namespace AdminTec.Domain.Entities
{
    public class Stock
    {
        public int Id { get; set; }
        public int QuantityInInStock { get; set; }
        public int QuantityUsed { get; set; }
        public int EquipmentId { get; set; }
        public int PartId { get; set; }
        public int TonerId { get; set; }

        #region Propiedades Virtuales

        public virtual Equipment Equipment { get; set; }
        public virtual Part Part { get; set; }
        public virtual Toner Toner { get; set; }
        public virtual ICollection<DetailStock> DetailsStock { get; set; }

        #endregion Propiedades Virtuales

        #region Estado

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