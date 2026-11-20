using Labo_Netflim.DAL.Entities;
using Labo_Netflim.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Labo_Netflim.DAL.Repositories
{
    public class FilmRepository : IFilmRepository
    {

        //---------------------------------------------------------------

        private readonly NetflimDbContext _context;

        public FilmRepository(NetflimDbContext context)
        {
            _context = context;
        }

        //---------------------------------------------------------------
        public IEnumerable<FilmEntity> GetAll()
        {
            return _context.Film
                .Include(f => f.Genres).ThenInclude(gf => gf.Genre)
                .Include(f => f.Realisateurs).ThenInclude(rf => rf.Realisateur)
                .Include(f => f.Acteurs).ThenInclude(jf => jf.Acteur)
                .ToList();

        }
        public FilmEntity? GetById(int id)
        {
            return _context.Film
                                .Include(f => f.Genres).ThenInclude(gf => gf.Genre)
                                .Include(f => f.Realisateurs).ThenInclude(rf => rf.Realisateur)
                                .Include(f => f.Acteurs).ThenInclude(jf => jf.Acteur)
                                .SingleOrDefault(f => f.FilmId == id);
        }

        public IEnumerable<FilmEntity> GetByActor(string actor)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FilmEntity> GetByDate(DateOnly date)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FilmEntity> GetByGenre(string genre)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<FilmEntity> GetByTitle(string title)
        {
            throw new NotImplementedException();
        }
    }
}
