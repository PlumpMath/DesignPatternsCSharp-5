using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson08.Standard;

namespace Lesson08.Core
{
    public class HandyDandyComputerStore
    {
        private static readonly HandyDandyComputerStore _instance = new HandyDandyComputerStore();
        public static HandyDandyComputerStore Instance
        {
            get { return _instance; }
        }

        private HandyDandyComputerStore()
        {
            // initialize
        }

        // client
        public Computer Build(ComputerBuilder builder)
        {
            builder.SetCores();
            builder.SetCpuFrequency();
            builder.SetRam();
            builder.SetDriveType();

            return builder.GetComputer();
        }
    }
}
