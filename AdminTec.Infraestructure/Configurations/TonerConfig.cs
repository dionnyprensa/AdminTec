using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AdminTec.Infraestructure.Configurations
{
    public class TonerConfig : EntityTypeConfiguration<Domain.Entities.Toner>
    {
        public TonerConfig()
        {
            ToTable("Toners");

            HasKey(t => t.TonerId);

            Property(t => t.TonerId)
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

            Property(v => v.CreatedAt)
                .HasColumnType("datetime2");

            Property(v => v.LastModified)
                .HasColumnType("datetime2");
        }
    }
}