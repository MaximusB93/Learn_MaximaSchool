using EFExample;
using EFExample.Model;
using Microsoft.EntityFrameworkCore;

var dbContext = new AppDbContext();
var dbUsers = dbContext.Users;
var users = dbUsers.ToArray();


await UpdateUserById(2, 55);
//await RemoveUserById(3);
//await AddUser(users, dbUsers);
users = dbUsers.ToArray();


Console.ReadLine();

async Task AddUser(User[] users, DbSet<User> dbSet)
{
    var user = new User(3, "Petr", 30);
    if (users.All(x => x.id != user.id))
    {
        dbSet.Add(user);
        await Save();
    }
}

async Task RemoveUserById(int userId)
{
    var user = GetUserId(users, userId);
    if (user != null)
    {
        dbUsers.Remove(user);
        await Save();
    }
}

async Task UpdateUserById(int userId, int age)
{
    var user = GetUserId(users, userId);
    if (user != null)
    {
        user.Age = age;
        await Save();
    }
}

async Task Save()
{
    await dbContext.SaveChangesAsync();
}

User? GetUserId(User[]? users, int userId)
{
    return users.FirstOrDefault(x => x.id == userId);
}