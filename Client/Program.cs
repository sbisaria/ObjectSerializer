using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ObjectDataMgmt.Core
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p = new Person();
            Console.WriteLine("Enter First Name :");
            string first = Console.ReadLine();

            Console.WriteLine("Enter Last Name :");
            string last = Console.ReadLine();

            Name name = new Name(first,last);
            p.FullName = name;

            Console.WriteLine("Enter date of birth: (mm/dd/yyyy)");
            var date = DateTime.Parse(Console.ReadLine());
            p.DateOfBirth=date;

            Console.WriteLine("Enter Age :");
            var age = Int32.Parse(Console.ReadLine());
            p.Age = age;

            var personObj = JsonConvert.SerializeObject(p);
            string serverIp = "172.16.14.108";
            int serverPort = 8080;
            TcpClient client = new TcpClient(serverIp, serverPort);
            NetworkStream nw = client.GetStream();
            byte[] bytes = Encoding.ASCII.GetBytes(personObj);
            nw.Write(bytes, 0, bytes.Length);
        }
    }
}
