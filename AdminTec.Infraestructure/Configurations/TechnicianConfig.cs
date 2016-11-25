using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AdminTec.Infraestructure.Configurations
{
    public class TechnicianConfig : EntityTypeConfiguration<Domain.Entities.Technician>
    {
        public TechnicianConfig()
        {
            ToTable("Technicians");

            HasKey(t => t.Id);

            Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("Id");

            Property(t => t.FirstName)
                .HasMaxLength(32)
                .IsRequired();

            Property(t => t.LastName)
                .HasMaxLength(32)
                .IsRequired();

            Property(t => t.IsSoftDelete)
                .IsRequired();

            Property(t => t.RowVersion)
                .IsRowVersion();

        }
    }
}
