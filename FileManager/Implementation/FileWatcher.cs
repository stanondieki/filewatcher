using FileManager.Interfaces;
using System;
using System.IO;

namespace FileManager.Implementation

{
    public class FileWatcher : IFileWatcher
    {

        public string ReadFile(string dirPath, string fileName)
        {
            // Read the file only if it exists, you cannot read a file that does not exist
            if (File.Exists(Path.Combine(dirPath, fileName)))
            {
                string text = File.ReadAllText(Path.Combine(dirPath, fileName));
                return text;
            }

            return $"File {fileName} does not exist";
        }

        public void WriteFile(string dirPath, string fileName, string content)
        {
            CreateDirectory(dirPath);

            File.AppendAllText(Path.Combine(dirPath, fileName), content + Environment.NewLine);
        }

        private void CreateDirectory(string dirPath)
        {
            // Check if the directory exists, create it if it does not exists
            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }
        }
    }
}
