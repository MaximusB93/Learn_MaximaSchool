using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
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
        private string[] _url = new[]
        {
            "https://yandex.ru",
            "https://google.ru",
            "https://vk.com",
            "https://msdn.com",
        };

        public MainWindow()
        {
            InitializeComponent();
        }

        private string LoadAllData()
        {
            StringBuilder sb = new StringBuilder();
            object _sync = new object();
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

        private string LoadAllDataParallel()
        {
            StringBuilder sb = new StringBuilder();
            object _sync = new object();
            var time = Stopwatch.StartNew();

            //var2
            Parallel.ForEach(_url, url =>
            {
                var result = LoadData(url);
                lock (_sync)
                {
                    sb.AppendLine($"URL {url} - {result}");
                }
            });

            time.Stop();
            sb.AppendLine($"Total time - {time.ElapsedMilliseconds}ms");
            return sb.ToString();
        }

        private string LoadData(string url)
        {
            var time = Stopwatch.StartNew();
            WebClient webClient = new WebClient();
            var result = webClient.DownloadString(url);
            time.Stop();
            return $"SIZE - {result.Length}. Time - {time.ElapsedMilliseconds}ms";
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            StatusLogTextBlock.Text = LoadAllData();
        }

        private void Parallel_OnClick(object sender, RoutedEventArgs e)
        {
            StatusLogTextBlock.Text = LoadAllDataParallel();
        }
    }
}