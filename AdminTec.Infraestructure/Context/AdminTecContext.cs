using AdminTec.Domain.Entities;
using AdminTec.Infraestructure.Configurations;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace AdminTec.Infraestructure.Context
{
    public class AdminTecContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Technician> Technicians { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Toner> Toners { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<DetailStock> DetailsStock { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Visit> Visits { get; set; }
        public DbSet<DetailsVisit> DetailsVisit { get; set; }

        public AdminTecContext() : base("AdminTecMSSQL")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<AdminTecContext>());
            Database.SetInitializer(new AdminTecInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new VisitConfig());
            modelBuilder.Configurations.Add(new EquipmentConfig());
            modelBuilder.Configurations.Add(new PartConfig());
            modelBuilder.Configurations.Add(new TonerConfig());
            modelBuilder.Configurations.Add(new TechnicianConfig());
            modelBuilder.Configurations.Add(new UserConfig());
            modelBuilder.Configurations.Add(new RequestConfig());
            modelBuilder.Configurations.Add(new StockConfig());
            modelBuilder.Configurations.Add(new DetailsStockConfig());
            modelBuilder.Configurations.Add(new DetailsVisitConfig());
        }
    }
}