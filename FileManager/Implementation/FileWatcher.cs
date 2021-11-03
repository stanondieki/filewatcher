namespace FileManager.Implementation
{
    public class FileWatcher : IFileWatcher
    {
        public string ReadFile(string path)
        {
            string path = @"C:\Users\nyandika\Desktop\sample.txt";

            string read = File.ReadAllText(path);
            global::System.Console.WriteLine(read);


            if (path == null)
            {
                global::System.Console.WriteLine("The file path is non-existant");
            }

            // Add code to read from the specified file given in path
            // If the path is non-existent, send a message that says so
        }

        public void WriteFile(string path, string content)
        {
            string path = @"C:\Users\nyandika\Desktop\sample.txt"

            TextWriter File=new TextWriter(path);

            string [] content = "The path to success is always hidden ";
            File.WriteAllText(path, content);
            File.AppendText(path);

            File.Close();



            // Add code to the file
            // Do not overwrite what is already there
        }
    }
}
