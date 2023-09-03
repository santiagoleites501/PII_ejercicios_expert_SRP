using System;
using System.Collections.Generic;   
namespace SRP
{
   
    public class Shelve
    {
        public string Name { get; }
        public List<Book> Books { get; } = new List<Book>();

        public Shelve(string name)
        {
            Name = name;
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }
    }
}