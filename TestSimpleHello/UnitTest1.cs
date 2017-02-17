using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleHello;

namespace TestSimpleHello
{
    [TestClass]
    public class HelloOutputTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Hello World", Program.CreateMessage());
        }
    }
}
