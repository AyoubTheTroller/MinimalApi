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
            /*var books = _bookService.GetAllBooks();
            var serializedBooks = JsonConvert.SerializeObject(books);
            return Results.Ok(serializedBooks);*/
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

        public object AddBook(Book newBook)
        {
            var book = _bookService.AddBook(newBook);
            return Results.Created($"/books/create", book);
        }

        public object UpdateBook(int id, Book updated){
            var book = _bookService.UpdateBook(id,updated);
            return Results.Created($"/books/update/{book?.Id}", book);
        }

        public object DeleteBook(int id){
            var book = _bookService.DeleteBook(id);
            return Results.Created($"/books/delete/{book?.Id}", book);
        }
    }
}
