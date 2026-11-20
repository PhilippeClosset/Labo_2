using Labo_Netflim.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Labo_Netflim.DAL.Configs
{
    internal class GenreConfig : IEntityTypeConfiguration<GenreEntity>
    {
        public void Configure(EntityTypeBuilder<GenreEntity> builder)
        {
            builder.ToTable("Genre");

            builder.HasKey(p => p.GenreId)
                    .HasName("PK_Genre");

            builder.Property(p => p.GenreId)
                    .ValueGeneratedOnAdd();

            builder.Property(p => p.Nom)
                    .HasMaxLength(50)
                    .IsRequired();

            builder.HasIndex(i => i.Nom)
                    .IsUnique()
                    .HasDatabaseName("IDX_Genre_Nom");

                    
        }
    }
}
