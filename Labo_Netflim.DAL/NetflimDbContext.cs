using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Labo_Netflim.DAL.Entities;

namespace Labo_Netflim.DAL
{
    public class NetflimDbContext : DbContext 
    {
        public NetflimDbContext(DbContextOptions options) : base(options) { }

        public DbSet<FilmEntity> Film { get; set; }
        public DbSet<UserEntity> User { get; set; }
        public DbSet<PersonneEntity> Personne { get; set; }
        public DbSet<GenreEntity> Genre { get; set; }
        public DbSet<InteractEntity> Interaction { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
