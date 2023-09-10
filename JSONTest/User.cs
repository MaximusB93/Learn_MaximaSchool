using Newtonsoft.Json;

namespace JSONTest;

public class User
{
    public string Name { get; set; }
    
    [JsonIgnore]
    public byte Age { get; set; }
    public Mother Mother { get; set; }
    public string[] Children { get; set; }
    public bool Married { get; set; }
    
    [JsonProperty("animal")]
    public string Dog { get; set; }

    [JsonIgnore]
    public int ChildrenCount => Children.Length;

    public User(string name, byte age, Mother mother, string[] children, bool married, string dog)
    {
        Name = name;
        Age = age;
        Mother = mother;
        Children = children;
        Married = married;
        Dog = dog;
    }
}

public class Mother
{
    public Mother(string name, byte age)
    {
        Name = name;
        Age = age;
    }

    public string Name { get; set; }
    public byte Age { get; set; }
}