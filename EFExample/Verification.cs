using EFExample.Model;

namespace EFExample;

public class Verification
{
    //Проверка по ID
    public User? GetUserId(User[]? users, int userId)
    {
        return users.FirstOrDefault(x => x.Id == userId);
    }
}