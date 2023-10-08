using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.JavaScript;

namespace EFExample.Model
{
    public class User
    {
        public int Id { get; set; }
        [MaxLength(100)] public string Name { get; set; }
        [Range(0, 99)] public int Age { get; set; }
        [EnumDataType(typeof(Gender))] public string Gender { get; set; }
        public int Number { get; set; }

        public User()
        {
        }

        public User(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
    }

    public enum Gender
    {
        Male,
        Female
    }
}