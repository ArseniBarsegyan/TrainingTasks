using System.Threading.Tasks;

namespace Tasks01.Interfaces
{
    public interface IFileSystem
    {
        byte[] ReadFile(string path);
        void WriteFile(string path, byte[] bytes);
        Task<byte[]> GetFileContentFromUrl(string url);
    }
}
