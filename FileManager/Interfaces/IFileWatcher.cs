using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FileManager.Interfaces
{
    public interface IFileWatcher
    {
        // Do not make any changes to this file
        void ReadFile(string path);
        void WriteFile(string path, string content);
    }
}
