using System.Diagnostics.Metrics;
using WebApiModel;

namespace TestWebAPI;

public class RecordsHolder
{
    public static WeatherForecast? Max { get; set; }
    public static WeatherForecast? Min { get; set; }
    public static List<WeatherForecast> History;

    static RecordsHolder()
    {
        History = new List<WeatherForecast>();
    }

    public static void AddForecast(WeatherForecast weatherForecast)
    {
        History.Add(weatherForecast);
    }
}