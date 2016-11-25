using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AdminTec.Infraestructure.Configurations
{
    public class PartConfig : EntityTypeConfiguration<Domain.Entities.Part>
    {
        public PartConfig()
        {
            ToTable("Parts");

            HasKey(p => p.Id);

            Property(p => p.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("Id");

            Property(p => p.Code)
                .HasMaxLength(8)
                .IsRequired();

            Property(p => p.Name)
                .HasMaxLength(128)
                .IsRequired();

            Property(p => p.Description)
                .HasMaxLength(255)
                .IsRequired();

            Property(p => p.Target)
                .IsRequired();

            Property(e => e.RowVersion)
                .IsRowVersion();
        }
    }
}