using MyApp.Models;
using MyApp.Services;

namespace MyApp.Controllers
{
    public class BookController
    {
        private readonly BookService _bookService;

        public BookController(BookService bookService)
        {
            _bookService = bookService;
        }

        public IEnumerable<Book>? GetAllBooks()
        {
            return _bookService.GetAllBooks();
        }

        public object GetBookById(int id)
        {
            var book = _bookService.GetBookById(id);
            if (book is null)
            {
                return Results.NotFound($"Book with ID {id} not found");
            }

            return Results.Ok(book);
        }
    }
}
