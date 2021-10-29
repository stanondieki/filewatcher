using FileManager.Interfaces;

namespace FileManager.Implementation
{
    public class FileWatcher : IFileWatcher
    {
        public string ReadFile(string path)
        {
            // Add code to read from the specified file given in path
            // If the path is non-existent, send a message that says so
        }

        public void WriteFile(string path, string content)
        {
            // Add code to the file
            // Do not overwrite what is already there
        }
    }
}
