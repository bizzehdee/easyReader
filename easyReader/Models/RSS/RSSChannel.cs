using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace easyReader.Models.RSS
{
    public class RSSChannel
    {
        public string Language { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public RSSImage Image { get; set; }
    }
}
