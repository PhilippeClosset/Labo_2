

namespace Labo_Netflim.BLL.Models
{
    public class FilmModel
    {
        public int Id { get; set; }
        public required string Titre { get; set; }
        public required DateOnly DateSortie { get; set; }
        public required List<PersonneModel> Realisateurs { get; set; } = [];
        public required List<PersonneModel> Acteurs { get; set; } = [];
        public  required string Synopsis {  get; set; }
        public required  string ImageUrl { get; set; }
        public required List<string> Genre { get; set; }


    }
}
