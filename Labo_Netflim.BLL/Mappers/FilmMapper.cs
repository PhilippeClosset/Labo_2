using Labo_Netflim.BLL.Models;
using Labo_Netflim.DAL.Entities;

namespace Labo_Netflim.BLL.Mappers
{
    internal static class FilmMapper
    {
        public static FilmModel ToModel(this FilmEntity data)
        {
            return new FilmModel()
            {
                Id = data.FilmId,
                Titre = data.Titre,
                Synopsis = data.Synopsis,
                ImageUrl = data.ImageUrl,
                DateSortie = data.Annee,
                Genre = data.Genres.Select(gf => gf.Genre.Nom).ToList(),
                Realisateurs = data.Realisateurs.Select(rf => rf.Realisateur.ToModel()).ToList(),
                Acteurs = data.Acteurs.Select(jf => jf.Acteur.ToModel()).ToList()
            };
        }
    }
}
