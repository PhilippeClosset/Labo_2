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
        }
    }
}
