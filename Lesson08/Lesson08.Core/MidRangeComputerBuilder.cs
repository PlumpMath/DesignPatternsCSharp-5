using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson08.Standard;
using Lesson08.ThirdParty;

namespace Lesson08.Core
{
    // adapter
    public class MidRangeComputerBuilder : ComputerBuilder
    {
        private readonly CustomComputerBuilder _builder = new CustomComputerBuilder();

        public override void SetCores()
        {
            _builder.InputCores(4);
        }

        public override void SetCpuFrequency()
        {
            _builder.InputCpuClock(2.5m);
        }

        public override void SetRam()
        {
            _builder.InputRamConfiguration(8);
        }

        public override void SetDriveType()
        {
            _builder.InputDrive("hdd");
        }

        public override Computer GetComputer()
        {
            return _builder.GetComputer();
        }
    }
}
