using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ObjectMgmt.Core
{
    public class Server
    {
        public void RunServer(string SrvIP, int SrvPort)
        {
            TcpListener listener = new TcpListener(IPAddress.Any, SrvPort);
            listener.Start();
            while(true)
            {
                Socket socket = listener.AcceptSocket();
                byte[] clientStream = new byte[1024];
                socket.Receive(clientStream);

                string msg = Encoding.ASCII.GetString(clientStream);

                var str = JsonConvert.DeserializeObject<Person>(msg);
                Console.WriteLine(str.ToString());
                string clientIp = (socket.RemoteEndPoint as IPEndPoint).Address.ToString();
                IPAddress clientAddress = IPAddress.Any;
                socket.Close();
                socket.Dispose();
            }
        }
    }
}
