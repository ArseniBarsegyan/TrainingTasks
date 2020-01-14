using System.Threading.Tasks;

namespace Task1._2Library
{
    public interface IFileSystem
    {
        byte[] ReadFile(string path);
        void WriteFile(string path, byte[] bytes);       
    }
}
