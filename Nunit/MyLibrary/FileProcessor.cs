using System;
using System.IO;

namespace MyLibrary
{
    public class FileProcessor
    {
        public void WriteToFile(string filename, string content)
        {
            File.WriteAllText(filename, content);
        }

        public string ReadFromFile(string filename)
        {
            if (!File.Exists(filename))
                throw new FileNotFoundException("File not found.");

            return File.ReadAllText(filename);
        }
    }
}
