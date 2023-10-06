using Npgsql;
using TestDBConnection2;

/*Необходимо создать 1 процедуру и 1 функцию. В качестве запросов к базе можно выбрать любой на свой вкус.
Вызвать из c# запросы select, update, delete, insert для своей локальной базы.
Примеры запросов - выбор списка клиентов по полу, апдейт клиента по айди, удаление всех клиентов из конкретного города и так далее.*/

Check check = new Check();
List<Person> persons = new List<Person>();
string connectionString = "Host=localhost;Username=postgres;Password=admin;Database=postgres";
string table = "\"Table1\"";



await using var dataSource = NpgsqlDataSource.Create(connectionString);


//await using (var cmd = dataSource.CreateCommand(CommandSQL.FilterUsers(table, "\"Gender\"", "\'F\'")))
await using (var cmd = dataSource.CreateCommand(CommandSQL.InsertUsers(table, new Person())))
await using (var reader = await cmd.ExecuteReaderAsync())
{
    while (await reader.ReadAsync())
    {
        int PersonID = reader.GetInt32(0);
        var FirstName = check.SafeGetString(reader, 1);
        var LastName = check.SafeGetString(reader, 2);
        var Address = check.SafeGetString(reader, 3);
        var City = check.SafeGetString(reader, 4);
        var Gender = check.SafeGetString(reader, 5);
        persons.Add(new Person(PersonID, await FirstName, await LastName, await Address, await City, await Gender));

        Console.WriteLine(FirstName + LastName.Result);
    }
}