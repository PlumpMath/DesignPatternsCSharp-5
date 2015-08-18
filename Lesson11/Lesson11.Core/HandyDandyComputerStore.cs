using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11.Core
{
    public class HandyDandyComputerStore
    {
        public Computer Build(Order order, ComputerBuilder builder)
        {
            builder.SetCores(order.AmountOfCores);
            builder.SetCpuFrequency(order.CpuFrequency);
            builder.SetRam(order.AmountOfRam);
            builder.SetDriveType(order.DriveType);

            Console.WriteLine("Built Computer.");

            return builder.GetComputer();
        }
    }
}
