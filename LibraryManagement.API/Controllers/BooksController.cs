using LibraryManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LibraryManagement.API.Controllers
{
    [Route("api/book")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [HttpGet("list")]
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book> 
            {
                new Book { Id = 1, Title = "Book1" }, 
                new Book { Id = 2, Title = "Book2" },
            };
        }

        [HttpGet("{bookId:int}")]
        public Book GetBook(int bookId)
        {
            return new Book();
        }

        [HttpPost("addcategory")]
        public int AddBookCategory(BookCategory bookCategory)
        {
            return 0; //// id of newly added category
        }

        [HttpPost("category/{categoryId}")]
        public int UpdateBookCategory(int categoryId, BookCategory bookCategory)
        {
            return 0; //// id of newly added category
        }

        [HttpPost("add")]
        public int AddBook(Book book)
        {
            return 0; //// id of newly added book
        }

        [HttpPost("bulkadd")]
        public void AddBulkBooks(List<Book> books)
        {
        }

        [HttpPut("{bookId}")]
        public bool AddBook(int bookId, Book book)
        {
            return true; //// status whether updated or not, only if necessary
        }

        [HttpDelete("{bookId}")]
        public bool DeleteBook(int bookId)
        {
            return true;
        }
    }
}