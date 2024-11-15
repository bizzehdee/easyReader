using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace easyReader.Models.RSS
{
    public class RSSItem
    {
        [XmlElement("title")]
        public string Title { get; set; }

        [XmlElement("description")]
        public string Description { get; set; }

        [XmlElement("link")]
        public string Link { get; set; }

        [XmlElement("guid")]
        public string GUID { get; set; }

        [XmlElement("pubDate")]
        public string PubDate { get; set; }

        [XmlIgnore]
        public DateTime? PublishDateTime
        {
            get
            {
                DateTime.TryParse(PubDate, out var pubDate);
                return pubDate;
            }
        }

        [XmlElement("enclosure")]
        public RSSEnclosure Enclosure { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}

/*
      <enclosure url="https://dts.podtrac.com/redirect.mp3/chtbl.com/track/3417G2/pdst.fm/e/arttrk.com/p/ATC0F/verifi.podscribe.com/rss/p/mgln.ai/e/18/claritaspod.com/measure/traffic.omny.fm/d/clips/885ace83-027a-47ad-ad67-aca7002f1df8/22b063ac-654d-428f-bd69-ae2400349cde/1ea64833-2c63-4823-a22a-b2290126b308/audio.mp3?utm_source=Podcast&amp;in_playlist=65ff0206-b585-4e2a-9872-ae240034c9c9" length="59227496" type="audio/mpeg" />
 */