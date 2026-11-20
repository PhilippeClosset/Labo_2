using Labo_Netflim.BLL.Models;


namespace Labo_Netflim.BLL.Interfaces
{
    public interface IFilmService
    {
        IEnumerable<FilmModel> GetAll();
        FilmModel GetById(int id);
    }
}
