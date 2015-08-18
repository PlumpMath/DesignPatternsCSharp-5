using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson04.Tests
{
    [TestClass]
    public class CommandTests
    {
        [TestMethod]
        public void VolumeTest()
        {
            var volume2 = AquosCommand.Volume(30);

        }

        [TestMethod]
        public void PowerTest()
        {

            var power2 = AquosCommand.Power(PowerSetting.Off);

        }
    }
}
