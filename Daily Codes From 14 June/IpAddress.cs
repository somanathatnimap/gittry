using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Codes_From_14_June
{
    internal class IpAddress
    {
        static void Main(string[] args)
        {
            IpAddress ipaddress = new IpAddress();
            string hostname=Dns.GetHostName();
            Console.WriteLine("My Host Name is "+hostname);
            string a;
            string id = Dns.GetHostByName(hostname).AddressList[0].ToString();
            Console.WriteLine("my ip address is "+id);
            Console.ReadLine();
        }
    }
}
