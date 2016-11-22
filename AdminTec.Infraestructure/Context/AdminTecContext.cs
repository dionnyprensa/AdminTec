using System.Data.Entity;

namespace AdminTec.Infraestructure.Context
{
    public class AdminTecContext : DbContext
    {
        public AdminTecContext() : base("ConnectionString")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Configurations.Add(new FILEConfiguration());
        }
    }
}