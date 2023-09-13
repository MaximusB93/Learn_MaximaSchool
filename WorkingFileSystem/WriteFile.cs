using System;
using System.IO;
using System.Text;

namespace WorkingFileSystem
{
    public class WriteFile
    {
        public void WritingСontent(string pathFile, string fileName, string text)
        {
            using (StreamWriter writer = new(@$"{pathFile}\{fileName}", true))
            {
                writer.WriteLineAsync(text);
            }
        }

        public async void WritingFileStream(string pathFile, string fileName, string newText)
        {
            using (FileStream fileStream = new FileStream(@$"{pathFile}\{fileName}", FileMode.OpenOrCreate))
            {
                fileStream.Seek(10, SeekOrigin.Begin);
                byte[] input = Encoding.Default.GetBytes(newText);
                await fileStream.WriteAsync(input, 0, input.Length);
            }
        }
    }
}