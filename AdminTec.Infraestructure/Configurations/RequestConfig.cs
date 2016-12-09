using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AdminTec.Infraestructure.Configurations
{
    public class RequestConfig : EntityTypeConfiguration<Domain.Entities.Request>
    {
        public RequestConfig()
        {
            ToTable("Requests");

            HasKey(r => r.Id);

            Property(r => r.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("Id");

            Property(r => r.Quantity)
                .IsRequired();

            Property(r => r.EmailTo)
                .IsRequired();

            Property(v => v.CreatedAt)
                .HasColumnType("datetime2");

            Property(v => v.LastModified)
                .HasColumnType("datetime2");
        }
    }
}