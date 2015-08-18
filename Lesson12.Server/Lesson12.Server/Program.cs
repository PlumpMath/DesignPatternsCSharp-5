using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            var ip = IPAddress.Parse("127.0.0.1");
            var listener = new TcpListener(ip, 8080);

            while (true)
            {
                listener.Start();
                Console.WriteLine("Waiting for Connection...");

                using (var socket = listener.AcceptSocket())
                {
                    Console.WriteLine("Client Connected.");

                    var data = new byte[15];
                    socket.Receive(data);
                    var input = Encoding.Default.GetString(data).TrimEnd('\0');

                    Console.WriteLine("Client requested: {0}", input);

                    var prices = new StoredComponentPrices();

                    var price = 0m;

                    switch (input)
                    {
                        case "cpu":
                            price = prices.CpuPrice;
                            break;
                        case "ram":
                            price = prices.RamPrice;
                            break;
                        case "ssd":
                            price = prices.SsdPrice;
                            break;
                    }

                    var responseValue = Convert.ToString(price);
                    var response = Encoding.Default.GetBytes(responseValue);

                    socket.Send(response);

                    Console.WriteLine("Response sent to Client: {0}", responseValue);
                    Console.WriteLine();

                }
                

                listener.Stop();
            }
        }
    }
}
