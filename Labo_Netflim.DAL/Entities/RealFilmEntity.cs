using System;
using System.Collections.Generic;
using System.Text;

namespace Labo_Netflim.DAL.Entities
{
    public class RealFilmEntity
    {
        public int FilmId { get; set; }
        public FilmEntity Film { get; set; } = null!;

        public int PersonneId { get; set; }
        public PersonneEntity Realisateur { get; set; } = null!;
    }
}
