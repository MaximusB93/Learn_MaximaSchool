using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ClientWebApi
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var http = new HttpClient();
            var url = "http://localhost:5085/WeatherForecast";
            var response = await http.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                Console.WriteLine(result);
                Console.ReadLine();
            }
           
        }
    }
}
 