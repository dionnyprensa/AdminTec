using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AdminTec.Domain.Entities
{
    public class User
    {
        #region Propiedades
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool RememberMe { get; set; }
        public bool IsSoftDelete { get; set; }
        public string FullName { get { return string.Format("{0} {1}", FirstName, LastName); } }

        #endregion Propiedades

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