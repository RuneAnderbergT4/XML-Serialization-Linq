using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace LoadXML
{
    public class BokSamling
    {
        public List<Bok> boksamling = new List<Bok>();
    }
    
    public class Bok
    {
        [XmlAttribute("sprak")] public string Language = "språk";
        [XmlElement("titel")] public string Title = "titel";
        [XmlElement("forfattare")] public string Author = "författare";
        
        public Bok()
        {
            
        }
    }
}
