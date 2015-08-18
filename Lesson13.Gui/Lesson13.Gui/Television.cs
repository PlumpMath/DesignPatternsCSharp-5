using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13.Gui
{
    // receiver
    public class Television
    {
        private readonly IPAddress _ipAddress;
        private readonly int _port;

        public Television(string ipAddress, int port)
            : this(IPAddress.Parse(ipAddress), port) { }

        public Television(IPAddress ipAddress, int port)
        {
            _ipAddress = ipAddress;
            _port = port;
        }

        public void Send(string command)
        {
            using (var client = new TcpClient())
            {
                client.Connect(_ipAddress, _port);

                var stream = client.GetStream();
                var writer = new StreamWriter(stream);
                writer.AutoFlush = true;

                writer.WriteLine(command);
                client.Close();
            }
        }
    }
}
