using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AdminTec.Infraestructure.Configurations
{
    public class StockConfig : EntityTypeConfiguration<Domain.Entities.Stock>
    {
        public StockConfig()
        {
            ToTable("Stocks");

            HasKey(s => s.Id);

            Property(s => s.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("Id");

            Property(s => s.QuantityInInStock)
                .IsRequired();

            Property(s => s.QuantityUsed)
                .IsRequired();

            Property(s => s.RowVersion)
                .IsRowVersion();

            HasMany(s => s.DetailsStock)
                .WithRequired(ds => ds.Stock)
                .HasForeignKey(ds => ds.StockId);

            HasOptional(s => s.Equipment)
                .WithOptionalPrincipal(e => e.Stock);

            HasOptional(s => s.Part)
                .WithOptionalPrincipal(p => p.Stock);

            HasOptional(s => s.Toner)
                .WithOptionalPrincipal(t => t.Stock);

            Property(v => v.CreatedAt)
                .HasColumnType("datetime2");

            Property(v => v.LastModified)
                .HasColumnType("datetime2");
        }
    }
}