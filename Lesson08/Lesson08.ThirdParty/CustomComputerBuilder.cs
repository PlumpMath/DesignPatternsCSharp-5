using Lesson08.Standard;

namespace Lesson08.ThirdParty
{
    // adaptee
    public class CustomComputerBuilder : ThirdPartyBuilder
    {
        public override void InputCores(int amount)
        {
            ComputerObject.AmountOfCores = amount;
        }

        public override void InputCpuClock(decimal frequency)
        {
            ComputerObject.CpuFrequency = frequency;
        }

        public override void InputRamConfiguration(int amount)
        {
            ComputerObject.AmountOfRam = amount;
        }

        public override void InputDrive(string type)
        {
            ComputerObject.DriveType = type;
        }

        public override Computer GetComputer()
        {
            return ComputerObject;
        }
    }
}
