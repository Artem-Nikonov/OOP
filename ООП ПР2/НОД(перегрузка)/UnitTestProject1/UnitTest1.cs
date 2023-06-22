using Microsoft.VisualStudio.TestTools.UnitTesting;
using НОД_перегрузка_;
using System;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FindGCDEuclidTest0()
        {
            int a = 12;
            int b = 8;
            int expected = 4;
            Assert.AreEqual(expected, Form1.NOD(a, b));
        }

        [TestMethod]
        public void FindGCDEuclidTest1()
        {
            int a = 7396;
            int b = 1978;
            int c = 1204;
            int expected = 86;
            Assert.AreEqual(expected, Form1.NOD(a, b, c));
        }

        [TestMethod]
        public void FindGCDEuclidTest2()
        {
            int a = 7396;
            int b = 1978;
            int c = 1204;
            int d = 430;
            int expected = 86;
            Assert.AreEqual(expected, Form1.NOD(a, b, c, d));
        }

        [TestMethod]
        public void FindGCDEuclidTest3()
        {
            int a = 7396;
            int b = 1978;
            int c = 1204;
            int d = 430;
            int e = 258;
            int expected = 86;
            Assert.AreEqual(expected, Form1.NOD(a, b, c, d, e));
        }
    }
}
