using MyApp.Controllers;
using MyApp.Models;
using MyApp.Services;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var bookService = new BookService();
var bookController = new BookController(bookService);

app.MapGet("/books", () => bookController.GetAllBooks());
app.MapGet("/books/{id}", (int id) => bookController.GetBookById(id));
app.MapPost("/books/create", (Book newBook) => bookController.AddBook(newBook));

app.MapPut("/books/update/{id}", (int id, Book updatedBook) => bookController.UpdateBook(id, updatedBook));
app.MapDelete("/books/delete/{id}", (int id) => bookController.DeleteBook(id));

app.Run();
