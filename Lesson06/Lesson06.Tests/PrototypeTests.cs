using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson06.Tests
{
    [TestClass]
    public class PrototypeTests
    {
        [TestMethod]
        public void MemberwiseCloneTest()
        {
            var gpu = new GraphicsCard
            {
                AmountOfRam = 4,
                GpuFrequency = 1.1m
            };

            var computer = new Computer
            {
                AmountOfCores = 4,
                AmountOfRam = 32,
                CpuFrequency = 3.4m,
                DriveType = "ssd",
                Gpu = gpu
            };

            var computer2 = (Computer)computer.Clone();

            Assert.AreNotSame(computer2, computer);
            Assert.AreNotSame(computer2.AmountOfCores, computer.AmountOfCores);
            Assert.AreNotSame(computer2.AmountOfRam, computer.AmountOfRam);
            Assert.AreNotSame(computer2.CpuFrequency, computer.CpuFrequency);
            Assert.AreSame(computer2.DriveType, computer.DriveType);

            Assert.AreEqual(computer2.Gpu.AmountOfRam, computer.Gpu.AmountOfRam);
            Assert.AreEqual(computer2.Gpu.GpuFrequency, computer.Gpu.GpuFrequency);

            computer.Gpu.AmountOfRam = 8;

            Assert.AreNotEqual(computer2.Gpu.AmountOfRam, computer.Gpu.AmountOfRam);


        }
    }
}
