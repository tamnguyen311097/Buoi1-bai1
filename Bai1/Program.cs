using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            string strHostName = Dns.GetHostName();
            Console.WriteLine("Host name: " + strHostName);

            //Find host by name
            IPHostEntry iphostentry = Dns.GetHostByName(strHostName);

            // Enumerate IP address
            int nIP = 0;
            foreach (IPAddress ipaddress in iphostentry.AddressList)
                Console.WriteLine("IP " + ++nIP + ":" + ipaddress.ToString());
        }
    }
}
