using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_System_and_Streams.Abstractions
{
    public interface ICreateFile
    {
        FileStream CreateFile(string path, string fileName);
    }
}
