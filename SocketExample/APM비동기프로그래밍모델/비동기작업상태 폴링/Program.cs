using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace 비동기작업상태_폴링
{
    class Program
    {
        static void UpdateUserInterface()
        {            
            Console.Write(".");
        }
        static void Main(string[] args)
        {
            if (args.Length == 0 || args[0].Length == 0)
            {
                Console.WriteLine("You must specify the name of a host computer.");
                return;
            }
           
            IAsyncResult result = Dns.BeginGetHostEntry(args[0], null, null);
            Console.WriteLine("Processing request for information...");            
            
            //폴링
            //업데이트가 끝날때까지 (".") 출력
            while (result.IsCompleted != true)
            {
                UpdateUserInterface();
            }
            
            Console.WriteLine();
            try 
            {
                IPHostEntry host = Dns.EndGetHostEntry(result);
                string[] aliases = host.Aliases;
                IPAddress[] addresses = host.AddressList;
                if (aliases.Length > 0)
                {
                    Console.WriteLine("Aliases");
                    for (int i = 0; i < aliases.Length; i++)
                    {
                        Console.WriteLine("{0}", aliases[i]);
                    }
                }
                if (addresses.Length > 0)
                {
                    Console.WriteLine("Addresses");
                    for (int i = 0; i < addresses.Length; i++)
                    {
                        Console.WriteLine("{0}",addresses[i].ToString());
                    }
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine("An exception occurred while processing the request: {0}", e.Message);
            }
        }
    }
}
