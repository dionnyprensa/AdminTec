using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AdminTec.Infraestructure.Configurations
{
    public class VisitConfig : EntityTypeConfiguration<Domain.Entities.Visit>
    {
        public VisitConfig()
        {
            ToTable("Visits");

            HasKey(s => s.Id);

            Property(s => s.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("Id");

            HasRequired(v => v.Equipment)
                .WithMany(e => e.Visits)
                .HasForeignKey(v => v.EquipmentId);

            HasRequired(v => v.Technician)
                .WithMany(t => t.Visits)
                .HasForeignKey(v => v.TechnicianId);

            HasMany(v => v.DetailsVisit)
                .WithRequired(dv => dv.Visit)
                .HasForeignKey(v => v.VisitId);

            Property(v => v.RowVersion)
                .IsRowVersion();

            Property(v => v.CreatedAt)
                .HasColumnType("datetime2");

            Property(v => v.LastModified)
                .HasColumnType("datetime2");
        }
    }
}