using Labo_Netflim.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Labo_Netflim.DAL.Configs
{
    internal class RealFilmConfig : IEntityTypeConfiguration<RealFilmEntity>
    {
        public void Configure(EntityTypeBuilder<RealFilmEntity> builder)
        {
            builder.ToTable("Realisateur_Film");

            builder.HasKey(pf => new { pf.FilmId, pf.PersonneId })
                    .HasName("PK_Realisateur_Film");

            builder.HasOne(rf => rf.Film)
                    .WithMany(f => f.Realisateurs)
                    .HasForeignKey(rf => rf.FilmId)
                    .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(rf => rf.Realisateur)
                .WithMany(p => p.Realise)
                .HasForeignKey(rf => rf.PersonneId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData([
    new RealFilmEntity { FilmId = 1, PersonneId = 1 },
    new RealFilmEntity { FilmId = 1, PersonneId = 2 },
    new RealFilmEntity { FilmId = 2, PersonneId = 6 },
    new RealFilmEntity { FilmId = 3, PersonneId = 6 },
    new RealFilmEntity { FilmId = 4, PersonneId = 14 },
    new RealFilmEntity { FilmId = 5, PersonneId = 19 },
    new RealFilmEntity { FilmId = 6, PersonneId = 22 },
    new RealFilmEntity { FilmId = 7, PersonneId = 25 },
    new RealFilmEntity { FilmId = 8, PersonneId = 27 },
]);


        }
    }
}
