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

        }
    }
}
