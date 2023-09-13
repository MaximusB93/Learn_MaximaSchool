using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace WorkingFileSystem
{
    public class Reading
    {
        public async Task<string> ReadingFiles(string pathFile, string fileName)
        {
            using (StreamReader reader = new StreamReader(@$"{pathFile}\{fileName}"))
            {
                string text = await reader.ReadToEndAsync();
                return text;
            }
        }

        public async Task<string> ReadingFileStream(string pathFile, string fileName)
        {
            using (FileStream fileStream = new FileStream(@$"{pathFile}\{fileName}", FileMode.OpenOrCreate))
            {
                //Перемещаем курсор на 10 байтов
                fileStream.Seek(10, SeekOrigin.Begin);
                // Создаем буфер для чтения данных из файла
                byte[] buffer = new byte[10];
                // Считываем данные из файла в буфер
                await fileStream.ReadAsync(buffer, 0, buffer.Length);
                // Декодируем байты в строку   
                string textFromFile = Encoding.Default.GetString(buffer);
                return textFromFile;
            }
        }
    }
}