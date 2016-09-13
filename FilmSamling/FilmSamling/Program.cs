﻿using System;
using System.Collections.Generic;
using System.Linq;
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
            //Console.WriteLine("Laddade " + mc.Movies.Count + " titlar");

            //Console.WriteLine("Den första filmen i listan verkar vara " + mc.Movies[0].Name);

            // Lists all movies (Uppgift 1)
            //foreach (Movie n in mc.Movies)
            //{
            //    Console.WriteLine(String.Format("{0,-60}", n.Name) + String.Format("{0,-10}", n.Year) + n.Rating);
            //}

            //// Sort and list top 20 movies (based on rating) (uppgift 2)
            //List<Movie> mcTop20 = mc.Movies.OrderByDescending(o => o.Rating).ToList();
            //for (int i = 0; i < 20; i++)
            //{
            //    Console.WriteLine(String.Format("{0,-60}", mcTop20[i].Name) + String.Format("{0,-10}", mcTop20[i].Year) + mcTop20[i].Rating);
            //}

            //// Extracts movies made 2012 and lists in order of number of votes (Uppgift 3)
            //List<Movie> mc2012 = mc.Movies.FindAll(movie => movie.Year.Equals(2012)).ToList();
            //mc2012 = mc2012.OrderByDescending(movie => movie.Votes).ToList();

            //foreach (var t in mc2012)
            //{
            //    Console.WriteLine(String.Format("{0,-60}", t.Name) + String.Format("{0,-10}", t.Year) + String.Format("{0,-10}", t.Rating) + t.Votes);
            //}

            //// Lists movies in alphabetical order (uppgift 4)
            //List<Movie> mcAlphabetical = mc.Movies.OrderBy(movie => movie.Name).ToList();
            //foreach (Movie n in mcAlphabetical)
            //{
            //    Console.WriteLine(String.Format("{0,-60}", n.Name) + String.Format("{0,-10}", n.Year) + n.Rating);
            //}

            //// Lists movies in alphabetical order based on name and list the ones beginning with G (uppgift 5)
            //List<Movie> mcAlphabeticalG = mc.Movies.FindAll(movie => movie.Name.StartsWith("G")).ToList();
            //foreach (Movie n in mcAlphabeticalG)
            //{
            //    Console.WriteLine(String.Format("{0,-60}", n.Name) + String.Format("{0,-10}", n.Year) + n.Rating);
            //}

            //// Lists movies with name containing ring (uppgift 6)
            //List<Movie> mcRing = mc.Movies.FindAll(movie => movie.Name.Contains("Ring") || movie.Name.Contains("ring")).ToList();
            //foreach (Movie n in mcRing)
            //{
            //    Console.WriteLine(String.Format("{0,-60}", n.Name) + String.Format("{0,-10}", n.Year) + n.Rating);
            //}

            Console.ReadKey();
        }
    }
}
