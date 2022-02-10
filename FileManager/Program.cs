using FileManager.Implementation;
using FileManager.Interfaces;
using System;
using System.IO;

namespace FileManager
{
    public interface IFileWatcher
    {
        void ReadFile(string path);
        void WriteFile(string path, string content);
    }
    public class FileWatcher : IFileWatcher
    {
        public void ReadFile(string path)
        {
            if(File.Exists(path))
            {
                string [] lines=File.ReadAllLines(path);

                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("file does not exist");
            }

        }
        public void WriteFile(string path, string content)
        {
            string[] lines = { "care, tear, gear" };

            File.WriteAllLines(path, lines);
            File.AppendAllLines(path, lines);

        }
    }
    internal class Program
    {
            static void Main(string[] args)
            {
            string path = @"D:\try\sample.txt";

            FileWatcher watcher = new FileWatcher();

            watcher.ReadFile(path);
           
                // Use the interface to get access to the methods
                // Create a sample.txt file anywhere in your disk 
                // Read the file using the ReadFile method (If the file does not exist in the given path pass the message accodingly)
                // Write more stuff to the same file using the WriteFile method. Ensure it appends and does not delete whatever is already there
            }
        }
}
