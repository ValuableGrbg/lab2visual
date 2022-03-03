using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab2visual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2visual.Tests
{
    [TestClass()]
    public class RomanNumberTests
    {
        [TestMethod()]
        public void RomanNumberTest1()
        {
            RomanNumber n1;
            Assert.ThrowsException<RomanNumberException>(()=> n1 = new(0));
        }

        [TestMethod()]
        public void RomanNumberTest2()
        {
            RomanNumber n1;
            Assert.ThrowsException<RomanNumberException>(() => n1 = new(4999));
        }

        [TestMethod()]
        public void RomanNumberTestAdd1()
        {
            RomanNumber n1 = new(3);
            RomanNumber n2 = new(116);
            RomanNumber expected = new(119);

            Assert.AreEqual(expected.ToString(), (n1 + n2).ToString());
        }

        [TestMethod()]
        public void RomanNumberTestAdd2()
        {
            RomanNumber n1 = new(2000);
            RomanNumber n2 = new(2000);

            Assert.ThrowsException<RomanNumberException>(() => n1+n2);
        }

        [TestMethod()]
        public void RomanNumberTestSub1()
        {
            RomanNumber n1 = new(1366);
            RomanNumber n2 = new(367);
            RomanNumber expected = new(999);

            Assert.AreEqual(expected.ToString(), (n1 - n2).ToString());
        }

        [TestMethod()]
        public void RomanNumberTestSub2()
        {
            RomanNumber n1 = new(367);
            RomanNumber n2 = new(1366);

            Assert.ThrowsException<RomanNumberException>(() => n1 - n2);
        }

        [TestMethod()]
        public void RomanNumberTestDiv1()
        {
            RomanNumber n1 = new(10);
            RomanNumber n2 = new(3);
            RomanNumber expected = new(3);

            Assert.AreEqual(expected.ToString(), (n1 / n2).ToString());
        }

        [TestMethod()]
        public void RomanNumberTestDiv2()
        {
            RomanNumber n1 = new(10);
            RomanNumber n2 = new(11);

            Assert.ThrowsException<RomanNumberException>(() => n1 / n2);
        }

        [TestMethod()]
        public void RomanNumberTestMul1()
        {
            RomanNumber n1 = new(250);
            RomanNumber n2 = new(5);
            RomanNumber expected = new(1250);

            Assert.AreEqual(expected.ToString(), (n1 * n2).ToString());
        }

        [TestMethod()]
        public void RomanNumberTestMul2()
        {
            RomanNumber n1 = new(1000);
            RomanNumber n2 = new(4);

            Assert.ThrowsException<RomanNumberException>(() => n1 * n2);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            RomanNumber n = new(447);
            String s = "CDXLVII";
            Assert.AreEqual(n.ToString(), s);
        }

        [TestMethod()]
        public void CloneTest()
        {
            RomanNumber n1 = new(1337);
            
            Assert.AreEqual(n1.ToString(), n1.Clone().ToString());
        }

        [TestMethod()]
        public void CompareToTest1()
        {
            RomanNumber n1 = new(250);
            RomanNumber n2 = new(5);
            Assert.IsTrue(n1.CompareTo(n2) > 0);
        }

        [TestMethod()]
        public void CompareToTest2()
        {
            RomanNumber n1 = new(250);
            RomanNumber n2 = new(250);
            Assert.IsTrue(n1.CompareTo(n2) == 0);
        }

        [TestMethod()]
        public void CompareToTest3()
        {
            RomanNumber n1 = new(250);
            RomanNumber n2 = new(5);
            Assert.IsTrue(n2.CompareTo(n1) < 0);
        }
    }
}