using System; 
using System.Collections.Generic;

namespace SRP
{    public class Sector
    {
        public string Name { get; }
        public List<Shelve> Shelves { get; } = new List<Shelve>();

        public Sector(string name)
        {
            Name = name;
        }

        public void AddShelve(Shelve shelve)
        {
            Shelves.Add(shelve);
        }
    }
}