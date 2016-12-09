using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AdminTec.Infraestructure.Configurations
{
    public class DetailStockConfig : EntityTypeConfiguration<Domain.Entities.DetailStock>
    {
        public DetailStockConfig()
        {
            ToTable("DetailsStock");

            HasKey(e => e.Id);

            Property(e => e.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("Id");

            Property(ds => ds.StockId)
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