using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTask
{
    class Actor
    {
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
    }

    abstract class ArtObject
    {

        public string Author { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
    }
    class Film : ArtObject
    {

        public int Length { get; set; }
        public IEnumerable<Actor> Actors { get; set; }
    }
    class Book : ArtObject
    {

        public int Pages { get; set; }
    }
}

