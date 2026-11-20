using Labo_Netflim.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Labo_Netflim.DAL.Configs
{
    internal class InteractConfig : IEntityTypeConfiguration<InteractEntity>
    {
        public void Configure(EntityTypeBuilder<InteractEntity> builder)
        {
            builder.ToTable("Interaction_Film");

            builder.HasKey(uf => new { uf.FilmId, uf.UserId })
                    .HasName("PK_User_Film");

            builder.HasOne(uf => uf.Film)
                    .WithMany(f => f.Interactions)
                    .HasForeignKey(uf => uf.FilmId)
                    .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(uf => uf.User)
                    .WithMany(u => u.Interact)
                    .HasForeignKey(uf => uf.UserId)
                    .OnDelete(DeleteBehavior.Cascade);

            builder.Property(u => u.IsFavorite)
                    .HasColumnName("Is_Favorite");


            builder.Property(u => u.IsViewed)
                    .HasColumnName("Is_Viewed");
        }
    }
}
