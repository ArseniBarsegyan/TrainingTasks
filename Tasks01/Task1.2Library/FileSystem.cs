using System;
using System.IO;
using System.Threading.Tasks;

namespace Task1._2Library
{
    public class FileSystem: IFileSystem
    {
        public byte[] ReadFile(string path)
        {
            return File.ReadAllBytes(path);
        }

        public void WriteFile(string path, byte[] bytes)
        {
            File.WriteAllBytes(path, bytes);
        }

    }
}
