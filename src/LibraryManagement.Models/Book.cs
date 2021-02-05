using System;

namespace LibraryManagement.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Number { get; set; }

        public int CategoryId { get; set; }

        public string AuthorName { get; set; }

        public string PublisherName { get; set; }

        public DateTime? PublishedOn { get; set; }
    }
}