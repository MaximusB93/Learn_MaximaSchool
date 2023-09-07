using Npgsql;

List<Person> Clients = new List<Person>();
var connectionString = "Host=localhost;Username=postgres;Password=admin;Database=postgres";
//var connectionString = "Host=pg3.sweb.ru;Username=maksimbudn;Password=maksimbudn;Database=QU3WLCGWFbWRG$S8";
await using var dataSource = NpgsqlDataSource.Create(connectionString);


/*// Insert some data
await using (var cmd = dataSource.CreateCommand("INSERT INTO \"Table1\" (\"PersonID\",\"FirstName\",\"City\",\"Gender\") VALUES (5,'Maria','KRS','F')"))
{
    cmd.Parameters.AddWithValue("Hello world");
    await cmd.ExecuteNonQueryAsync();
}*/


// Retrieve all rows
await using (var cmd = dataSource.CreateCommand("SELECT * FROM \"Table1\""))
await using (var reader = await cmd.ExecuteReaderAsync())
{
    while (await reader.ReadAsync())
    {
        var id = reader.GetInt32(0);
        var name = reader.GetString(1);
        var city = reader.GetString(4);
        Clients.Add(new Person(id,name,city));
    }
}

class Person
{
    public Person(int id, string name, string city)
    {
        Id = id;
        Name = name;
        City = city;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string City { get; set; }
}