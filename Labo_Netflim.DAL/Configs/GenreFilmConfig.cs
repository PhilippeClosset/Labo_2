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
                    
        }
    }
}
