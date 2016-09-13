using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmSamling;
using XMLSerialisering;

namespace SkapaDataTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Testprogram för att skapa några objekt och se om vi
            //enkelt kan spara dem.

            MovieCollection mc = new MovieCollection();
            mc.Movies.Add(new Movie()
            {
                Id = 1,
                Name = "Rödluvan",
                Rating = 5.6,
                Votes = 123,
                Year = 1972
            });

            mc.Movies.Add(new Movie()
            {
                Id = 2,
                Name = "Transförmers 28",
                Rating = 3.2,
                Votes = 937462,
                Year = 2017
            });

            ObjectXmlSerializer<MovieCollection>.Save(mc, "test.xml");
        }
    }
}
