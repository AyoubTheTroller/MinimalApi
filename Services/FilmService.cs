using MyApp.Interfaces;
using MyApp.Models;
using System.Text.Json;

namespace MyApp.Services
{
    public class FilmService : IFilmService
    {
        private List<Film>? _films;

        public FilmService()
        {
            var jsonText = File.ReadAllText("filmData.json");
            _films = JsonSerializer.Deserialize<List<Film>>(jsonText);
            int idCounter = 1;
            if(_films is not null){
                foreach (var film in _films)
                {
                    film.Id = idCounter++;
                }
            }
        }

        public IEnumerable<Film>? GetAllFilms()
        {
            return _films;
        }

        public Film? GetFilmById(int id)
        {
            return _films?.Find(film => film.Id == id);
        }

    }
}
