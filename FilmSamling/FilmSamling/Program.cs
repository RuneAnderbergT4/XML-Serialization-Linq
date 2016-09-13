using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using XMLSerialisering;

namespace FilmSamling
{
    class Program
    {
        static void Main(string[] args)
        {
            MovieCollection mc = ObjectXmlSerializer<MovieCollection>.Load("moviecollection.xml");
            
            MovieSortAndList movieSortAndList = new MovieSortAndList(mc);

            while (true)
            {
                OutputMenu(mc);

                string input = Console.ReadLine();

                Console.Clear();

                switch (input)
                {
                    case "1":
                        movieSortAndList.ListAll();
                        break;
                    case "2":
                        movieSortAndList.ListTop20();
                        break;
                    case "3":
                        movieSortAndList.ListMadeIn2012();
                        break;
                    case "4":
                        movieSortAndList.ListAlphabeticalAll();
                        break;
                    case "5":
                        movieSortAndList.ListAlphabeticalG();
                        break;
                    case "6":
                        movieSortAndList.ListContainingRing();
                        break;
                    case "quit":
                        Environment.Exit(0);
                        break;
                    case "exit":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Bad input, try again!");
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Press any key to return to menu!");
                Console.ReadKey();
            }
        }

        private static void OutputMenu(MovieCollection mc)
        {
            Console.Clear();

            Console.WriteLine("Loaded " + mc.Movies.Count + " movies");
            Console.WriteLine();

            Console.WriteLine("1: List all movies");
            Console.WriteLine("2: List top 20 movies based on rating");
            Console.WriteLine("3: List all movies from 2012 based on number of votes");
            Console.WriteLine("4: List all movies in alphabetical order");
            Console.WriteLine("5: List all movies beginning with G in alphabetical order");
            Console.WriteLine("6: List all movies containing ring in the title");

            Console.WriteLine();
            Console.WriteLine("Choose alternative by writing 1-6, exit or quit to close the program!");
        }
    }
}
