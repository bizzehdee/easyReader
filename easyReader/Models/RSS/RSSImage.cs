﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace easyReader.Models.RSS
{
    public class RSSImage
    {
        [XmlElement("url")]
        public string Url { get; set; }
        [XmlElement("title")]
        public string Title { get; set; }
        [XmlElement("link")]
        public string Link { get; set; }
    }
}
