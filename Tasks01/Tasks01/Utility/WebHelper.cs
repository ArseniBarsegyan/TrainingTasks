using System;
using System.Net.Http;
using System.Threading.Tasks;

using Tasks01.Interfaces;

namespace Tasks01.Utility
{
    public class WebHelper : IFileSystem
    {
        public HttpClient HttpClient;

        public async Task<byte[]> GetFileContentFromUrl(string url)
        {
            HttpClient = new HttpClient();
            var response = await HttpClient.GetAsync(url).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsByteArrayAsync();
            }
            return null;
        }

        public byte[] ReadFile(string path)
        {
            throw new NotImplementedException();
        }

        public void WriteFile(string path, byte[] bytes)
        {
            throw new NotImplementedException();
        }
    }
}
