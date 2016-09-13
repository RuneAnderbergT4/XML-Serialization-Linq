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
            Console.WriteLine("Laddade " + mc.Movies.Count + " titlar");

            Console.WriteLine("Den första filmen i listan verkar vara " + mc.Movies[0].Name);

            // Lists all movies (Uppgift 1)
            foreach (Movie t in mc.Movies)
            {
                Console.WriteLine(String.Format("{0,-60}", t.Name) + String.Format("{0,-10}", t.Year) + t.Rating);
            }
          
            Console.ReadKey();
        }
    }
}
