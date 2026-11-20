using Labo_Netflim.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Labo_Netflim.DAL.Configs 
{
    internal class PersonneConfig : IEntityTypeConfiguration<PersonneEntity>
    {
        public void Configure(EntityTypeBuilder<PersonneEntity> builder)
        {
            builder.ToTable("Personne");

            builder.HasKey(p => p.PersonneId)
                   .HasName("PK_Personne");

            builder.Property(p => p.PersonneId)
                    .ValueGeneratedOnAdd();

            builder.Property(p => p.Prenom)
                    .HasColumnName("Prenom")
                    .HasMaxLength(50)
                    .IsRequired();

            builder.Property(p => p.Nom)
                    .HasColumnName("Nom")
                    .HasMaxLength(50)
                    .IsRequired();
            builder.HasData([
    new PersonneEntity { PersonneId = 1,  Nom = "Wachowski",     Prenom = "Lana" },
    new PersonneEntity { PersonneId = 2,  Nom = "Wachowski",     Prenom = "Lilly" },
    new PersonneEntity { PersonneId = 3,  Nom = "Reeves",        Prenom = "Keanu" },
    new PersonneEntity { PersonneId = 4,  Nom = "Fishburne",     Prenom = "Laurence" },
    new PersonneEntity { PersonneId = 5,  Nom = "Moss",          Prenom = "Carrie-Anne" },
    new PersonneEntity { PersonneId = 6,  Nom = "Nolan",         Prenom = "Christopher" },
    new PersonneEntity { PersonneId = 7,  Nom = "DiCaprio",      Prenom = "Leonardo" },
    new PersonneEntity { PersonneId = 8,  Nom = "Gordon-Levitt", Prenom = "Joseph" },
    new PersonneEntity { PersonneId = 9,  Nom = "Page",          Prenom = "Elliot" },
    new PersonneEntity { PersonneId = 10, Nom = "Hardy",         Prenom = "Tom" },
    new PersonneEntity { PersonneId = 11, Nom = "McConaughey",   Prenom = "Matthew" },
    new PersonneEntity { PersonneId = 12, Nom = "Hathaway",      Prenom = "Anne" },
    new PersonneEntity { PersonneId = 13, Nom = "Chastain",      Prenom = "Jessica" },
    new PersonneEntity { PersonneId = 14, Nom = "Tarantino",     Prenom = "Quentin" },
    new PersonneEntity { PersonneId = 15, Nom = "Travolta",      Prenom = "John" },
    new PersonneEntity { PersonneId = 16, Nom = "Jackson",       Prenom = "Samuel L." },
    new PersonneEntity { PersonneId = 17, Nom = "Thurman",       Prenom = "Uma" },
    new PersonneEntity { PersonneId = 18, Nom = "Willis",        Prenom = "Bruce" },
    new PersonneEntity { PersonneId = 19, Nom = "Jeunet",        Prenom = "Jean-Pierre" },
    new PersonneEntity { PersonneId = 20, Nom = "Tautou",        Prenom = "Audrey" },
    new PersonneEntity { PersonneId = 21, Nom = "Kassovitz",     Prenom = "Mathieu" },
    new PersonneEntity { PersonneId = 22, Nom = "Miyazaki",      Prenom = "Hayao" },
    new PersonneEntity { PersonneId = 23, Nom = "Hiiragi",       Prenom = "Rumi" },
    new PersonneEntity { PersonneId = 24, Nom = "Irino",         Prenom = "Miyu" },
    new PersonneEntity { PersonneId = 25, Nom = "Eastwood",      Prenom = "Clint" },
    new PersonneEntity { PersonneId = 26, Nom = "Vang",          Prenom = "Bee" },
    new PersonneEntity { PersonneId = 27, Nom = "Miller",        Prenom = "George" },
    new PersonneEntity { PersonneId = 28, Nom = "Theron",        Prenom = "Charlize" },
]);

        }
    }
}
