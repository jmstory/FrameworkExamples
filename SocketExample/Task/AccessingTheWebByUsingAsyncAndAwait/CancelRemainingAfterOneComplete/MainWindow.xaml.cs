using System;
using System.Collections.Generic;
using System.Linq;
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

using System.Net;
using System.Net.Http;
using System.Threading;
namespace CancelRemainingAfterOneComplete
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        CancellationTokenSource cts;
        public MainWindow()
        {
            //ss/tls 보안채널 생성불가
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            cts = new CancellationTokenSource();

            resultsTextBox.Clear();

            try
            {
                await AccessTheWebAsync(cts.Token);
                resultsTextBox.Text += "\r\nDownload complete.";
            }
            catch (OperationCanceledException)
            {
                resultsTextBox.Text += "\r\nDownload canceled.";
            }
            catch (Exception)
            {
                resultsTextBox.Text += "\r\nDownload failed.";
            }

            // Set the CancellationTokenSource to null when the download is complete.  
            cts = null;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (cts != null)
            {
                cts.Cancel();
            }
        }

        async Task AccessTheWebAsync(CancellationToken ct)
        {
            HttpClient client = new HttpClient();

            List<string> urlList = SetUpURLList();

            //실행됐을대 쿼리 생성 , 타스크컬렉션에 리턴
            IEnumerable<Task<int>> downloadTaskQuery = from url in urlList select ProcessURLAsync(url, client, ct);

            //다운로드 시작과 쿼리 실행시 ToArray사용
            Task<int>[] downloadTasks = downloadTaskQuery.ToArray();

            //
            Task<int> firstFinishedTask = await Task.WhenAny(downloadTasks);

            cts.Cancel();

            //처음 완료시 결과를 보여준다
            // 
            var length = await firstFinishedTask;            
            resultsTextBox.Text += $"\r\nLength of the downloaded website:  {length}\r\n";

        }

        async Task<int> ProcessURLAsync(string url, HttpClient client, CancellationToken ct)
        {
            // GetAsync returns a Task<HttpResponseMessage>.   
            HttpResponseMessage response = await client.GetAsync(url, ct);

            // Retrieve the website contents from the HttpResponseMessage.  
            byte[] urlContents = await response.Content.ReadAsByteArrayAsync();

            return urlContents.Length;
        }

        private List<string> SetUpURLList()
        {
            List<string> urls = new List<string>
            {
                "https://msdn.microsoft.com",
                "https://msdn.microsoft.com/library/hh290138.aspx",
                "https://msdn.microsoft.com/library/hh290140.aspx",
                "https://msdn.microsoft.com/library/dd470362.aspx",
                "https://msdn.microsoft.com/library/aa578028.aspx",
                "https://msdn.microsoft.com/library/ms404677.aspx",
                "https://msdn.microsoft.com/library/ff730837.aspx"
            };
            return urls;
        }

    }
}
