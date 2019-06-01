using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Collections.Specialized;
using System.Collections;

namespace AsyncCallback_대리자사용
{
    class Program
    {
        static int requestCounter;
        static ArrayList hostData = new ArrayList();
        static StringCollection hostNames = new StringCollection();

        static void UpdateUserInterface()
        {
            Console.WriteLine("{0} request remaining",requestCounter);
        }
        static void Main(string[] args)
        {
            AsyncCallback callBack = new AsyncCallback(ProcessDnsInformation);
            string host;
            do
            {
                Console.Write("Enter the name of a host computer or <enter> to finish: ");
                host = Console.ReadLine();
                if(host.Length > 0)
                {
                    Interlocked.Increment(ref requestCounter);
                    Dns.BeginGetHostEntry(host,callBack,host);
                }
            }while(host.Length > 0);

            while( requestCounter > 0)
            {
                UpdateUserInterface();
            }
            for( int i = 0 ; i < hostNames.Count ; i++ )
            {
                object data = hostData[i];
                string message = data as string;

                if(message != null)
                {
                    Console.WriteLine("Request for {0} returned message: {1}",hostNames[i],message);
                    continue;
                }
                
                IPHostEntry h = (IPHostEntry) data;
                string [] aliases = h.Aliases;
                IPAddress[] addresses = h.AddressList;

                if(aliases.Length > 0)
                {
                    Console.WriteLine("Aliases for {0}", hostNames[i]);
                    for( int j = 0 ; j < aliases.Length ; j++)
                    {
                        Console.WriteLine("{0}",aliases[j]);
                    }
                }

                if(addresses.Length > 0)
                {
                    Console.WriteLine("Address for {0}",hostNames[i]);
                    for(int k =0 ; k < addresses.Length; k++)
                    {
                        Console.WriteLine("{0}",addresses[k].ToString());
                    }
                }
            }
        }
        static void ProcessDnsInformation(IAsyncResult result)
        {
            string hostName = (string)result.AsyncState;
            hostNames.Add(hostName);
            try
            {
                IPHostEntry host = Dns.EndGetHostEntry(result);
                hostData.Add(host);
            }
            catch(SocketException e)
            {
                hostData.Add(e.Message);                
            }
            finally
            {
                Interlocked.Decrement(ref requestCounter);
            }
        }
    }
}
