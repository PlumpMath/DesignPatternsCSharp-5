using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson10.Tests
{
    [TestClass]
    public class DecoratorTests
    {
        [TestMethod]
        public void UntitledTest()
        {
            var sandwich = new BaseSandwich();

            Assert.AreEqual(sandwich.Price, 1.00m);

            var wheatBreadSandwich = new WheatBread(sandwich);

            Assert.AreEqual(wheatBreadSandwich.Price, 2.00m);

            var hamSandwich = new Ham(wheatBreadSandwich);

            Assert.AreEqual(hamSandwich.Price, 4.00m);

            var baconHam = new Bacon(new Bacon(hamSandwich));

            Assert.IsTrue(baconHam.InnerComponent is Bacon);

            Assert.AreEqual(baconHam.Price, 5.00m);

            var discountedBaconHam = new BaconDiscount(new BaconDiscount(baconHam));

            Assert.AreEqual(discountedBaconHam.Price, 4.00m);



        }
    }
}
