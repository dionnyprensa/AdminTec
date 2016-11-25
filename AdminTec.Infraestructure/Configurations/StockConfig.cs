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

            Property(s => s.Quantity)
                .IsRequired();

            Property(s => s.Used)
                .IsRequired();

            HasRequired(s => s.Article)
                .WithRequiredPrincipal(a => a.Stock);

            Property(s => s.RowVersion)
                .IsRowVersion();
        }
    }
}