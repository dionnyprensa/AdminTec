using AdminTec.Domain.Entities;
using System.Data.Entity;

namespace AdminTec.Infraestructure.Context
{
    public class AdminTecContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<DetailVisit> DetailsVisit { get; set; }
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<Part> Part { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Technician> Technicians { get; set; }
        public DbSet<Toner> Toners { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Visit> Visits { get; set; }

        public AdminTecContext() : base("AdminTecMSSQL")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Configurations.Add(new FILEConfiguration());
        }
    }
}