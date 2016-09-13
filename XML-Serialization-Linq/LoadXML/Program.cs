using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XMLSerialisering;

namespace LoadXML
{
    class Program
    {
        static void Main(string[] args)
        {
            BokSamling bs = ObjectXmlSerializer<BokSamling>.Load("boksamling.xml");

            foreach (var n in bs.Boksamling)
            {
                Console.WriteLine(n.Title + " " + n.Author + " " + n.Language);
            }

            Console.ReadKey();
        }
    }
}
