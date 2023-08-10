using System;
using System.Diagnostics;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

// Написать консольную программу, которая не блокируя основной поток опрашивает сайты
// "http://yandex.ru",
// "http://google.ru",
// "http://vk.com",
// "http://msdn.com",
//
// c помощью WebClient.DownloadStringTaskAsync и возвращает на экран самый быстропришедший ответ.
// Остальные запросы нужно отменять через CancelationToken. Используя Task и async/await
namespace Project1
{
    internal class Program
    {
        private static string[] _url = new[]
        {
            "https://yandex.ru",
            "https://google.com",
            "https://vk.com",
            "https://msdn.com"
        };

        private static CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();

        static void Main(string[] args)
        {
            GetResponce().Wait();
        }

        public static async Task<string> GetResponce()
        {
            Stopwatch time = Stopwatch.StartNew();
            StringBuilder sb = new StringBuilder();

            foreach (var url in _url)
            {
                if (_cancellationTokenSource.IsCancellationRequested)
                {
                    sb.AppendLine("Была запрошена отмена");
                    break;
                }

                var result = await LoadAllData(url);
                Console.WriteLine(sb.AppendLine($"{url} - {result}"));
            }

            time.Stop();
            Task.Delay(1000);
            Console.WriteLine(sb.AppendLine($"Total time - {time.ElapsedMilliseconds}ms"));
            return sb.ToString();
        }

        public static async Task<string> LoadAllData(string url)
        {
            var time = Stopwatch.StartNew();
            WebClient webClient = new WebClient();
            try
            {
                var body = await webClient.DownloadStringTaskAsync(url);
                _cancellationTokenSource.Cancel();
                time.Stop();
                return $"SIZE - {body.Length}. Time - {time.ElapsedMilliseconds}ms";
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}