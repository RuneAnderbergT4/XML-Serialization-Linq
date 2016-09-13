using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmSamling
{
    public class MovieSortAndList
    {
        public MovieSortAndList(MovieCollection mc)
        {
            MC = mc;
        }

        private MovieCollection MC;

        public void ListAll()
        {
            // Lists all movies (Uppgift 1)
            foreach (Movie n in MC.Movies)
            {
                Console.WriteLine(String.Format("{0,-60}", n.Name) + String.Format("{0,-10}", n.Year) + n.Rating);
            }
        }

        public void ListTop20()
        {
            // Sort and list top 20 movies (based on rating) (uppgift 2)
            List<Movie> moviesTop20 = MC.Movies.OrderByDescending(o => o.Rating).ToList();
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(String.Format("{0,-60}", moviesTop20[i].Name) + String.Format("{0,-10}", moviesTop20[i].Year) + moviesTop20[i].Rating);
            }
        }

        public void ListMadeIn2012()
        {
            // Extracts movies made 2012 and lists in order of number of votes (Uppgift 3)
            List<Movie> movies2012 = MC.Movies.FindAll(movie => movie.Year.Equals(2012)).ToList();
            movies2012 = movies2012.OrderByDescending(movie => movie.Votes).ToList();

            foreach (var n in movies2012)
            {
                Console.WriteLine(String.Format("{0,-60}", n.Name) + String.Format("{0,-10}", n.Year) + String.Format("{0,-10}", n.Rating) + n.Votes);
            }
        }

        public void ListAlphabeticalAll()
        {
            // Lists movies in alphabetical order (uppgift 4)
            List<Movie> moviesAlphabetical = MC.Movies.OrderBy(movie => movie.Name).ToList();
            foreach (Movie n in moviesAlphabetical)
            {
                Console.WriteLine(String.Format("{0,-60}", n.Name) + String.Format("{0,-10}", n.Year) + n.Rating);
            }
        }

        public void ListAlphabeticalG()
        {
            // Lists movies beginning with G in alphabetical order (uppgift 5)
            List<Movie> moviesAlphabeticalG = MC.Movies.FindAll(movie => movie.Name.StartsWith("G")).ToList();
            moviesAlphabeticalG = moviesAlphabeticalG.OrderBy(movie => movie.Name).ToList();
            foreach (Movie n in moviesAlphabeticalG)
            {
                Console.WriteLine(String.Format("{0,-60}", n.Name) + String.Format("{0,-10}", n.Year) + n.Rating);
            }
        }

        public void ListContainingRing()
        {
            // Lists movies with name containing ring (uppgift 6)
            List<Movie> moviesRing = MC.Movies.FindAll(movie => movie.Name.Contains("Ring") || movie.Name.Contains("ring")).ToList();
            foreach (Movie n in moviesRing)
            {
                Console.WriteLine(String.Format("{0,-60}", n.Name) + String.Format("{0,-10}", n.Year) + n.Rating);
            }
        }
    }
}