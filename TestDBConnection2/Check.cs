using Npgsql;

namespace TestDBConnection2;

public class Check
{
    //Проверка на null
    public async Task<string?> SafeGetString(NpgsqlDataReader reader, int ordinal)
    {
        return await reader.IsDBNullAsync(ordinal) ? null : await reader.GetFieldValueAsync<string>(ordinal);
    }
}