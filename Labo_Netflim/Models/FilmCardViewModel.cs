using System.ComponentModel;

namespace Labo_Netflim.Models
{
    public class FilmCardViewModel
    {
        public required int Id { get; set; }

        public required string Image {  get; set; }
        [DisplayName("Titre")]
        public required string Titre { get; set; }
        [DisplayName("Date de sortie")]
        public required DateOnly DateSortie { get; set; }
        [DisplayName("Réalisateur")]
        public required List<string> Realisateur { get; set; }
        [DisplayName("Genres")]
        public required List<string> Genres { get; set; }


    }
}
