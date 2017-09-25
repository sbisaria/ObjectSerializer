using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDataMgmt.Core
{
    public class Manager
    {
        DirectoryInfo directoryInfo;
        public Manager()
        {
            Console.Write("Enter the person name:\t");
            string personName = Console.ReadLine();
            directoryInfo = new DirectoryInfo(@"D:\" );
            if (directoryInfo.Exists)
                Console.WriteLine("Directory found...\n");
            else
            {
                directoryInfo.Create();
                Console.WriteLine("Directory created...\n");
            }
        }
    }
}
