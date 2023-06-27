using System;

namespace GeometryLibrary.Figures
{
    [AttributeUsage((AttributeTargets.Class))]
    public class AuthotAttribute : Attribute
    {
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }

        public AuthotAttribute(string name, string createDate)
        {
            Name = name;
            if (DateTime.TryParse(createDate, out var date))
            {
                CreateDate = date;
            }
            else
            {
                CreateDate = DateTime.Now;
            }
        }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(CreateDate)}: {CreateDate}";
        }
    }
}