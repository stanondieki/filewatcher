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
            string path = @"D:\try\sample.txt";

            FileWatcher fileWatcher = new FileWatcher();
            Console.WriteLine();

                // Use the interface to get access to the methods
                // Create a sample.txt file anywhere in your disk 
                // Read the file using the ReadFile method (If the file does not exist in the given path pass the message accodingly)
                // Write more stuff to the same file using the WriteFile method. Ensure it appends and does not delete whatever is already there
            }
        }
}
