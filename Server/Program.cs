    using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ObjectMgmt.Core
{
    class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server();
            server.RunServer("172.16.14.108",8080);
        }
    }
}
