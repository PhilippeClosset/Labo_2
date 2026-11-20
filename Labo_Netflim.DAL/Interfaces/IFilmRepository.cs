using Labo_Netflim.DAL.Entities;

namespace Labo_Netflim.DAL.Interfaces
{
    public interface IFilmRepository
    {
        IEnumerable<FilmEntity> GetAll();
        FilmEntity? GetById(int id);
        IEnumerable<FilmEntity> GetByGenre(string genre);
        IEnumerable<FilmEntity> GetByTitle(string title);
        IEnumerable<FilmEntity> GetByActor(string actor);
        IEnumerable<FilmEntity> GetByDate(DateOnly date);
        
    }
}
