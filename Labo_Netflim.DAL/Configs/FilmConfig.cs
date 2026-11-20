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
                   .HasMaxLength(255)
                   .IsRequired();

            builder.Property(t => t.Titre)
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(p => p.Annee)
                .IsRequired();

            builder.Property(s => s.Synopsis)
                   .HasMaxLength(550)
                   .IsRequired();

            builder.HasData([
    new FilmEntity { FilmId = 1, Titre = "Matrix", Annee = new DateOnly(1999, 3, 31),
        ImageUrl = "/images/films/matrix.jpg",
        Synopsis = "Le hacker Neo découvre que le monde qu'il connaît est une simulation créée par des machines, et rejoint la résistance menée par Morpheus." },
    new FilmEntity { FilmId = 2, Titre = "Inception", Annee = new DateOnly(2010, 7, 16),
        ImageUrl = "/images/films/inception.jpg",
        Synopsis = "Dom Cobb, voleur capable de s'infiltrer dans les rêves, reçoit une mission inverse : implanter une idée dans l'esprit d'un héritier." },
    new FilmEntity { FilmId = 3, Titre = "Interstellar", Annee = new DateOnly(2014, 11, 7),
        ImageUrl = "/images/films/interstellar.jpg",
        Synopsis = "Alors que la Terre se meurt, un ancien pilote rejoint une expédition qui traverse un trou de ver à la recherche d'une planète habitable." },
    new FilmEntity { FilmId = 4, Titre = "Pulp Fiction", Annee = new DateOnly(1994, 10, 14),
        ImageUrl = "/images/films/pulp-fiction.jpg",
        Synopsis = "Les destins de deux tueurs à gages, d'un boxeur, d'un gangster et de sa femme s'entrecroisent dans un Los Angeles violent et absurde." },
    new FilmEntity { FilmId = 5, Titre = "Le Fabuleux Destin d'Amélie Poulain", Annee = new DateOnly(2001, 4, 25),
        ImageUrl = "/images/films/amelie.jpg",
        Synopsis = "À Montmartre, une jeune serveuse timide décide de changer en secret la vie des gens qui l'entourent, au risque d'oublier la sienne." },
    new FilmEntity { FilmId = 6, Titre = "Le Voyage de Chihiro", Annee = new DateOnly(2001, 7, 20),
        ImageUrl = "/images/films/chihiro.jpg",
        Synopsis = "Piégée dans un monde peuplé d'esprits, la jeune Chihiro doit travailler dans un établissement de bains pour sauver ses parents changés en cochons." },
    new FilmEntity { FilmId = 7, Titre = "Gran Torino", Annee = new DateOnly(2008, 12, 12),
        ImageUrl = "/images/films/gran-torino.jpg",
        Synopsis = "Un vétéran de la guerre de Corée, veuf et aigri, se lie malgré lui avec ses jeunes voisins hmongs menacés par un gang." },
    new FilmEntity { FilmId = 8, Titre = "Mad Max: Fury Road", Annee = new DateOnly(2015, 5, 15),
        ImageUrl = "/images/films/mad-max-fury-road.jpg",
        Synopsis = "Dans un désert post-apocalyptique, Max et l'impératrice Furiosa fuient le tyran Immortan Joe à bord d'un camion de guerre." },
]);

        }
    }
}
