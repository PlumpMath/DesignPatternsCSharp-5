using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson07.Tests
{
    [TestClass]
    public class SingletonTests
    {
        [TestMethod]
        public void IsHandyDandyComputerStoreASingleton()
        {
            Assert.AreSame(HandyDandyComputerStore.Instance,
                HandyDandyComputerStore.Instance);
        }
    }
}
