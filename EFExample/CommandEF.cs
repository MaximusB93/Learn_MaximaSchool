using EFExample.Model;
using Microsoft.EntityFrameworkCore;

namespace EFExample;

public class CommandEF
{
    private Verification _verification = new Verification();
    private Notification _notification = new Notification();

    internal async Task SelectUserById(User[] users, DbSet<User> dbUsers, int userId)
    {
        var checkUser = _verification.GetUserId(users, userId);
        if (checkUser != null)

            dbUsers.Remove(checkUser);
        else
            _notification.notFoundUser?.Invoke();
    }

    internal async Task InsertUser(User user, User[] users, DbSet<User> dbUsers)
    {
        var checkUser = _verification.GetUserId(users, user.Id);
        if (checkUser == null)
        {
            dbUsers.Add(user);
            _notification.addUser?.Invoke();
        }

        else
            _notification.foundUser?.Invoke();
    }

    internal async Task RemoveUserById(User[] users, DbSet<User> dbUsers, int userId)
    {
        var checkUser = _verification.GetUserId(users, userId);
        if (checkUser != null)

            dbUsers.Remove(checkUser);
        else
            _notification.notFoundUser?.Invoke();
    }

    internal async Task UpdateAgeUserById(User[] users, int userId, int age)
    {
        var checkUser = _verification.GetUserId(users, userId);
        if (checkUser != null)

            checkUser.Age = age;
        else
            _notification.notFoundUser?.Invoke();
    }
}