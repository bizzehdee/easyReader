using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace easyReader.Models.RSS
{
    [XmlRoot("rss")]
    public class RSSXML
    {
        [XmlAttribute("version")]
        public decimal Version { get; set; }

        [XmlElement("channel")]
        public RSSChannel Channel { get; set; }
    }
}
