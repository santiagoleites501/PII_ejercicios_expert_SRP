using System;

namespace SRP
{
    class Program
    {
        static void Main()
        {
            Sector sector1 = new Sector("Fiction Sector");
            Shelve shelve1 = new Shelve("Fiction Shelve");
            shelve1.AddBook(new Book("Design Patterns", "Erich Gamma & Others", "001-034"));
            shelve1.AddBook(new Book("Pro C#", "Troelsen", "001-035"));
            sector1.AddShelve(shelve1);

            Sector sector2 = new Sector("History Sector");
            Shelve shelve2 = new Shelve("History Shelve");
            shelve2.AddBook(new Book("Another Book", "Another Author", "001-036"));
            sector2.AddShelve(shelve2);

            foreach (var sector in new Sector[] { sector1, sector2 })
            {
                Console.WriteLine($"Sector: {sector.Name}");
                foreach (var shelve in sector.Shelves)
                {
                    Console.WriteLine($"  Shelve: {shelve.Name}");
                    foreach (var book in shelve.Books)
                    {
                        Console.WriteLine($"    Book: {book.Title} by {book.Author}");
                    }
                }
            }
        }
    }
}
