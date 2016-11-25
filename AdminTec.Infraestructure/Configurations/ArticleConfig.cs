using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AdminTec.Infraestructure.Configurations
{
    public class ArticleConfig : EntityTypeConfiguration<Domain.Entities.Article>
    {
        public ArticleConfig()
        {
            ToTable("Articles");

            HasKey(a => a.Id);

            Property(a => a.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("Id");

            Property(a => a.Quantity)
                .IsRequired();

            Property(a => a.Date)
                .IsRequired();

            HasMany(a => a.Equipments)
                .WithRequired(e => e.Article)
                .HasForeignKey(e => e.ArticleId);

            HasMany(a => a.Parts)
                .WithRequired(p => p.Article)
                .HasForeignKey(p => p.ArticleId);

            HasMany(a => a.Toners)
                .WithRequired(t => t.Article)
                .HasForeignKey(t => t.ArticleId);
        }
    }
}