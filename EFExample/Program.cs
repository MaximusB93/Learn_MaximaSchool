using System.Xml.Schema;
using EFExample;
using EFExample.Model;
using Microsoft.EntityFrameworkCore;

CommandEF _commandEf = new CommandEF();
SaveTable _saveTable = new SaveTable();

await using (var dbContext = new AppDbContext())
{
    /*School school1 = new School(1, "School 2", "MSK");
    School school2 = new School(2, "School 1", "SPB");

    var sc = dbContext.Schools;
    sc.AddRange(school1, school2);
    User user1 = new User(1, "Maxim", 30, school1.Id);
    ;
    User user2 = new User(2, "German", 31, school2.Id);

    var dbUsers = dbContext.Users;
    var users = dbUsers.ToArray();
    dbUsers.Add(user1);
    dbUsers.Add(user2);

    dbContext.SaveChanges();*/

    var data = dbContext.Users
        //.Include(x => x.Id)
        .Where(x => x.School != null)
        .Select(x => new { x.Name, x.School.City });
}


//await _commandEf.InsertUser(new User(77, "Dfyz", 85), users, dbUsers);
//await _saveTable.Save(dbContext);
//await RemoveUserById(3);
//await InsertUser(users, dbUsers);
//users = dbUsers.ToArray();


Console.ReadLine();