using System;
using System.Collections.Generic;

namespace AdminTec.Domain.Entities
{
    public class Equipment : Interfaces.IMachine
    {
        #region Propiedades

        public int Id { get; set; }
        public string SerialNumber { get; set; }
        public Enums.MachineType TypeMachine { get; private set; }
        public string Model { get; set; }
        public string Location { get; set; }
        public string IP { get; set; }
        public long CounterBnWCopies { get; set; }
        public long CounterBnWPrints { get; set; }
        public long CounterColorCopies { get; set; }
        public long CounterColorPrints { get; set; }
        public bool IsSoftDelete { get; set; }
        public int ArticleId { get; set; }

        #endregion Propiedades

        #region Propiedades Virtuales

        public virtual ICollection<Part> Parts { get; set; }
        public virtual ICollection<Toner> Toners { get; set; }
        public virtual ICollection<Visit> Visits { get; set; }
        public virtual Article Article { get; set; }

        #endregion Propiedades Virtuales

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