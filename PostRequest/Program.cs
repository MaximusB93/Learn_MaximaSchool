using System.Net.Http.Headers;
using System.Text;

var client = new HttpClient();
client.BaseAddress = new Uri("https://ru.envybox.io");
var request = new HttpRequestMessage(HttpMethod.Post, "/user/sites/");

var byteArray = new UTF8Encoding().GetBytes("<clientid>:<clientsecret>");
client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

var formData = new List<KeyValuePair<string, string>>();
formData.Add(new KeyValuePair<string, string>("grant_type", "password"));
formData.Add(new KeyValuePair<string, string>("username", "<email>"));
formData.Add(new KeyValuePair<string, string>("password", "<password>"));
formData.Add(new KeyValuePair<string, string>("scope", "all"));

request.Content = new FormUrlEncodedContent(formData);
var response = await client.SendAsync(request);