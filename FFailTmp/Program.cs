using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace FFailTmp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var drives = DriveInfo.GetDrives();

            var drive = drives.First();

            var directories = Directory.GetDirectories(drive.RootDirectory.FullName);

            var currentPath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

            string fileName = "tmpFile.txt";
            var array = Enumerable.Range(10, 1000)
                .Select(x=>x.ToString())
                .ToArray();

            await File.WriteAllLinesAsync(fileName, array);
            
            
            var fileContent = await File.ReadAllLinesAsync(fileName);
            foreach (var content in fileContent)
            {
                Console.WriteLine(content);
            }
            


            //var fileInfo = CreateFile(fileName);
            //await File.AppendAllTextAsync(fileName, "text123");

            return;

            try
            {
                var info = new DirectoryInfo(currentPath);
                foreach (var directory in info.GetDirectories())
                {
                    if (directory.Name == "TestDir")
                    {
                        directory.Delete();
                    }
                }

                var createdDir = info.CreateSubdirectory("TestDir");
                if (createdDir.Exists)
                {
                    Console.WriteLine("Директория создана");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            // foreach (var directory in directories)
            // {
            //     var info = new DirectoryInfo(directory);
            //     Console.WriteLine($"{info.Name} - {info.CreationTime}");
            //     if (info.Name == "Games")
            //     {
            //         var createdDir = info.CreateSubdirectory("TestDir");
            //         if (createdDir.Exists)
            //         {
            //             Console.WriteLine("Директория создана");
            //         }
            //     }
            //     
            // }
        }

        private static FileInfo CreateFile(string fileName)
        {
            var fileInfo = new FileInfo(fileName);
            if (!fileInfo.Exists)
                fileInfo.Create();
            return fileInfo;
        }


        private static string[] GetAllJsons(string path)
        {
            var files = Directory.GetFiles(path, "*.json");
            return files;
        }
    }
}