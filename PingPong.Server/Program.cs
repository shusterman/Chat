using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            var server= new Server(1337);
            server.InitializeServer();
        }
    }
}
