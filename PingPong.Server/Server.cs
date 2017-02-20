using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Utils;


namespace PingPong.Server
{
    class Server
    {
        private readonly int _portNumber;
        private readonly IPEndPoint _localEndPoint;
        public Server(int portNumber)
        {
            _portNumber = portNumber;
        }

        public void InitializeServer()
        {
            var server = new TcpListener(LocalIPAddressReceiver.GetLocalIpEndPoint(_portNumber));
            server.Start();
            var client = server.AcceptTcpClient();
            var stream = client.GetStream();
            while (true)
            {
                HandleIncomingData(stream);
            }

        }

        public void HandleIncomingData(NetworkStream stream)
        {
           StreamHandler.HandleStream(stream);
        }


    }
}
