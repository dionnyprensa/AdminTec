using System;
using System.Collections.Generic;

namespace AdminTec.Domain.Entities
{
    public class Toner
    {
        #region Propiedades

        public int Id { get; set; }
        public string Code { get; set; }
        public long Target { get; set; }
        public Enums.TonerType TonerType { get; private set; }

        #endregion Propiedades

        public virtual ICollection<Equipment> RelatedEquipments { get; set; }

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