namespace EFExample;

public class Notification
{
    public Action notFoundUser;
    public Action foundUser;
    public Action addUser;

    public void Notifi()
    {
        notFoundUser += NotFoundUser;
        foundUser += FoundUserId;
        addUser += AddUser;
    }

    public void NotFoundUser()
    {
        Console.WriteLine("Пользователь не найден");
    }

    public void FoundUserId()
    {
        Console.WriteLine("Пользователь с таким ID уже существует");
    }

    public void AddUser()
    {
        Console.WriteLine("Пользователь успешно добавлен");
    }
}