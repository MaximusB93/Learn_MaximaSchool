using Npgsql;
using TestDBConnection2;

/*Необходимо создать 1 процедуру и 1 функцию. В качестве запросов к базе можно выбрать любой на свой вкус.
Вызвать из c# запросы select, update, delete, insert для своей локальной базы.
Примеры запросов - выбор списка клиентов по полу, апдейт клиента по айди, удаление всех клиентов из конкретного города и так далее.*/

List<Person> persons = new List<Person>();
string connectionString = "Host=localhost;Username=postgres;Password=admin;Database=Learn_MaximaSchool";
string table = "\"TableName\"";

await using var dataSource = NpgsqlDataSource.Create(connectionString);

await using (var cmd = dataSource.CreateCommand(CommandSQL.FilterUsers()))
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
        persons.Add(new Person(PersonID, await FirstName, await LastName, await Address, await City, await Gender));

        Console.WriteLine(FirstName + LastName.Result);
    }
}

//Проверка на null
async Task<string?> SafeGetString(NpgsqlDataReader reader, int ordinal)
{
    return await reader.IsDBNullAsync(ordinal) ? null : await reader.GetFieldValueAsync<string>(ordinal);
}