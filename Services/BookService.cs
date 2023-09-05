using MyApp.Models;

namespace MyApp.Services
{
    public class BookService
    {
        private List<Book>? _books = new()
        {
            new Book { Id = 1, Title = "try1", Author = "Troller" },
            new Book { Id = 2, Title = "try2", Author = "Troller" }
        };

        public IEnumerable<Book>? GetAllBooks() => _books;

        public Book? GetBookById(int id) => _books?.FirstOrDefault(b => b.Id == id);
        
    }
}
