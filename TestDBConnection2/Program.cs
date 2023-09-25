using Npgsql;

/*Необходимо создать 1 процедуру и 1 функцию. В качестве запросов к базе можно выбрать любой на свой вкус.
Вызвать из c# запросы select, update, delete, insert для своей локальной базы.
Примеры запросов - выбор списка клиентов по полу, апдейт клиента по айди, удаление всех клиентов из конкретного города и так далее.*/
List<Person> persons = new List<Person>();
var connectionString = "Host=localhost;Username=postgres;Password=admin;Database=postgres";

await using var dataSource = NpgsqlDataSource.Create(connectionString);

await using (var cmd = dataSource.CreateCommand(CommandSQL()))
await using (var reader = await cmd.ExecuteReaderAsync())
{
    while (await reader.ReadAsync())
    {
        int PersonID = reader.GetInt32(0);
        var FirstName = SafeGetString(reader, 1);
        var LastName = SafeGetString(reader, 2);
        var Address = SafeGetString(reader, 3);
        var City = SafeGetString(reader, 4);
        var Gender = SafeGetString(reader, 5);
        //persons.Add(new Person(PersonID, FirstName, LastName, Address, City, Gender));

        Console.WriteLine(FirstName + LastName.Result);
    }
}


Console.ReadLine();


//Проверка на null
async Task<string?> SafeGetString(NpgsqlDataReader reader, int ordinal)
{
    return await reader.IsDBNullAsync(ordinal) ? null : await reader.GetFieldValueAsync<string>(ordinal);
}


string CommandSQL()
{
    string filterGender = "SELECT * FROM \"Table1\" WHERE \"Gender\"= 'F'"; //Выбор списка клиентов по полу
    string UpdateClient =
        "UPDATE \"Table1\" SET \"LastName\"='Zaharova' WHERE \"PersonID\" = 5"; //Апдейт клиента по айди
    string deleteClient = "DELETE FROM \"Table1\" WHERE \"City\"='SPB' "; //Удаление всех клиентов из конкретного города
    string insertClient =
        "INSERT INTO \"Table1\" (\"PersonID\",\"FirstName\",\"LastName\",\"Address\",\"City\",\"Gender\") VALUES (55,'Anastasya','Lapova','USA','KZN','F')"; //Добавление нового клиента

    return insertClient;
}


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