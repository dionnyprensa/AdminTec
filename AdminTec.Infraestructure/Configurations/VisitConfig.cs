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
                .HasForeignKey(v => v.Technician);

            HasMany(v => v.DetailsVisit)
                .WithRequired(dv => dv.Visit)
                .HasForeignKey(v => v.VisitId)
                .WillCascadeOnDelete(true);

            Property(s => s.RowVersion)
                .IsRowVersion();
        }
    }
}