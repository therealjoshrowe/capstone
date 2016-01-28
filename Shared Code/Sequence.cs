using System.Xml.Serialization;

namespace Shared_Code
{
    public class Sequence
    {
        [XmlAttribute("Name")]
        public string name;
        [XmlAttribute("Characters")]
        public string characters;
    }
}