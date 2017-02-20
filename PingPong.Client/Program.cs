using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client(1337,"10.0.0.1");
            client.StartCommunicating();
        }
    }
}
