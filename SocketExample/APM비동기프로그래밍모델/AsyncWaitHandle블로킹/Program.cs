using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace AsyncWaitHandle블로킹
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 0 || args[0].Length == 0)
            {
                Console.WriteLine("you must specify the name of host computer");
                return;
            }
            IAsyncResult result = Dns.BeginGetHostEntry(args[0],null,null);
            Console.WriteLine("processing request for information");
            result.AsyncWaitHandle.WaitOne();

            try
            {
                IPHostEntry host = Dns.EndGetHostEntry(result);
                string[] aliases = host.Aliases;
                IPAddress[] addresses = host.AddressList;
                if(aliases.Length > 0)
                {
                    Console.WriteLine("Aliases");
                    for( int i = 0 ; i < aliases.Length ; i++)
                    {
                        Console.WriteLine("{0}",aliases[i]);
                    }
                }
                if(addresses.Length > 0)
                {
                    Console.WriteLine("Address");
                    for(int i = 0 ; i < addresses.Length; i++)
                    {
                        Console.WriteLine("{0}",addresses[i].ToString());
                    }
                }
            }
            catch(SocketException e)
            {
                Console.WriteLine("exception occurred while processing the request : {0}" , e.Message);
            }
        }
    }
}
