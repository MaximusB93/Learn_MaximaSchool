using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using JSONTest;
using Newtonsoft.Json;

var mother = new Mother("Ольга", 58);
var user = new User("Иван", 37, mother, new[] { "Маша", "Даша" }, true, null);

var json = JsonConvert.SerializeObject(user);

var userFromJson = JsonConvert.DeserializeObject<User>(json);

Console.WriteLine(json);

