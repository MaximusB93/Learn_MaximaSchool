using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AsyncTestUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();

        private string[] _url = new[]
        {
            "https://yandex.ru",
            "https://google.ru",
            "https://vk.com",
            "https://msdn.com",
            "https://yandex.ru",
            "https://google.ru",
            "https://vk.com",
            "https://msdn.com",
            "https://yandex.ru",
            "https://google.ru",
            "https://vk.com",
            "https://msdn.com"
        };

        public MainWindow()
        {
            InitializeComponent();
        }

//var1
        private string LoadAllData()
        {
            StringBuilder sb = new StringBuilder();
            var time = Stopwatch.StartNew();

            //var1
            foreach (var url in _url)
            {
                var result = LoadData(url);
                sb.AppendLine($"URL {url} - {result}");
            }

            time.Stop();
            sb.AppendLine($"Total time - {time.ElapsedMilliseconds}ms");
            return sb.ToString();
        }

//var1
        private string LoadAllDataParallel()
        {
            StringBuilder sb = new StringBuilder();
            object _sync = new object();
            var time = Stopwatch.StartNew();


            Parallel.ForEach(_url, url =>
            {
                var result = LoadData(url);
                lock (_sync)
                {
                    sb.AppendLine($"URL {url} - {result}");
                }

                Task.Delay(TimeSpan.FromMilliseconds(0.5));
            });

            time.Stop();
            sb.AppendLine($"Total time - {time.ElapsedMilliseconds}ms");
            return sb.ToString();
        }

//var2
        private Task<string> LoadAllDataTasks()
        {
            return Task.Run(() =>
            {
                StringBuilder sb = new StringBuilder();
                object _sync = new object();
                var time = Stopwatch.StartNew();
                var listTasks = new List<Task>();
                foreach (var url in _url)
                {
                    var task = new Task(async () =>
                    {
                        var result = await LoadDataAsync(url);
                        lock (_sync)
                        {
                            sb.AppendLine($"URL {url} - {result}");
                        }

                        Task.Delay(TimeSpan.FromMilliseconds(0.5));
                    });
                    task.Start();
                    listTasks.Add(task);
                }

                Task.WaitAll(listTasks.ToArray());
                time.Stop();
                sb.AppendLine($"Total time - {time.ElapsedMilliseconds}ms");
                return sb.ToString();
            });
        }

        private async Task<string> LoadAllDataTasksAsync()
        {
            StringBuilder sb = new StringBuilder();
            var time = Stopwatch.StartNew();
            foreach (var url in _url)
            {
                if (_cancellationTokenSource.IsCancellationRequested)
                {
                    sb.AppendLine("Была запрошена отмена");
                    break;
                }

                var result = await LoadDataAsync(url);
                sb.AppendLine($"URL {url} - {result}");
            }

            time.Stop();
            sb.AppendLine($"Total time - {time.ElapsedMilliseconds}ms");
            return sb.ToString();
        }

        private string LoadData(string url)
        {
            var time = Stopwatch.StartNew();
            WebClient webClient = new WebClient();
            try
            {
                var result = webClient.DownloadString(url);
                time.Stop();
                return $"SIZE - {result.Length}. Time - {time.ElapsedMilliseconds}ms";
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private async Task<string> LoadDataAsync(string url)
        {
            var time = Stopwatch.StartNew();
            WebClient webClient = new WebClient();
            try
            {
                var result = await webClient.DownloadStringTaskAsync(url);

                time.Stop();
                return $"SIZE - {result.Length}. Time - {time.ElapsedMilliseconds}ms";
            }
            catch (WebException e)
            {
                return $"Error {url}. {e.Message}";
            }
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            StatusLogTextBlock.Text = LoadAllData();
        }

        private void Parallel_OnClick(object sender, RoutedEventArgs e)
        {
            StatusLogTextBlock.Text = LoadAllDataParallel();
        }

        private async void Tasks_OnClick(object sender, RoutedEventArgs e)
        {
            _cancellationTokenSource = new CancellationTokenSource();
            ButtonTask.IsEnabled = false;
            ButtonCancel.IsEnabled = true;

            StatusLogTextBlock.Text = await LoadAllDataTasksAsync();

            ButtonTask.IsEnabled = true;
            ButtonCancel.IsEnabled = false;
        }

        private async void Cancel_OnClick(object sender, RoutedEventArgs e)
        {
            _cancellationTokenSource.Cancel();
        }
    }
}