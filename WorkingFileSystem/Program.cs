using System;
using System.Collections.Generic;
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
        private static CreatingDirectoryAndFile _creatingDirectoryAndFile = new CreatingDirectoryAndFile();
        private static GetInfo _getInfo = new GetInfo();
        private static WriteFile _writeFile = new WriteFile();

        static void Main(string[] args)
        {
            //_creatingDirectoryAndFile.CreateDirectory();
            List<string> Data = new List<string>(_getInfo.GetAllData());

            for (int i = 0; i < _creatingDirectoryAndFile.arrayNameFile.Length; i++)
            {
                _creatingDirectoryAndFile.CreateFile(_creatingDirectoryAndFile.fullpath,
                    _creatingDirectoryAndFile.arrayNameFile[i]);
                _writeFile.WritingСontent(_creatingDirectoryAndFile.fullpath,_creatingDirectoryAndFile.arrayNameFile[i], Data[i]);
            }
            
            Console.WriteLine("Created files");
        }
    }
}