using MyApp.Controllers;
using MyApp.Models;
using MyApp.Services;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var bookService = new BookService();
var bookController = new BookController(bookService);

app.MapGet("/books", () => bookController.GetAllBooks());
app.MapGet("/books/{id}", (int id) => bookController.GetBookById(id));

app.Run();
