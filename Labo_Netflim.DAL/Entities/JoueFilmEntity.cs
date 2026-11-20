using Labo_Netflim.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Labo_Netflim.DAL.Entities
{
    public class JoueFilmEntity
    {
        public int FilmId { get; set; }
        public FilmEntity Film { get; set; } = null!;

        public int PersonneId { get; set; }
        public PersonneEntity Acteur { get; set; } = null!;

    }
}
