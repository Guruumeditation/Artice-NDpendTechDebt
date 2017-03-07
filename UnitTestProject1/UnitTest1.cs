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
    }
}
