using Npgsql;

/*Необходимо создать 1 процедуру и 1 функцию. В качестве запросов к базе можно выбрать любой на свой вкус.
Вызвать из c# запросы select, update, delete, insert для своей локальной базы.
Примеры запросов - выбор списка клиентов по полу, апдейт клиента по айди, удаление всех клиентов из конкретного города и так далее.*/
List<Person> persons = new List<Person>();
var connectionString = "Host=localhost;Username=postgres;Password=admin;Database=postgres";

await using var dataSource = NpgsqlDataSource.Create(connectionString);

await using (var cmd = dataSource.CreateCommand("SELECT * FROM \"Table1\""))
await using (var reader = await cmd.ExecuteReaderAsync())
{
    while (await reader.ReadAsync())
    {
        var PersonID = reader.GetInt32(0);
        var FirstName = reader.GetString(1);
        var LastName = reader.GetString(2);
        var Address = reader.GetString(3);
        var City = reader.GetString(4);
        var Gender = reader.GetString(5);
        persons.Add(new Person(PersonID, FirstName, LastName, Address, City, Gender));

        Console.WriteLine(reader.GetString(1));
    }
}


Console.ReadLine();


class Person
{
    public int PersonID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string Gender { get; set; }

    public Person(int personId, string firstName, string lastName, string address, string city, string gender)
    {
        PersonID = personId;
        FirstName = firstName;
        LastName = lastName;
        Address = address;
        City = city;
        Gender = gender;
    }
}