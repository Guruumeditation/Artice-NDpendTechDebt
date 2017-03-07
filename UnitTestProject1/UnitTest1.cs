using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNDepend;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var t = new MyClass();

            Assert.IsFalse(t.MyProperty);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var t = new MyClass();

            var result = t.Method1(5);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var t = new MyClass();

            var result = t.Method1(4);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var t = new MyClass();

            t.Method2();

            Assert.IsFalse(false);
        }

        [TestMethod]
        public void TestMethod5()
        {
            var t = new MyClass(true);

            Assert.IsTrue(t.MyProperty);
        }
    }
}
