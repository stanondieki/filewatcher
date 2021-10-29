namespace FileManager.Interfaces
{
    public interface IFileWatcher
    {
        // Do not make any changes to this file
        string ReadFile(string path);
        void WriteFile(string path, string content);
    }
}
