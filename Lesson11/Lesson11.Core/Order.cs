using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11.Core
{
    public class Order
    {
        public decimal CpuFrequency { get; set; }
        public int AmountOfCores { get; set; }
        public string DriveType { get; set; }
        public int AmountOfRam { get; set; }

        public decimal Price
        {
            // we'd definitely not want this hard coded
            // but for the sake of simplicity...
            get { return 1000m; }
        }
    }
}
