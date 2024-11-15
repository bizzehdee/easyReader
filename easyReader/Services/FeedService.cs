using easyReader.Models.RSS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace easyReader.Services
{
    public class FeedService
    {
        private HttpClient client;

        public FeedService(IHttpClientFactory httpClientFactory)
        {
            client = httpClientFactory.CreateClient();
        }

        public bool CheckValidURL(string url)
        {
            return Uri.TryCreate(url, UriKind.Absolute, out _);
        }

        public async Task<bool> CanReachURL(string feedUrl)
        {
            var response = await client.GetAsync(feedUrl);
            return response.StatusCode == System.Net.HttpStatusCode.OK;
        }

        public async Task<bool> ParseFeed(string feedUrl)
        {
            return false;
        }

        public async Task<bool> TryAddFeed(string feedUrl)
        {
            var response = await client.GetAsync(feedUrl);
            var rssXml = await response.Content.ReadAsStreamAsync();

            var rssParser = new XmlSerializer(typeof(RSSXML));
            var rssObj = (RSSXML?)rssParser.Deserialize(rssXml);
            return false;
        }
    }
}
