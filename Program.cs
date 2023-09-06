using MyApp.Controllers;
using MyApp.Interfaces;
using MyApp.Models;
using MyApp.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<IFilmService, FilmService>();  // Registering FilmService for DI via properties
builder.Services.AddSingleton<FilmController>(); // Registering FilmController for DI

var app = builder.Build();

// book APIs

var bookService = new BookService();
var bookController = new BookController(bookService);

app.MapGet("/books", () => bookController.GetAllBooks());
app.MapGet("/books/{id}", (int id) => bookController.GetBookById(id));
app.MapPost("/books/create", (Book newBook) => bookController.AddBook(newBook));
app.MapPut("/books/update/{id}", (int id, Book updatedBook) => bookController.UpdateBook(id, updatedBook));
app.MapDelete("/books/delete/{id}", (int id) => bookController.DeleteBook(id));

// film APIs

var filmController = app.Services.GetService<FilmController>(); // Retrieve controller from DI container
var filmService = new FilmService();

app.MapGet("/films", () => filmController?.GetAllFilms(filmService));
app.MapGet("/films/{id}", (int id) => filmController?.GetFilmById(id));

app.Run();
