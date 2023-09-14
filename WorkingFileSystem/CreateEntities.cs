using System;
using System.IO;

namespace WorkingFileSystem
{
    public class CreateEntities
    {
        public void CreateDirectory(string path)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
                Console.WriteLine("Create directory");
            }
            else
            {
                Console.WriteLine("Directory exists");
            }
        }

        public void CreateFile(string path, string fileName)
        {
            FileInfo fileInfo = new FileInfo(@$"{path}\{fileName}");
            using (fileInfo.Create())
            {
                Console.WriteLine($"Create file - {fileInfo.Name}");
            }
        }
    }
}