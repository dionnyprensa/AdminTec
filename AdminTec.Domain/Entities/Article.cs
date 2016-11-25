using System;
using System.Collections.Generic;

namespace AdminTec.Domain.Entities
{
    public class Article
    {
        #region Propiedades

        public int Id { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }

        #endregion Propiedades

        #region Propiedades Virtuales

        public virtual ICollection<Equipment> Equipments { get; set; }
        public virtual ICollection<Toner> Toners { get; set; }
        public virtual ICollection<Part> Parts { get; set; }
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