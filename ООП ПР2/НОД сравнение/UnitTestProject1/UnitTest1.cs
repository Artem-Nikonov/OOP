using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using НОД_равнение;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 298467352;
            int b = 569484;
            int expected = 4;
            long time;
            Assert.AreEqual(expected, Form1.NOD(a, b, out time));
        }

        [TestMethod]
        public void TestMethod2()
        {
            int a = 298467352;
            int b = 569484;
            int expected = 4;
            long time;
            Assert.AreEqual(expected, Form1.FindGCDStein(a, b, out time));
        }
    }
}
