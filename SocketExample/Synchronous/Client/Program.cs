using System;  
using System.Net;  
using System.Net.Sockets;  
using System.Text;  

namespace Client
{
    class Program
    {
        public static void StartClient()
        {
            //데이터 버퍼
            byte[] bytes = new byte[1024];

            //접속
            try
            {
                IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress ipAddress = ipHostInfo.AddressList[0];
                IPEndPoint remoteEP = new IPEndPoint(ipAddress,11000);

                //소켓생성TCP/IP
                Socket sender = new Socket(ipAddress.AddressFamily,SocketType.Stream,ProtocolType.Tcp);

                //소켓 접속 to 리모트 엔드포인트. 에러 캐치
                try
                {
                    sender.Connect(remoteEP);
                    Console.WriteLine("socket connected to {0}",sender.RemoteEndPoint.ToString());

                    //바이트 어레이에 문자열 데이터 쓰기
                    byte[] msg = Encoding.ASCII.GetBytes("this is a test<EOF>");

                    //소켓을 통해 데이터 전송
                    int byteSent = sender.Send(msg);

                    //리모트 디바이스에서 응답받기
                    int bytesRec = sender.Receive(bytes);
                    Console.WriteLine("echoed test = {0}",Encoding.ASCII.GetString(bytes,0,bytesRec));

                    //소켓해제
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();
                }
                catch(ArgumentException ane)
                {
                    Console.WriteLine("ArgumentException : {0}",ane.ToString());
                }
                catch(SocketException se)
                {
                    Console.WriteLine("SocketException : {0}",se.ToString());
                }
                 catch(Exception  e)
                {
                    Console.WriteLine("Exception  : {0}",e.ToString());
                }
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
