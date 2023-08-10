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
        static bool execute = false;
        private static object _sync = new object();

        private static string[] _url = new[]
        {
            "https://google.com",
            "https://vk.com",
            "https://msdn.com",
            "https://yandex.ru",
            "https://youtube.com",
            "https://ya.ru"
        };

        private static CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();
        private static CancellationToken _token = _cancellationTokenSource.Token;

        static void Main(string[] args)
        {
            foreach (var url in _url)
            {
                LoadAllData(url);
            }

            Console.ReadLine();
        }

        public static async Task LoadAllData(string url)
        {
            var time = Stopwatch.StartNew();
            WebClient webClient = new WebClient();
            try
            {
                var body = await webClient.DownloadStringTaskAsync(url);
                time.Stop();
                Finish(url, $"SIZE - {body.Length}. Time - {time.ElapsedMilliseconds}ms");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public static void Finish(string url, string data)
        {
            lock (_sync)
            {
                if (_token.IsCancellationRequested)
                {
                    Console.WriteLine("Была запрошена отмена");
                    return;
                }

                _cancellationTokenSource.Cancel();
                Console.WriteLine($"{url} - {data}");
            }
        }
    }
}