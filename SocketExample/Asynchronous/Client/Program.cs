using System;  
using System.Net;  
using System.Net.Sockets;  
using System.Threading;  
using System.Text;  

namespace Client
{
    public class StateObject
    {
        public Socket workSocket = null;
        public const int bufferSize =256;
        public byte [] buffer = new byte[bufferSize];
        public StringBuilder sb = new StringBuilder();
    }
    class Program
    {
        private const int port = 11000;

        private static ManualResetEvent connectDone = new ManualResetEvent(false);
        private static ManualResetEvent sendDone = new ManualResetEvent(false);
        private static ManualResetEvent receiveDone = new ManualResetEvent(false);
        private static String response = String.Empty;

        private static void StartClient()
        {
            try
            {
                IPHostEntry ipHostInfo = Dns.GetHostEntry("host.contoso.com");
                IPAddress ipAddress = ipHostInfo.AddressList[0];
                IPEndPoint remoteEP = new IPEndPoint(ipAddress,port);

                //클라이언트 TCP/IP
                Socket client = new Socket(ipAddress.AddressFamily,SocketType.Stream,ProtocolType.Tcp);

                //remote endpoint 접속
                client.BeginConnect(remoteEP, new AsyncCallback(ConnectCallback),client);
                connectDone.WaitOne();

                //리모트 디바이스에 데이터 보내기
                Send(client,"This is a test<EOF>");
                sendDone.WaitOne();

                //리모트 디바이스로부터 리시브 응답
                Receive(client);
                receiveDone.WaitOne();

                //콘솔창에 응답 보여주기
                Console.WriteLine("Response received : {0}",response);

                //소켓 해제
                client.Shutdown(SocketShutdown.Both);
                client.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private static void ConnectCallback(IAsyncResult ar)
        {
            try
            {
                Socket client = (Socket)ar.AsyncState;

                client.EndConnect(ar);

                Console.WriteLine("Socket connected to {0}",client.RemoteEndPoint.ToString());

                connectDone.Set();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        private static void Receive(Socket client)
        {
            try
            {
                StateObject state = new StateObject();
                state.workSocket = client;

                client.BeginReceive(state.buffer,0,StateObject.bufferSize,0, new AsyncCallback(ReceiveCallback),state);                
            }
            catch(Exception e)
            {
                 Console.WriteLine(e.ToString());
            }
        }
        private static void ReceiveCallback( IAsyncResult ar)
        {
            try
            {
                StateObject state =(StateObject)ar.AsyncState;
                Socket client = state.workSocket;

                int bytesRead = client.EndReceive(ar);

                if(bytesRead > 0)
                {
                    state.sb.Append(Encoding.ASCII.GetString(state.buffer,0,bytesRead));
                    client.BeginReceive(state.buffer,0,StateObject.bufferSize,0, new AsyncCallback(ReceiveCallback),state);                
                }
                else
                {
                    if(state.sb.Length > 1)
                    {
                        response = state.sb.ToString();
                    }
                    receiveDone.Set();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private static void Send(Socket client, String data)
        {
            byte[] byteData = Encoding.ASCII.GetBytes(data);
            client.BeginSend(byteData,0,byteData.Length,0, new AsyncCallback(SendCallback),client);
        }

        private static void SendCallback(IAsyncResult ar)
        {
            try
            {
                Socket client = (Socket)ar.AsyncState;
                int bytesSent = client.EndSend(ar);
                Console.WriteLine("Sent{0} bytes to server.",bytesSent);
                sendDone.Set();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        static void Main(string[] args)
        {
            StartClient();
        }
    }
}
