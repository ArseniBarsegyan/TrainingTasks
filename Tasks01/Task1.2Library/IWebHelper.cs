using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Task1._2Library
{
    interface IWebHelper
    {
        Task<byte[]> GetFileContentFromUrl(string url);
    }
}
