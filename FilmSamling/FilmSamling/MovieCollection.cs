using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmSamling
{
    public class MovieCollection
    {
        public List<Movie> Movies = new List<Movie>();
    }

    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Rating { get; set; }
        public int Votes { get; set; }
        public int Year { get; set; }
    }
}
