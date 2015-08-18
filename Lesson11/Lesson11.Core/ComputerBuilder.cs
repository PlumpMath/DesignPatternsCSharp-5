namespace Lesson11.Core
{
    public abstract class ComputerBuilder
    {
        protected readonly Computer _computer = new Computer();
        public abstract void SetCores(int amount);
        public abstract void SetCpuFrequency(decimal frequency);
        public abstract void SetRam(int amount);
        public abstract void SetDriveType(string type);

        public virtual Computer GetComputer()
        {
            return _computer;
        }
    }
}