using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson14
{
    [TestClass]
    public class IteratorTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var names = new List<string>()
            {
                "Jeremy",
                "Jeffrey",
                "Jordan",
                "Jennifer"
            };

            foreach (var name in names)
            {
                Assert.IsTrue(names.Contains(name));
            }

            var iteratorOfT = names.GetEnumerator();

            while (iteratorOfT.MoveNext())
            {
                var name = iteratorOfT.Current;
                Assert.IsTrue(names.Contains(name));
            }

            var iterator = (IEnumerator) names.GetEnumerator();

            while (iterator.MoveNext())
            {
                var name = (string)iterator.Current;
                Assert.IsTrue(names.Contains(name));

            }


        }

        [TestMethod]
        public void CustomClassIterator()
        {
            var obj = new CustomClass
            {
                Foo = "foo",
                Bar = "bar",
                Boo = "boo"
            };

            var iterator = obj.GetEnumerator();

            iterator.MoveNext();

            Assert.AreEqual(obj.Foo, iterator.Current);

            iterator.MoveNext();

            Assert.AreEqual(obj.Bar, iterator.Current);

            iterator.MoveNext();

            Assert.AreEqual(obj.Boo, iterator.Current);
        }
    }
}
