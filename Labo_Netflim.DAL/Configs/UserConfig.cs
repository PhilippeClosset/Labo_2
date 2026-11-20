using Labo_Netflim.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Labo_Netflim.DAL.Configs
{
    internal class UserConfig : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.ToTable("User", t=>
                    t.HasCheckConstraint("CK_User_Role", "[Role] IN ('User', 'Admin')"));

            builder.HasKey(p => p.UserId)
                    .HasName("PK_User");

            builder.Property(p => p.UserId)
                    .ValueGeneratedOnAdd();

            builder.Property(p => p.FirstName)
                    .HasColumnName("Prenom")
                    .HasMaxLength(22)
                    .IsRequired();

            builder.Property(p => p.LastName)
                    .HasColumnName("Nom")
                    .HasMaxLength(35)
                    .IsRequired();

            builder.Property(p => p.Role)
                    .IsRequired()
                    .HasMaxLength(10);

            builder.Property(p => p.Email)
                    .HasMaxLength(60)
                    .IsRequired();

            builder.HasIndex(i => i.Email)
                    .IsUnique()
                    .HasDatabaseName("IDX_User_Email");
                    

            builder.Property(p => p.Pseudo)
                    .HasMaxLength(15)
                    .IsRequired();

            builder.HasIndex(i => i.Pseudo)
                    .IsUnique()
                    .HasDatabaseName("IDX_User_Pseudo");

            builder.Property(p => p.PasswordHash)
                    .IsRequired();
        }
    }
}
