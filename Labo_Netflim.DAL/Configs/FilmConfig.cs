using Labo_Netflim.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Labo_Netflim.DAL.Configs
{
    internal class FilmConfig : IEntityTypeConfiguration<FilmEntity>
    {
        public void Configure(EntityTypeBuilder<FilmEntity> builder)
        {
            builder.ToTable("Film");

            builder.HasKey(p => p.FilmId)
                   .HasName("PK_Film");

            builder.Property(p => p.FilmId)
                   .ValueGeneratedOnAdd();

            builder.Property(p => p.ImageUrl)
                   .IsRequired();

            builder.Property(t => t.Titre)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(p => p.Annee)
                .IsRequired();

            builder.Property(s => s.Synopsis)
                   .HasMaxLength(550)
                   .IsRequired();
                    
        }
    }
}
