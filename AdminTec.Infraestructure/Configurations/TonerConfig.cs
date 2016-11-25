using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AdminTec.Infraestructure.Configurations
{
    public class TonerConfig : EntityTypeConfiguration<Domain.Entities.Toner>
    {
        public TonerConfig()
        {
            ToTable("Toners");

            HasKey(t => t.Id);

            Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("Id");

            Property(t => t.Code)
                .IsRequired();

            Property(t => t.Target)
                .IsRequired();

            Property(e => e.IsSoftDelete)
                .IsRequired();

            Property(e => e.RowVersion)
                .IsRowVersion();
        }
    }
}