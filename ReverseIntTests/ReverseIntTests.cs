using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReverseInt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseInt.Tests
{
    [TestClass()]
    public class ReverseIntTests
    {
        [TestMethod()]
        public void RevIntTest()
        {
            Assert.AreEqual(3701, ReverseInt.RevInt(1073));
        }

        [TestMethod()]
        public void RevIntTest2()
        {
            Assert.AreEqual(56746, ReverseInt.RevInt(64765));
        }

        [TestMethod()]
        public void RevIntTest3()
        {
            Assert.AreEqual(1188344, ReverseInt.RevInt(4438811));
        }

        [TestMethod()]
        public void RevIntTest4()
        {
            Assert.AreEqual(21, ReverseInt.RevInt(12));
        }
    }
}