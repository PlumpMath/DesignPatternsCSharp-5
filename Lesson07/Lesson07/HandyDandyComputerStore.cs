using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson07
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
