using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson09.Tests
{
    [TestClass]
    public class CompositeTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var computer = new Computer(); // composite
                var motherboard = new Motherboard(125); // composite
                    var cpu = new Cpu(250); // leaf
                    var ram = new Ram(160); // leaf
                var drive = new Ssd(250); // leaf

            motherboard.Add(cpu);
            motherboard.Add(ram);

            computer.Add(motherboard);
            computer.Add(drive);

            Assert.AreEqual(computer.Price, 785);
        }
    }
}
