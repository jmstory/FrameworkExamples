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
using System.Net.Http;
using System.Net;

namespace ControlFlow
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //ss/tls 보안채널 생성불가
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            //1
            resultsTextBox.Text += "ONE:   Entering startButton_Click.\r\n" +
               "           Calling AccessTheWebAsync.\r\n";

            //4
            Task<int> getLengthTask = AccessTheWebAsync();

            resultsTextBox.Text += "\r\nFOUR:  Back in startButton_Click.\r\n" +
                "           Task getLengthTask is started.\r\n" +
                "           About to await getLengthTask -- no caller to return to.\r\n";

            int contentLength = await getLengthTask;

            resultsTextBox.Text += "\r\nSIX:   Back in startButton_Click.\r\n" +
                "           Task getLengthTask is finished.\r\n" +
                "           Result from AccessTheWebAsync is stored in contentLength.\r\n" +
                "           About to display contentLength and exit.\r\n";

            //6
            resultsTextBox.Text +=
                $"\r\nLength of the downloaded string: {contentLength}.\r\n";

        }

        async Task<int> AccessTheWebAsync()
        {
            resultsTextBox.Text += "\r\nTWO:   Entering AccessTheWebAsync.";
           
            //2
            HttpClient client = new HttpClient();

            resultsTextBox.Text += "\r\n           Calling HttpClient.GetStringAsync.\r\n";

            Task<string> getStringTask = client.GetStringAsync("https://msdn.microsoft.com");

            resultsTextBox.Text += "\r\nTHREE: Back in AccessTheWebAsync.\r\n" +
            "           Task getStringTask is started.";
                        
            resultsTextBox.Text +=
            "\r\n           About to await getStringTask and return a Task<int> to startButton_Click.\r\n";

            //3
            string urlContents = await getStringTask;

            resultsTextBox.Text += "\r\nFIVE:  Back in AccessTheWebAsync." +
            "\r\n           Task getStringTask is complete." +
            "\r\n           Processing the return statement." +
            "\r\n           Exiting from AccessTheWebAsync.\r\n";

            //5
            return urlContents.Length;
        }
    }
}
