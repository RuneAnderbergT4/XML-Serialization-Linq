using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace LoadXML
{
    [XmlRoot("boksamling")]
    public class BokSamling
    {
        [XmlElement("bok")]
        public List<Bok> Boksamling = new List<Bok>();
    }
    
    public class Bok
    {
        [XmlAttribute("sprak")]
        public string Language { get; set; }

        [XmlElement("titel")]
        public string Title { get; set; }

        [XmlElement("forfattare")]
        public string Author { get; set; }
    }
}
