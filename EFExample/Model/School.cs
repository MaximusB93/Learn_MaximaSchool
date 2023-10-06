namespace EFExample.Model;

public class School
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string City { get; set; }

    public List<User> users = new List<User>();

    public School(int id, string title, string city)
    {
        Id = id;
        Title = title;
        City = city;
    }
}