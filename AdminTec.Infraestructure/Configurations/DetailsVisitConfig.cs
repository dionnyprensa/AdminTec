using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AdminTec.Infraestructure.Configurations
{
    internal class DetailsVisitConfig : EntityTypeConfiguration<Domain.Entities.DetailsVisit>
    {
        public DetailsVisitConfig()
        {
            ToTable("DetailsVisit");

            HasKey(dv => dv.Id);

            Property(dv => dv.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("Id");

            Property(dv => dv.Comments)
                .HasMaxLength(255)
                .IsRequired();

            Property(dv => dv.VisitId)
                .IsRequired();

            HasMany(dv => dv.Toners)
                .WithMany(dv => dv.DetailsVisit)
                .Map(dvt =>
                {
                    dvt.ToTable("DetailsVisitToner");
                    dvt.MapLeftKey("DetailsVisitId");
                    dvt.MapRightKey("TonerId");
                });

            HasMany(dv => dv.Parts)
                .WithMany(dv => dv.DetailsVisit)
                .Map(dvp =>
                 {
                     dvp.ToTable("DetailsVisitPart");
                     dvp.MapLeftKey("DetailsVisitId");
                     dvp.MapRightKey("PartId");
                 });

            Property(dv => dv.LastModified)
                .HasColumnType("datetime2");
        }
    }
}