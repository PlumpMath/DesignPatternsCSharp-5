using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson12.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var prices = new ComponentPriceProxy();

            Console.WriteLine("CPU Price: {0}", prices.CpuPrice);
            Thread.Sleep(500);
            Console.WriteLine("RAM Price: {0}", prices.RamPrice);
            Thread.Sleep(500);
            Console.WriteLine("SSD Price: {0}", prices.SsdPrice);

            // subject
            // realsubject
            // proxy

            Console.ReadLine();
        }
    }
}
