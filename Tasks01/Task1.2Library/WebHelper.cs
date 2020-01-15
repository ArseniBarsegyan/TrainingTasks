using System;
using System.Net.Http;
using System.Threading.Tasks;
using Task1._2Library;

namespace Task1._2Library
{
    public class WebHelper : IWebHelper
    {
        private HttpClient _httpClient;
        
        public async Task<byte[]> GetFileContentFromUrl(string url)
        {
            _httpClient = new HttpClient();
            var response = await _httpClient.GetAsync(url).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsByteArrayAsync();
            }
            return null;
        }       
    }
}
