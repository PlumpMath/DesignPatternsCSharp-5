using System;
using Lesson05.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson05.Tests
{
    [TestClass]
    public class BuilderTests
    {
        [TestMethod]
        public void SuperComputer()
        {
            var computer = new Computer
            {
                AmountOfCores = 64,
                AmountOfRam = 256,
                CpuFrequency = 3.4m,
                DriveType = "ssd"
            };

            var store = new HandyDandyComputerStore();
            var builder = new SuperComputerBuilder();

            var superComputer = store.Build(builder);

            Assert.AreEqual(superComputer.AmountOfCores, computer.AmountOfCores);
            Assert.AreEqual(superComputer.AmountOfRam, computer.AmountOfRam);
            Assert.AreEqual(superComputer.CpuFrequency, computer.CpuFrequency);
            Assert.AreEqual(superComputer.DriveType, computer.DriveType);
        }

        [TestMethod]
        public void NotSoSuperComputer()
        {
            var computer = new Computer
            {
                AmountOfCores = 1,
                AmountOfRam = 2,
                CpuFrequency = 2.0m,
                DriveType = "hdd"
            };

            var store = new HandyDandyComputerStore();
            var builder = new NotSoSuperComputerBuilder();

            var superComputer = store.Build(builder);

            Assert.AreEqual(superComputer.AmountOfCores, computer.AmountOfCores);
            Assert.AreEqual(superComputer.AmountOfRam, computer.AmountOfRam);
            Assert.AreEqual(superComputer.CpuFrequency, computer.CpuFrequency);
            Assert.AreEqual(superComputer.DriveType, computer.DriveType);
        }
    }
}
