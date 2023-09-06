using System.Collections.Generic;
using MyApp.Models;
using MyApp.Interfaces;

namespace MyApp.Controllers
{
    public class FilmController
    {
        
        public IFilmService? FilmServicePropertyInjected { get; set; } // Property-injeccted service
        
        public IFilmService? FilmServiceConstructorInjected;    // constructor-injected service    
        // Constructor Injection
        public FilmController(IFilmService filmService)
        {   
            FilmServiceConstructorInjected = filmService;
        }

        public IEnumerable<Film>? GetAllFilms(IFilmService filmServiceMethodInjected) // Method-injected service
        {
            return filmServiceMethodInjected.GetAllFilms();
        }

        public Film? GetFilmById(int id)
        {
            //return FilmServicePropertyInjected?.GetFilmById(id);
            return FilmServiceConstructorInjected?.GetFilmById(id);
        }

    }
}
