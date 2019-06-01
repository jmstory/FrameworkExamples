using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Collections;

namespace AsyncCallback대리자_및_상태개체
{
    public class HostRequest
    {
        private string hostName;
        private SocketException e;
        private IPHostEntry entry;

        public HostRequest(string name)
        {
            hostName = name;
        }

        public string HostName
        {
            get{ return hostName;}            
        }

        public SocketException ExceptionObject
        {
            get{ return e;}
            set{ e = value;}
        }

        public IPHostEntry HostEntry
        {
            get{return entry;}
            set{entry = value;}
        }
    }
    class Program
    {
        static int requestCounter;
        static ArrayList hostData = new ArrayList();
        static void UpdateUserInterface()
        {
            Console.WriteLine("{0} requests remaining.", requestCounter);
        }

        static void Main(string[] args)
        {
            AsyncCallback callBack = new AsyncCallback(ProcessDnsInformation);
            string host;
            do
            {
                Console.Write(" Enter the name of a host computer or <enter> to finish: ");
                host = Console.ReadLine();
                if (host.Length > 0)
                {
                    Interlocked.Increment(ref requestCounter);                    
                    HostRequest request = new HostRequest(host);
                    hostData.Add(request);                    
                    Dns.BeginGetHostEntry(host, callBack, request);
                 }
            } while (host.Length > 0);

            while(requestCounter > 0)
            {
                UpdateUserInterface();
            }

            foreach(HostRequest r in hostData)
            {
                if(r.ExceptionObject != null)
                {
                    Console.WriteLine("Request for host {0} returned the following error: {1}.", 
                            r.HostName, r.ExceptionObject.Message);
                }
                else
                {
                    IPHostEntry h = r.HostEntry;
                    string[] aliases = h.Aliases;
                    IPAddress[] addresses = h.AddressList;
                    if(aliases.Length > 0)
                    {
                        Console.WriteLine("Aliases for {0}", r.HostName);
                        for(int j = 0 ; j < aliases.Length; j++)
                        {
                            Console.WriteLine("{0}",aliases[j]);
                        }
                    }
                    if(addresses.Length>0)
                    {
                        Console.WriteLine("Addreses for {0}",r.HostName);
                        for(int k = 0 ; k < addresses.Length; k++)
                        {
                            Console.WriteLine("{0}",addresses[k].ToString());
                        }
                    }
                }
            }
        }

        static void ProcessDnsInformation(IAsyncResult result)
        {
           HostRequest request = (HostRequest) result.AsyncState;
            try 
            {
                IPHostEntry host = Dns.EndGetHostEntry(result);
                request.HostEntry = host;
            }
            catch (SocketException e)
            {
                request.ExceptionObject = e;
            }
            finally 
            {
                Interlocked.Decrement(ref requestCounter);
            }
        }
    }
}
