using System;
using System.IO;

namespace WorkingFileSystem
{
    public class Transfer
    {
        public void TransferFile(string oldPath, string newPath, string fileName)
        {
            FileInfo fileInfo = new FileInfo(@$"{oldPath}\{fileName}");
            if (fileInfo.Exists)
            {
                fileInfo.MoveTo(@$"{newPath}\{fileName}");
                Console.WriteLine($"File transfer in directory - {@$"{newPath}\{fileName}"}");
            }
        }

        public void TransferDirectory(string oldPath, string newPath)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(oldPath);
            if (directoryInfo.Exists && !Directory.Exists(newPath))
            {
                directoryInfo.MoveTo(newPath);
                Console.WriteLine($"New path directory - {newPath}");
            }
        }
    }
}