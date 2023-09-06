using MyApp.Models;
namespace MyApp.Interfaces{
    public interface IFilmService{
        public IEnumerable<Film>? GetAllFilms();
        public Film? GetFilmById(int id);
    }
}