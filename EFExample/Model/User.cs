namespace EFExample.Model;

public class User
{
    public int id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public User(int id, string name, int age)
    {
        this.id = id;
        Name = name;
        Age = age;
    }
}