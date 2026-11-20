using System;
using System.Collections.Generic;
using System.Text;

namespace Labo_Netflim.DAL.Entities
{
    public class GenreEntity
    {
        public int GenreId { get; set; }
        public required string Nom { get; set; }
    }
}
