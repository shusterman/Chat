using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public static class LocalIPAddressReceiver
    {
        public static IPEndPoint GetLocalIpEndPoint(int portNumber)
        {
            var ipAddress = GetLocalHostIP();
            return new IPEndPoint(ipAddress, portNumber);
        }

        public static IPAddress GetLocalHostIP()
        {
            if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                return null;
            }

            var host = Dns.GetHostEntry(Dns.GetHostName());

            return host
                .AddressList
                .FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork);
        }
    }
}
