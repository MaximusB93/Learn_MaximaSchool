using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkingFileSystem
{
    public class GetInfo
    {
        private List<string> Data = new List<string>();

        public List<string> GetAllData()
        {
            Data.AddRange(new[]
            {
                GenerationArray(),
                GetNowDate(),
                GetDirectory()
            });
            return Data;
        }

        public string GenerationArray()
        {
            int[] array = Enumerable.Range(1, 100).ToArray();
            StringBuilder sb = new StringBuilder();
            foreach (var item in array)
            {
                sb.Append(item);
            }
            return sb.ToString();
        }

        public string GetNowDate()
        {
            return DateTime.Now.ToString();
        }

        public string GetDirectory()
        {
            return "Каталог";
        }
    }
}