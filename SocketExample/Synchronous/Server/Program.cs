using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server
{   
    class Program
    {
        //클라이언트로 부터 오는 데이터
        public static string data = null;
        
        public static void StartListening()
        {
            //들어오는 데이터 버퍼
            byte[] bytes = new Byte[1024];

            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress , 11000);

            //소켓생성TCP/IP
            Socket listener = new Socket(ipAddress.AddressFamily,SocketType.Stream,ProtocolType.Tcp);

            //바인드소켓
            //접속시도 리슨
            try{
                listener.Bind(localEndPoint);
                listener.Listen(10);

                //리스닝 시작
                while(true)
                {
                    Console.WriteLine("waiting for a connection");

                    //접속시도가 있을때까지 프로그램은 정지
                    Socket handler = listener.Accept();
                    data = null;

                    //접속시도시 데이터 진행필요
                    while(true)
                    {
                        int bytesRec = handler.Receive(bytes);
                        data += Encoding.ASCII.GetString(bytes,0,bytesRec);
                        if(data.IndexOf("<EOF>") > -1)
                        {
                            break;
                        }
                    }

                    //콘솔창에 데이터 보여주기
                    Console.WriteLine("Text Recvied : {0}",data);

                    //데이터 클라이언트로 보내기
                    byte[] msg =Encoding.ASCII.GetBytes(data);

                    handler.Send(msg);
                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("\nPress Enter to continue");
            Console.Read();
            

        }
        static void Main(string[] args)
        {
           StartListening();
         
        }
    }
}
