using Labo_Netflim.BLL.Models;
using Labo_Netflim.Models;

namespace Labo_Netflim.Mappers
{
    internal static class FilmMapper
    {
        public static FilmCardViewModel ToCardVM(this FilmModel data)
        {
            return new FilmCardViewModel()
            {
                Id = data.Id,
                Image = data.ImageUrl,
                Titre = data.Titre,
                DateSortie = data.DateSortie,
                Genres = data.Genre,
                Realisateur = data.Realisateurs.Select(r => $"{r.Prenom} {r.Nom}").ToList()
            };
        }
        public static FilmDetailViewModel ToDetailVM(this FilmModel data)
        {
            return new FilmDetailViewModel()
            {
                Id = data.Id,
                Image = data.ImageUrl,
                Titre = data.Titre,
                DateSortie = data.DateSortie,
                Genre = data.Genre,
                Realisateur = data.Realisateurs.Select(r => $"{r.Prenom} {r.Nom}").ToList(),
                Desc = data.Synopsis,
                Acteurs = data.Acteurs.Select(r => $"{r.Prenom} {r.Nom}").ToList()


            };
        }
    }
}
