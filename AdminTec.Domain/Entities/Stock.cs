using System;

namespace AdminTec.Domain.Entities
{
    public class Stock
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int Used { get; set; }
        public int ArticleId { get; set; }

        #region Propiedades Virtuales

        public virtual Article Article { get; set; }

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