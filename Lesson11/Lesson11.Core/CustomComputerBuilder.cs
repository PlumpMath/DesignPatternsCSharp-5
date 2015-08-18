using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11.Core
{
    public class CustomComputerBuilder : ComputerBuilder
    {
        public override void SetCores(int amount)
        {
            _computer.AmountOfCores = amount;
        }

        public override void SetCpuFrequency(decimal frequency)
        {
            _computer.CpuFrequency = frequency;
        }

        public override void SetRam(int amount)
        {
            _computer.AmountOfRam = amount;
        }

        public override void SetDriveType(string type)
        {
            _computer.DriveType = type;
        }
    }
}
