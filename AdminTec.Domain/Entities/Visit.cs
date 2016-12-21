using System;
using System.Collections.Generic;

namespace AdminTec.Domain.Entities
{
    public class Visit
    {
        #region Propiedades

        public int Id { get; set; }
        public Enums.VisitType VisitType { get; set; }

        public int EquipmentId { get; set; }
        public int TechnicianId { get; set; }

        #endregion Propiedades

        #region Propiedades Virtuales

        public virtual Equipment Equipment { get; set; }
        public virtual Technician Technician { get; set; }
        public virtual ICollection<DetailsVisit> DetailsVisit { get; set; }

        #endregion Propiedades Virtuales

        #region Estado

        public bool IsSoftDelete { get; set; }
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