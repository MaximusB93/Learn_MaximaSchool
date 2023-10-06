namespace EFExample.Model;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int? SchoolId { get; set; }
    public School? School { get; set; }

    public User()
    {
    }

    public User(int id, string name, int age, int schoolId)
    {
        Id = id;
        Name = name;
        Age = age;
        SchoolId = schoolId;
    }
}