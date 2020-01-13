using System;
using System.IO;
using System.Threading.Tasks;

namespace Tasks01.Utility
{
    public class FileSystem
    {
        public byte[] ReadFile(string path)
        {
            return File.ReadAllBytes(path);
        }

        public void WriteFile(string path, byte[] bytes)
        {
            File.WriteAllBytes(path, bytes);
        }

        public async Task<byte[]> GetFileContentFromUrl(string url)
        {
            throw new NotImplementedException();
        }
    }
}
