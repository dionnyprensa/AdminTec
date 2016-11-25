using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AdminTec.Infraestructure.Configurations
{
    public class EquipmentConfig : EntityTypeConfiguration<Domain.Entities.Equipment>
    {
        public EquipmentConfig()
        {
            ToTable("Equipments");

            HasKey(e => e.Id);

            Property(e => e.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("Id");

            Property(e => e.SerialNumber)
                .IsRequired();

            Property(e => e.Model)
                .IsRequired();

            Property(e => e.Location)
                .IsRequired();

            Property(e => e.IP)
                .IsRequired();

            Property(e => e.CounterBnWCopies)
                .IsRequired();

            Property(e => e.CounterBnWPrints)
                .IsRequired();

            Property(e => e.CounterColorCopies)
                .IsRequired();

            Property(e => e.CounterColorPrints)
                .IsRequired();

            Property(e => e.IsSoftDelete)
                .IsRequired();

            Property(e => e.RowVersion)
                .IsRowVersion();

            HasMany(e => e.Parts)
                .WithMany(p => p.RelatedEquipments)
                .Map(ep =>
                {
                    ep.ToTable("EquipmentsParts");
                    ep.MapLeftKey("EquipmentId");
                    ep.MapRightKey("PartId");
                });

            HasMany(e => e.Toners)
                .WithMany(p => p.RelatedEquipments)
                .Map(ep =>
                {
                    ep.ToTable("EquipmentsToners");
                    ep.MapLeftKey("EquipmentId");
                    ep.MapRightKey("TonerId");
                });

            HasMany(e => e.Visits)
                .WithRequired(v => v.Equipment)
                .HasForeignKey(v => v.EquipmentId);
        }
    }
}