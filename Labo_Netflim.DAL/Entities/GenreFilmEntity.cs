using System;
using System.Collections.Generic;
using System.Text;

namespace Labo_Netflim.DAL.Entities
{
    public class GenreFilmEntity
    {
        public int FilmId { get; set; }
        public FilmEntity Film { get; set; } = null!;

        public int GenreId { get; set; }
        public GenreEntity Genre  { get; set; } = null!;
    }
}
