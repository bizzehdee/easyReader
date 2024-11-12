using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

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

        internal async Task<bool> TryAddFeed(string feedUrl)
        {
            return false;
        }
    }
}
