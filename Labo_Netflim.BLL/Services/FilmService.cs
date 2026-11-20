using Labo_Netflim.BLL.BusinessException;
using Labo_Netflim.BLL.Interfaces;
using Labo_Netflim.BLL.Mappers;
using Labo_Netflim.BLL.Models;
using Labo_Netflim.DAL.Interfaces;


namespace Labo_Netflim.BLL.Services
{
    public class FilmService : IFilmService
    {
        private readonly IFilmRepository _filmRepository;

        public FilmService(IFilmRepository filmRepository)
        {
            _filmRepository = filmRepository;
        }

        public IEnumerable<FilmModel> GetAll()
        {
            return _filmRepository.GetAll().Select(f => f.ToModel());
        }

        public FilmModel GetById(int id)
        {
            FilmModel? result = _filmRepository.GetById(id)?.ToModel();
            if (result is null)
                throw new FilmNotFoundException();
            return result;

        }
    }

}
