using Lesson08.Core;
using Lesson08.Standard;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson07.Tests
{
    [TestClass]
    public class BuilderTests
    {
        [TestMethod]
        public void SuperComputerBuilderTest()
        {
            var computer = new Computer
            {
                AmountOfCores = 64,
                AmountOfRam = 256,
                CpuFrequency = 3.4m,
                DriveType = "ssd"
            };

            var builder = new SuperComputerBuilder();

            var superComputer = HandyDandyComputerStore.Instance.Build(builder);

            Assert.AreEqual(superComputer.AmountOfCores, computer.AmountOfCores);
            Assert.AreEqual(superComputer.AmountOfRam, computer.AmountOfRam);
            Assert.AreEqual(superComputer.CpuFrequency, computer.CpuFrequency);
            Assert.AreEqual(superComputer.DriveType, computer.DriveType);
        }

        [TestMethod]
        public void NotSoSuperComputerBuilderTest()
        {
            var computer = new Computer
            {
                AmountOfCores = 1,
                AmountOfRam = 2,
                CpuFrequency = 2.0m,
                DriveType = "hdd"
            };

            var builder = new NotSoSuperComputerBuilder();

            var superComputer = HandyDandyComputerStore.Instance.Build(builder);

            Assert.AreEqual(superComputer.AmountOfCores, computer.AmountOfCores);
            Assert.AreEqual(superComputer.AmountOfRam, computer.AmountOfRam);
            Assert.AreEqual(superComputer.CpuFrequency, computer.CpuFrequency);
            Assert.AreEqual(superComputer.DriveType, computer.DriveType);
        }
    }
}
