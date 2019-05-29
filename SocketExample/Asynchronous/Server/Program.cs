using System;  
using System.Net;  
using System.Net.Sockets;  
using System.Text;  
using System.Threading;

namespace Server
{
    public class StateObject 
    {         
        public Socket workSocket = null;         
        public const int BufferSize = 1024;  
        public byte[] buffer = new byte[BufferSize];  
        public StringBuilder sb = new StringBuilder();    
    }  
    class Program
    {
        public static ManualResetEvent allDone = new ManualResetEvent(false);
        public Program()
        {

        }

        public static void StartListening()
        {
            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress,11000);

            //소켓생성 TCP/IP
            Socket listner = new Socket(ipAddress.AddressFamily,SocketType.Stream,ProtocolType.Tcp);

            //로컬엔드포인트와 리슨을 바인드
            try
            {
                listner.Bind(localEndPoint);
                listner.Listen(100);

                while(true)
                {
                    //노시그널 스테이트 이벤트 설정
                    allDone.Reset();

                    //asynchronous 소켓에 접속시도 하는것을 시작
                    Console.WriteLine("waiting for a connection.");
                    listner.BeginAccept(new AsyncCallback(AcceptCallback),listner);
                    
                    //접속시도하는동안 대기
                    allDone.WaitOne();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("\nPress Enter to countinue");
            Console.Read();
        }
        public static void AcceptCallback(IAsyncResult ar)
        {
            //시그널 메인스레드
            allDone.Set();

            //클라이언트 리퀘스트 핸들 소켓을 가져온다
            Socket listner = (Socket)ar.AsyncState;
            Socket handler = listner.EndAccept(ar);

            //스테이트 오브젝트 생성
            StateObject state = new StateObject();
            state.workSocket = handler;
            handler.BeginReceive(state.buffer,0,StateObject.BufferSize,0, new AsyncCallback(ReadCallback),state);            
        }

        public static void ReadCallback(IAsyncResult ar)
        {
            String content = String.Empty;

            // Retrieve the state object and the handler socket  
            // from the asynchronous state object.  
            StateObject state = (StateObject) ar.AsyncState;  
            Socket handler = state.workSocket;  

            //클라이언트 소켓으로부터 데이터를 읽는다
            int bytesRead = handler.EndReceive(ar);
            
            if(bytesRead > 0)
            {
                //데이터가 더 있을수 있기때문에 ,데이터를 저장하고 더읽어온다
                state.sb.Append(Encoding.ASCII.GetString(state.buffer,0,bytesRead));

                //end of file 태그를 체크한다. 만약 아니라면 데이터를 더 읽어온다
                content = state.sb.ToString();
                if(content.IndexOf("<EOF>") > - 1)
                {
                    //모든 데이터를 읽었으니 콘솔창에 나타낸다
                    Console.WriteLine("Read {0} bytes from socket. \n Data : {1}",content.Length,content);
                    
                    //데이터를 클라이언트로 다시 보낸다
                    Send(handler,content);
                }
                else
                {
                    //데이터를 다 못읽었으니 더 읽어온다
                    handler.BeginReceive(state.buffer,0,StateObject.BufferSize,0, new AsyncCallback(ReadCallback),state);
                }
            }
        }

        private static void Send(Socket handler , String data)
        {
            byte[] byteData = Encoding.ASCII.GetBytes(data);

            handler.BeginSend(byteData , 0 , byteData.Length,0, new AsyncCallback(SendCallback), handler);
        }

        private static void SendCallback(IAsyncResult ar)
        {
            try
            {
                Socket handler = (Socket)ar.AsyncState;
                
                int bytesSent = handler.EndSend(ar);
                Console.WriteLine("Sent {0} bytes to client",bytesSent);

                handler.Shutdown(SocketShutdown.Both);
                handler.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        static void Main(string[] args)
        {
            StartListening();
        }
    }
}
