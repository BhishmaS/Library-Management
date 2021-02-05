using LibraryManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LibraryManagement.API.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [HttpGet("all")]
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book> 
            {
                new Book { Id = 1, Title = "Book1" }, 
                new Book { Id = 2, Title = "Book2" },
            };
        }

        [HttpGet("{bookId:int}/details")]
        public Book GetBookDetails(int bookId)
        {
            return new Book();
        }

        [HttpPost("addcategory")]
        public int AddBookCategory(BookCategory bookCategory)
        {
            return 0; //// id of newly added category
        }

        [HttpPost("category/{categoryId}/update")]
        public int AddBookCategory(int categoryId, BookCategory bookCategory)
        {
            return 0; //// id of newly added category
        }

        [HttpPost("add")]
        public int AddBook(Book book)
        {
            return 0; //// id of newly added book
        }

        [HttpPost("bulkadd")]
        public void BulkAddBooks(List<Book> books)
        {
        }

        [HttpPut("{bookId}/update")]
        public bool UpdateBook(int bookId, Book book)
        {
            return true; //// status whether updated or not, only if necessary
        }

        [HttpDelete("{bookId}/delete")]
        public bool DeleteBook(int bookId)
        {
            return true;
        }
    }
}