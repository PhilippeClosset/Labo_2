using System;
using System.Collections.Generic;
using System.Text;

namespace Labo_Netflim.DAL.Entities
{
    public class InteractEntity
    {
        public int FilmId { get; set; }
        public FilmEntity Film { get; set; } = null!;

        public int UserId { get; set; }
        public UserEntity User { get; set; } = null!;

        public bool IsViewed { get; set; } 
        public bool IsFavorite { get; set; }
    }
}
