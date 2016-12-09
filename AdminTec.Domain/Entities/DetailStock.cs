using System;

namespace AdminTec.Domain.Entities
{
    public class DetailStock
    {
        #region Propiedades

        public int Id { get; set; }
        public int Quantity { get; set; }
        public DateTime DateOfEntry { get; set; }
        public int StockId { get; set; }

        #endregion Propiedades

        #region Propiedades Virtuales

        public virtual Stock Stock { get; set; }

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