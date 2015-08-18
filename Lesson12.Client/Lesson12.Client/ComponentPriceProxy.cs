using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Lesson12.Core;

namespace Lesson12.Client
{
    public class ComponentPriceProxy : IComponentPrice
    {
        public decimal CpuPrice
        {
            get { return MakeRequest("cpu"); }
        }

        public decimal RamPrice
        {
            get { return MakeRequest("ram"); }
        }

        public decimal SsdPrice
        {
            get { return MakeRequest("ssd"); }
        }

        private decimal MakeRequest(string component)
        {
            using (var client = new TcpClient())
            {
                client.Connect("127.0.0.1", 8080);

                var stream = client.GetStream();

                var data = Encoding.Default.GetBytes(component);

                stream.Write(data, 0, data.Length);

                var rawResponse = new byte[15];
                stream.Read(rawResponse, 0, rawResponse.Length);

                var response = Encoding.Default.GetString(rawResponse);

                return Convert.ToDecimal(response);
            }
        }
    }

}
