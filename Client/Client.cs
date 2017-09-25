using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDataMgmt.Core
{
    public class Client
    {
        public void runClient() { 
            TcpClient client = new TcpClient("192.168.6.16", 500);
            Console.WriteLine("Try to connect with server...");
            
                Console.WriteLine("Connected...");
                while (true)
                {
                    NetworkStream networkStream = client.GetStream();
            string inputString = Console.ReadLine();
            byte[] message = Encoding.ASCII.GetBytes(inputString);
            int length = message.Length;
            networkStream.Write(message, 0, length);
                    Listener(client);
            }
        }
        public static void Listener(TcpClient client)
        {

             Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    NetworkStream stream = client.GetStream();
                    MemoryStream memory = new MemoryStream();
                    byte[] rec = new byte[1024];
                    using (memory)
                    {
                        do
                        {
                            stream.Read(rec, 0, rec.Length);
                            memory.Write(rec, 0, rec.Length);

                        } while (stream.DataAvailable);
                        string msg = Encoding.ASCII.GetString(memory.ToArray(), 0, (int)memory.Length);
                        Console.WriteLine(msg);
                        memory.Flush();
                    }
                }
            });
        }
    }
}
