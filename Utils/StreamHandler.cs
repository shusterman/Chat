using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public static class StreamHandler
    {
        public static void HandleStream(NetworkStream stream)
        {
            var data = new byte[1024];
            var bytes = stream.Read(data, 0, data.Length);
            var responseData = Encoding.ASCII.GetString(data, 0, bytes);
            var response_data = Encoding.ASCII.GetBytes(responseData);
            Console.WriteLine(responseData);
            stream.Write(response_data, 0, response_data.Length);
        }
    }
}
