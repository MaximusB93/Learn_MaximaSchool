using System;

namespace GeometryLibrary.DirAttribute
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class AuthorAttribute : Attribute
    {
        public string Name { get; set; }
        public DateTime DateCreate { get; set; }

        public AuthorAttribute(string name, string dateCreate)
        {
            Name = name;

            if (DateTime.TryParse(dateCreate, out var date))
            {
                DateCreate = date;
            }
            else
            {
                DateCreate = DateTime.Now;
            }
        }
    }
    
    
}