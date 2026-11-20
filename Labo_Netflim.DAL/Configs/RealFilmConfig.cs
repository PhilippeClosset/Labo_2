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
        }
    }
}
