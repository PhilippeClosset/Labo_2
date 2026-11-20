using Labo_Netflim.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Labo_Netflim.DAL.Configs
{
    internal class GenreFilmConfig : IEntityTypeConfiguration<GenreFilmEntity>
    {
        public void Configure(EntityTypeBuilder<GenreFilmEntity> builder)
        {
            builder.ToTable("Genre_Film");

            builder.HasKey(gf => new { gf.FilmId, gf.GenreId })
                    .HasName("PK_Genre_Film");

            builder.HasOne(gf => gf.Film)
                    .WithMany(f => f.Genres)
                    .HasForeignKey(gf => gf.FilmId)
                    .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(gf => gf.Genre)
                    .WithMany(g => g.Films)
                    .HasForeignKey(gf => gf.GenreId)
                    .OnDelete(DeleteBehavior.Cascade);

            builder.HasData([
    new GenreFilmEntity { FilmId = 1, GenreId = 1 }, new GenreFilmEntity { FilmId = 1, GenreId = 2 },
    new GenreFilmEntity { FilmId = 2, GenreId = 1 }, new GenreFilmEntity { FilmId = 2, GenreId = 2 }, new GenreFilmEntity { FilmId = 2, GenreId = 4 },
    new GenreFilmEntity { FilmId = 3, GenreId = 2 }, new GenreFilmEntity { FilmId = 3, GenreId = 3 }, new GenreFilmEntity { FilmId = 3, GenreId = 7 },
    new GenreFilmEntity { FilmId = 4, GenreId = 8 }, new GenreFilmEntity { FilmId = 4, GenreId = 4 },
    new GenreFilmEntity { FilmId = 5, GenreId = 5 }, new GenreFilmEntity { FilmId = 5, GenreId = 10 },
    new GenreFilmEntity { FilmId = 6, GenreId = 6 }, new GenreFilmEntity { FilmId = 6, GenreId = 9 }, new GenreFilmEntity { FilmId = 6, GenreId = 7 },
    new GenreFilmEntity { FilmId = 7, GenreId = 3 }, new GenreFilmEntity { FilmId = 7, GenreId = 8 },
    new GenreFilmEntity { FilmId = 8, GenreId = 1 }, new GenreFilmEntity { FilmId = 8, GenreId = 2 }, new GenreFilmEntity { FilmId = 8, GenreId = 7 },
]);

        }
    }
}
