using System.IO;

namespace MyProject.Bussiness.Services
{
    public class FileService
    {
        public void SaveToFile(string filePath, string content)
        {
            File.WriteAllText(filePath, content);
        }

        public string ReadFromFile(string filePath)
        {
            return File.Exists(filePath) ? File.ReadAllText(filePath) : string.Empty;
        }
    }
}