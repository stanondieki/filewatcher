using FileManager.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FileManager.Implementation

{
    public class FileWatcher : IFileWatcher
    {

        public void ReadFile(string path)
        {
             if (File.Exists(path))
            {
                string [] lines = File.ReadAllLines(path);
                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("File Does not exist");
            }
            // Add code to read from the specified file given in path
            // If the path is non-existent, send a message that says so
        }

        public void WriteFile(string path, string content)
        {
            string[] lines = {"deep, state"};

            File.WriteAllLines(path, lines);
            File.AppendAllLines(path, lines);

            // Add code to the file
            // Do not overwrite what is already there
        }
    }
}
