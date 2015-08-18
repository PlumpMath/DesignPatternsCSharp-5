using Lesson08.Standard;

namespace Lesson08.ThirdParty
{
    public abstract class ThirdPartyBuilder
    {
        protected readonly Computer ComputerObject = new Computer();

        public abstract void InputCores(int amount);
        public abstract void InputCpuClock(decimal frequency);
        public abstract void InputRamConfiguration(int amount);
        public abstract void InputDrive(string type);
        public abstract Computer GetComputer();
    }
}
