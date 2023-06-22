using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using НОД_методом_Евклида;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 33;
            int b = 9;
            int expected = 3;
            Assert.AreEqual(expected, Form1.NOD(a, b));
        }
    }
}
