using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace PingPong.Client
{
    internal class Client
    {
        private readonly string _ipAddress;
        private readonly int _portNumber;
        private readonly TcpClient _tcpClient;
        public Client(int portNumber, string ipAddress)
        {
            _portNumber = portNumber;
            _ipAddress = ipAddress;
            _tcpClient = new TcpClient(_ipAddress, _portNumber);
        }

        public void StartCommunicating()
        {
            var stream = _tcpClient.GetStream();
            WriteFirstMessage(stream);
            while (true)
            {
                HandleIncomingData(stream);
            }
        }

        private static void WriteFirstMessage(NetworkStream stream)
        {
            if (stream == null) throw new ArgumentNullException("stream is null!");
            var test = "message";
            stream.Write(Encoding.ASCII.GetBytes(test), 0, test.Length);
        }
        private static void HandleIncomingData(NetworkStream stream)
        {
            StreamHandler.HandleStream(stream);
        }
    }
}
