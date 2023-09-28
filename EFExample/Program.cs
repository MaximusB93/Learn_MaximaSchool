using EFExample;
using EFExample.Model;
using Microsoft.EntityFrameworkCore;

CommandEF _commandEf = new CommandEF();
SaveTable _saveTable = new SaveTable();

var dbContext = new AppDbContext();
var dbUsers = dbContext.Users;
var users = dbUsers.ToArray();


await _commandEf.InsertUser(new User(5, "Pavel", 42), users, dbUsers);
await _saveTable.Save(dbContext);
//await RemoveUserById(3);
//await InsertUser(users, dbUsers);
//users = dbUsers.ToArray();


Console.ReadLine();