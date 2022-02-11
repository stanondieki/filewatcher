using FileManager.Implementation;
using FileManager.Interfaces;
using System;
using System.IO;

namespace FileManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Let use use a temporary location instead
            string tempDir = Path.Combine(Path.GetTempPath(), "StanWatch");
            string fileName = "test.txt";

            IFileWatcher watcher = new FileWatcher();

            // Read the existing lines in the text file and show in console
            var text = watcher.ReadFile(tempDir, fileName);
            Console.WriteLine(text);

            // Write some content into the text file
            watcher.WriteFile(tempDir, fileName, "This is some sample text");

            // Read the text we have written
            text = watcher.ReadFile(tempDir, fileName);
            Console.WriteLine(text);


            // Leave this here so the console does not shut down afterwards
            Console.ReadLine();
        }
    }
}
