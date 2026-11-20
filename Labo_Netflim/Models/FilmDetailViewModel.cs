using System.ComponentModel;

namespace Labo_Netflim.Models
{
    public class FilmDetailViewModel
    {
        public required string Image { get; set; }
        [DisplayName("Identifiant")]
        public required int Id { get; set; }
        [DisplayName("Titre")]
        public required string Titre { get; set; }
        [DisplayName("Date de sortie")]
        public required DateOnly DateSortie { get; set; }
        [DisplayName("Réalisateur")]
        public required List<string> Realisateur { get; set; }
        [DisplayName("Genres")]
        public required List<string> Genre { get; set; }
        [DisplayName("Description")]
        public required string Desc { get; set; }
        [DisplayName("Acteurs")]
        public required List<string> Acteurs { get; set; }
    }
}
