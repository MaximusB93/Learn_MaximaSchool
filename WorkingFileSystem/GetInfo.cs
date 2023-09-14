using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WorkingFileSystem
{
    public class GetInfo
    {
        private List<string> Data = new List<string>();

        public List<string> GetAllData(int start, int count)
        {
            Data.AddRange(new[]
            {
                GenerationArray(start, count),
                GetNowDate(),
                GetDirectory()
            });
            return Data;
        }

        public string GenerationArray(int start, int count)
        {
            int[] array = Enumerable.Range(start, count).ToArray();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < array.Length; i++)
            {
                sb.Append(array[i]);

                if (i < array.Length - 2)
                {
                    sb.Append("\n\r");
                }
            }

            return sb.ToString();
        }

        public string GetNowDate()
        {
            return DateTime.Now.ToString();
        }

        public string GetDirectory()
        {
            string path = @"C:\Program Files";
            StringBuilder sb = new StringBuilder();
            if (Directory.Exists(path))
            {
                string[] arraySubdirectories = Directory.GetDirectories(path);

                for (int i = 0; i < arraySubdirectories.Length; i++)
                {
                    sb.Append(arraySubdirectories[i]);

                    if (i < arraySubdirectories.Length - 2)
                    {
                        sb.Append("\n\r");
                    }
                }
            }

            return sb.ToString();
        }
    }
}