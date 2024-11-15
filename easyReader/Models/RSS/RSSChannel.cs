using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace easyReader.Models.RSS
{
    public class RSSChannel
    {
        /*
         Basic RSS
         */

        [XmlElement("language")]
        public string Language { get; set; }

        [XmlElement("title")]
        public string Title { get; set; }

        [XmlElement("link")]
        public string Link { get; set; }

        [XmlElement("description")]
        public string Description { get; set; }

        [XmlElement("image")]
        public RSSImage Image { get; set; }

        [XmlElement("item")]
        public List<RSSItem> Items { get; set; }

        /*
         iTunes specific
        */

        [XmlElement("type", Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
        public string PodcastType { get; set; }

        [XmlElement("summary", Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
        public string PodcastSummary { get; set; }

        [XmlElement("explicit", Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
        public string PodcastExplicit { get; set; }
    }
}
