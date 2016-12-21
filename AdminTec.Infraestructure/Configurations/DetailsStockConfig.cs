using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AdminTec.Infraestructure.Configurations
{
    public class DetailsStockConfig : EntityTypeConfiguration<Domain.Entities.DetailStock>
    {
        public DetailsStockConfig()
        {
            ToTable("DetailsStock");

            HasKey(ds => ds.Id);

            Property(ds => ds.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("Id");

            Property(ds => ds.StockId)
                .IsRequired();

            Property(ds => ds.IsSoftDelete)
                .IsRequired();

            Property(ds => ds.RowVersion)
                .IsRowVersion();

            Property(ds => ds.CreatedAt)
                .HasColumnType("datetime2");

            Property(ds => ds.LastModified)
                .HasColumnType("datetime2");
        }
    }
}