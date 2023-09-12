using System;
using System.IO;

namespace WorkingFileSystem
{
    public class CreatingDirectoryAndFile
    {
        private static string path = @"C:Каталог";
        private static string subpath = @"Подкаталог";
        public string fullpath = @$"{path}\{subpath}";

        public string[] arrayNameFile =
        {
            "array",
            "date",
            "subDirectory"
        };

        public void CreateDirectory()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            if (directoryInfo.Exists)
            {
                Console.WriteLine("Каталог существует");
            }

            var createDir = directoryInfo.CreateSubdirectory(subpath);

            if (createDir.Exists)
            {
                Console.WriteLine("Подкаталог создан");
            }
        }

        public void CreateFile(string pathFile, string fileName)
        {
            FileInfo fileInfo = new FileInfo(@$"{pathFile}\{fileName}.txt");
            fileInfo.Create();
        }
    }
}