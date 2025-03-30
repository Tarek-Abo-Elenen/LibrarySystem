using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class Book
    {
        public required string BookId { get; set; }
        public required string Title { get; set; }
        public required string Author { get; set; }
        public Categorys Category { get; set; }
        public bool IsAvailable { get; set; }

        public Book(string bookId, string title, string author, Categorys category, bool isAvailable)
        {
            BookId = bookId;
            Title = title;
            Author = author;
            Category = category;
            IsAvailable = isAvailable;
        }

        public void DisplayBookInfo()
        {

        }
    }
}
