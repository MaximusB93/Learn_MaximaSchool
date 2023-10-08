namespace TestDBConnection2;

public class CommandSQL
{
    public string table { get; set; }
    public string from { get; set; }
    public string where { get; set; }


    public static string FilterUsers(string table)
    {
        string filterUsers = $"SELECT * FROM {table} WHERE \"Gender\"= 'F'"; //Выбор списка клиентов по полу
        return filterUsers;
    }

    public static string UpdateUsers(string table, string set, string where)
    {
        string updateUsers =
            $"UPDATE {table} SET \"LastName\"='Zaharova' WHERE \"PersonID\" = 5"; //Апдейт клиента по айди
        return updateUsers;
    }

    public static string RemoveUsers(string table)
    {
        string removeUsers =
            $"DELETE FROM {table} WHERE \"City\"='SPB' "; //Удаление всех клиентов из конкретного города
        return removeUsers;
    }

    public static string InsertUsers(string table)
    {
        string insertUsers =
            $"INSERT INTO {table} (\"PersonID\",\"FirstName\",\"LastName\",\"Address\",\"City\",\"Gender\") VALUES (55,'Anastasya','Lapova','USA','KZN','F')"; //Добавление нового клиента

        return insertUsers;
    }
}