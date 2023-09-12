using System;
using System.IO;
using System.Linq;
using System.Text;

namespace WorkingFileSystem
{
    // Создать директорию
    // Создать в ней 3 файла. Первый - с массивом чисел от 1 до 100. Второй - с текущей датов, Третий - со списком всех подкаталогов из c:/ProgramFiles (или любого другого)
    // Считать информацию из файлов, созданных в пункте 2.
    //     Файл №2 перенести в новую директорию(ее нужно тоже создать, в любом месте)
    // Перенести категорию №1 в категорию, созданную на шаге 4.
    //     Задание на FileStream. Считать из файла№1 только ту порцию информации, где хранятся числа от 10 до 20. Перезаписать их на числа от 200 до 210.
    internal class Program
    {
        string path = @"C:Каталог";
        string subpath = @"Подкаталог";

        public string[] arrayNameFile =
        {
            "array",
            "date",
            "subDirectory"
        };

        void Main(string[] args)
        {
            CreateDirectory();
            for (int i = 0; i < arrayNameFile.Length; i++)
            {
                CreateFile(@$"{path}\{subpath}", arrayNameFile[i]);
                WritingСontent(pathFile, "text");
            }

            int[] array = Enumerable.Range(1, 100).ToArray();
        }

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

        public void CreateFile(string path, string fileName)
        {
            FileInfo fileInfo = new FileInfo(pathFile);
            fileInfo.Create();
        }

        public void WritingСontent(string pathFile, string text)
        {
            using (StreamWriter writer = new StreamWriter(pathFile, false))
            {
                writer.WriteLineAsync(text);
            }
        }
    }
}