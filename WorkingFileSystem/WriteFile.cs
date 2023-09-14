using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace WorkingFileSystem
{
    public class WriteFile
    {
        public async Task WritingСontent(string pathFile, string fileName, string text)
        {
            using (StreamWriter writer = new StreamWriter(@$"{pathFile}\{fileName}", true))
            {
                 await writer.WriteLineAsync(text);
            }   
        }

        public async Task WritingFileStream(string pathFile, string fileName, string newText)
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