using System;

namespace AdminTec.Domain.Entities
{
    public class Request
    {
        #region Propiedades

        public int Id { get; set; }
        public int Quantity { get; set; }
        public string EmailTo { get; set; }

        #endregion Propiedades

        #region Propiedades Virtuales

        //public virtual T Entity { get; set; }

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