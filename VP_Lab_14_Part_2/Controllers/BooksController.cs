using Microsoft.AspNetCore.Mvc;
using VP_Lab_14_Part_2.Models;

namespace VP_Lab_14_Part_2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private static List<Book> books = new List<Book>
    {
        new Book { BookId = 1, BookTitle = "C# Basics", Author = "Ali" },
        new Book { BookId = 2, BookTitle = "ASP.NET Core", Author = "Ahmed" }
    };

        // GET: api/books
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(books);
        }

        // GET: api/books/1
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var book = books.FirstOrDefault(b => b.BookId == id);
            return Ok(book);
        }

        // POST: api/books
        [HttpPost]
        public IActionResult Create(Book book)
        {
            books.Add(book);
            return Ok(books);
        }

        // PUT: api/books/1
        [HttpPut("{id}")]
        public IActionResult Update(int id, Book updatedBook)
        {
            var book = books.FirstOrDefault(b => b.BookId == id);
            book.BookTitle = updatedBook.BookTitle;
            book.Author = updatedBook.Author;
            return Ok(book);
        }

        // DELETE: api/books/1
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var book = books.FirstOrDefault(b => b.BookId == id);
            books.Remove(book);
            return Ok(books);
        }
    }

}
