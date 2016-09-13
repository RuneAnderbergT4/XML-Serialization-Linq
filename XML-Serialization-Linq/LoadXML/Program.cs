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
        static void Main(string[] args) { 
        //{
        //    Bok bok = new Bok();
        //    ObjectXmlSerializer<Bok>.Save(bok, "testbok.xml");

            BokSamling bs = new BokSamling();
            bs.boksamling.Add( new Bok());
            ObjectXmlSerializer<BokSamling>.Save(bs,"testboksamling.xml");

            //BokSamling bs = ObjectXmlSerializer<BokSamling>.Load("boksamling.xml");
        }
    }
}
