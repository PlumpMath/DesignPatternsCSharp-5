using System;
using Lesson08.Core;
using Lesson08.Standard;
using Lesson08.ThirdParty;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson08.Tests
{
    [TestClass]
    public class ThirdPartyBuilderTests
    {
        [TestMethod]
        public void CustomComputerBuilderTest()
        {
            var computer = new Computer
            {
                AmountOfCores = 4,
                AmountOfRam = 8,
                CpuFrequency = 2.5m,
                DriveType = "hdd"
            };

            var builder = new MidRangeComputerBuilder();

            var superComputer = HandyDandyComputerStore.Instance.Build(builder);

            Assert.AreEqual(superComputer.AmountOfCores, computer.AmountOfCores);
            Assert.AreEqual(superComputer.AmountOfRam, computer.AmountOfRam);
            Assert.AreEqual(superComputer.CpuFrequency, computer.CpuFrequency);
            Assert.AreEqual(superComputer.DriveType, computer.DriveType);
        }
    }
}
