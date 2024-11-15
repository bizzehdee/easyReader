using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace easyReader.Models.RSS
{
    public class RSSEnclosure
    {
        [XmlAttribute("url")]
        public string Url { get; set; }

        [XmlAttribute("length")]
        public int Length { get; set; }

        [XmlAttribute("type")]
        public string Type { get; set; }
    }
}
