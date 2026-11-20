using System;
using System.Collections.Generic;
using System.Text;

namespace Labo_Netflim.DAL.Entities
{
    public class FilmEntity
    {
        public int FilmId { get; set; }
        public required string ImageUrl { get; set; }
        public required string Titre { get; set; }
        public required string Synopsis { get; set; }
        public required DateOnly Annee { get; set; }
        public ICollection<GenreFilmEntity> Genres { get; set; } = [];
        public ICollection<JoueFilmEntity> Acteurs {  get; set; } = [];
        public ICollection<RealFilmEntity> Realisateurs {  get; set; } = [];
        public ICollection<InteractEntity> Interactions { get; set; } = [];

    }
}
