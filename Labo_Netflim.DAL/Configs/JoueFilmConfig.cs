using Labo_Netflim.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Labo_Netflim.DAL.Configs
{
    internal class JoueFilmConfig : IEntityTypeConfiguration<JoueFilmEntity>
    {
        public void Configure(EntityTypeBuilder<JoueFilmEntity> builder)
        {
            builder.ToTable("Acteur_Film");

            builder.HasKey(pf => new { pf.FilmId, pf.PersonneId })
                    .HasName("PK_Acteur_Film");

            builder.HasOne(jf => jf.Film)
                    .WithMany(f => f.Acteurs)
                    .HasForeignKey(jf => jf.FilmId)
                    .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(jf => jf.Acteur)
                    .WithMany(p => p.Joue)
                    .HasForeignKey(jf => jf.PersonneId)
                    .OnDelete(DeleteBehavior.Cascade);
            builder.HasData([
    new JoueFilmEntity { FilmId = 1, PersonneId = 3 },  new JoueFilmEntity { FilmId = 1, PersonneId = 4 },  new JoueFilmEntity { FilmId = 1, PersonneId = 5 },
    new JoueFilmEntity { FilmId = 2, PersonneId = 7 },  new JoueFilmEntity { FilmId = 2, PersonneId = 8 },  new JoueFilmEntity { FilmId = 2, PersonneId = 9 },  new JoueFilmEntity { FilmId = 2, PersonneId = 10 },
    new JoueFilmEntity { FilmId = 3, PersonneId = 11 }, new JoueFilmEntity { FilmId = 3, PersonneId = 12 }, new JoueFilmEntity { FilmId = 3, PersonneId = 13 },
    new JoueFilmEntity { FilmId = 4, PersonneId = 14 }, new JoueFilmEntity { FilmId = 4, PersonneId = 15 }, new JoueFilmEntity { FilmId = 4, PersonneId = 16 }, new JoueFilmEntity { FilmId = 4, PersonneId = 17 }, new JoueFilmEntity { FilmId = 4, PersonneId = 18 },
    new JoueFilmEntity { FilmId = 5, PersonneId = 20 }, new JoueFilmEntity { FilmId = 5, PersonneId = 21 },
    new JoueFilmEntity { FilmId = 6, PersonneId = 23 }, new JoueFilmEntity { FilmId = 6, PersonneId = 24 },
    new JoueFilmEntity { FilmId = 7, PersonneId = 25 }, new JoueFilmEntity { FilmId = 7, PersonneId = 26 },
    new JoueFilmEntity { FilmId = 8, PersonneId = 10 }, new JoueFilmEntity { FilmId = 8, PersonneId = 28 },
]);

        }
    }
}
