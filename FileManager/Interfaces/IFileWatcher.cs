namespace FileManager.Interfaces
{
    public interface IFileWatcher
    {
        // Do not make any changes to this file
        string ReadFile(string dirPath, string fileName);
        void WriteFile(string dirPath, string fileName, string content);
    }
}
