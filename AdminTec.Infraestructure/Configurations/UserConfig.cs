using System.Data.Entity.ModelConfiguration;

namespace AdminTec.Infraestructure.Configurations
{
    public class UserConfig : EntityTypeConfiguration<Domain.Entities.User>
    {
        public UserConfig()
        {
            HasKey(u => u.Id);

            Property(u => u.UserName)
                .HasMaxLength(16)
                .IsRequired();

            Property(u => u.FirstName)
                .HasMaxLength(254)
                .IsRequired();

            Property(u => u.LastName)
                .HasMaxLength(32)
                .IsRequired();

            Property(u => u.Password)
                .HasMaxLength(16)
                .IsRequired();

            Property(u => u.RememberMe)
                .IsRequired();

            Property(u => u.IsSoftDelete)
                .IsRequired();

            Property(u => u.RowVersion)
                .IsRowVersion();

            Property(v => v.CreatedAt)
                .HasColumnType("datetime2");

            Property(v => v.LastModified)
                .HasColumnType("datetime2");
        }
    }
}