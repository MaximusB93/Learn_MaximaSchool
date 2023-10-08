using EFExample;
using EFExample.Model;
using Microsoft.EntityFrameworkCore;

CommandEF _commandEf = new CommandEF();
SaveTable _saveTable = new SaveTable();

var dbContext = new AppDbContext();
var dbUsers = dbContext.Users;
var users = dbUsers.ToArray();
int userAge = 0;
foreach (var user in users)
{
    userAge = user.Age += 1;
}

await _commandEf.InsertUser(new User(77, "Dfyz", 85), users, dbUsers);
await _saveTable.Save(dbContext);
//await RemoveUserById(3);
//await InsertUser(users, dbUsers);
//users = dbUsers.ToArray();


Console.ReadLine();