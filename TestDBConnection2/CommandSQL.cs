namespace TestDBConnection2;

public class CommandSQL
{
    //public static string table { get; set; }
    //public static string from { get; set; }
    //public static string where { get; set; }


    public static string FilterUsers(string table, string where, object whereValue)
    {
        string filterUsers = $"SELECT * FROM {table} WHERE {where} = {whereValue}";
        return filterUsers;
    }

    public static string UpdateUsers(string table, string set, char setValue, string where, object whereValue)
    {
        string updateUsers =
            $"UPDATE {table} SET {set} = {setValue} WHERE {where} = {whereValue}";
        //$"UPDATE {table} SET \"LastName\"='Zaharova' WHERE \"PersonID\" = 5"; //Апдейт клиента по айди
        return updateUsers;
    }
    public static string RemoveUsers(string table, string where, char whereValue)
    {
        string removeUsers =
            $"DELETE FROM {table} WHERE {where} = {whereValue} "; //Удаление всех клиентов из конкретного города
       // $"DELETE FROM {table} WHERE \"City\"='SPB' "; //Удаление всех клиентов из конкретного города
        return removeUsers;
    }
    
    public static string InsertUsers(string table, Person person)
    {
        string insertUsers = $"INSERT INTO {table} ({person.PersonID},\"FirstName\",\"LastName\",\"Address\",\"City\",\"Gender\") VALUES (55,'Anastasya','Lapova','USA','KZN','F')"; 
        //string insertUsers = $"INSERT INTO {table} (\"PersonID\",\"FirstName\",\"LastName\",\"Address\",\"City\",\"Gender\") VALUES (55,'Anastasya','Lapova','USA','KZN','F')"; 

        return insertUsers;
    }
}