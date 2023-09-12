using System.IO;

namespace WorkingFileSystem
{
    public class WriteFile
    {
        public void WritingСontent(string pathFile,string fileName, string text)
        {
            using (StreamWriter writer = new StreamWriter(@$"{pathFile}\{fileName}.txt", true))
            {
                writer.WriteLineAsync(text);
            }
        }
    }
}