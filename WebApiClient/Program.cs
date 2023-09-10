using System.Net.Http.Json;
using Newtonsoft.Json;
using WebApiModel;
using System.Linq;

string url = "http://localhost:9999/WeatherForecast";

HttpClient httpClient = new HttpClient();
var responce = await httpClient.GetAsync(url);
if (responce.IsSuccessStatusCode)
{
    Console.WriteLine("Got responce:");
    string result = await responce.Content.ReadAsStringAsync();
    WeatherForecast[] forecasts = JsonConvert.DeserializeObject<WeatherForecast[]>(result);
    var _max = forecasts.Select(x => x.TemperatureC).Max();
    var _min = forecasts.Select(x => x.TemperatureC).Min();



    var Max = httpClient.GetAsync("http://localhost:9999/WeatherForecast/max");
    //var json = JsonConvert.DeserializeObject<WeatherForecast>(Max);
    
    var MaxFromServer = await httpClient.GetFromJsonAsync<WeatherForecast>("http://localhost:9999/WeatherForecast/max");
    var MinFromServer = await httpClient.GetFromJsonAsync<WeatherForecast>("http://localhost:9999/WeatherForecast/min");
    
    
        
    Console.WriteLine(result);
    Console.Read();
}
