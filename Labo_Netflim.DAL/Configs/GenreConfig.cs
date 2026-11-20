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

            builder.HasData([
     new GenreEntity { GenreId = 1,  Nom = "Action" },
    new GenreEntity { GenreId = 2,  Nom = "Science-fiction" },
    new GenreEntity { GenreId = 3,  Nom = "Drame" },
    new GenreEntity { GenreId = 4,  Nom = "Thriller" },
    new GenreEntity { GenreId = 5,  Nom = "Comédie" },
    new GenreEntity { GenreId = 6,  Nom = "Animation" },
    new GenreEntity { GenreId = 7,  Nom = "Aventure" },
    new GenreEntity { GenreId = 8,  Nom = "Crime" },
    new GenreEntity { GenreId = 9,  Nom = "Fantastique" },
    new GenreEntity { GenreId = 10, Nom = "Romance" },
]);

        }
    }
}
