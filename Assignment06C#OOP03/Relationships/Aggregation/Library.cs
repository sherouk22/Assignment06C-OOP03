using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment06C_OOP03.Relationships.Aggregation
{
    public class Library
    {
        public List<Book> books {  get; set; }  = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"Book {book.Titel} Added successfully");
        }

    }
}
