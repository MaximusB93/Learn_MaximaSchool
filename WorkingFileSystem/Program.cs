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
        private static string disk = "C";
        private static string path = "Directory";
        private static string subpath = "Subdirectory";

        public static string[] arrayNameFile =
        {
            "array.txt",
            "date.txt",
            "subDirectory.txt"
        };

        private static CreateEntities _createEntities = new CreateEntities();
        private static GetInfo _getInfo = new GetInfo();
        private static WriteFile _writeFile = new WriteFile();
        private static Reading _reading = new Reading();
        private static Transfer _transfer = new Transfer();


        static void Main(string[] args)
        {
            StartProgram();
        }

        static void StartProgram()
        {
            //Создание директорий
            _createEntities.CreateDirectory(@$"{disk}:\{path}");

            //Агрегирование полученой информации 
            List<string> Data = new List<string>(_getInfo.GetAllData(1, 100));

            //Создание файлов и запись информации в них
            for (int i = 0; i < arrayNameFile.Length; i++)
            {
                _createEntities.CreateFile(@$"{disk}:\{path}", arrayNameFile[i]);
                _writeFile.WritingСontent(@$"{disk}:\{path}", arrayNameFile[i], Data[i]);
            }

            //Считывание информации из файлов
            for (int i = 0; i < arrayNameFile.Length; i++)
            {
                string text = _reading.ReadingFiles(path, arrayNameFile[i]).ToString();
                View.ViewConsole(text);
            }

            //Перенос папок и файлов
            string newPath = "Directory2";
            _createEntities.CreateDirectory(@$"{disk}:\{newPath}");
            _transfer.TransferFile(@$"{disk}:\{path}", @$"{disk}:\{newPath}", arrayNameFile[1]);
            _transfer.TransferDirectory(@$"{disk}:\{path}", @$"{disk}:\{newPath}\{path}");

            //Считываение части информации и ее перезапись
            _reading.ReadingFileStream(@$"{disk}:\{newPath}\{path}", arrayNameFile[0]);
            string newArray = _getInfo.GenerationArray(200, 10);
            _writeFile.WritingFileStream(@$"{disk}:\{newPath}\{path}", arrayNameFile[0], newArray);
        }
    }
}