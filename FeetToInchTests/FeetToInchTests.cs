using Microsoft.VisualStudio.TestTools.UnitTesting;
using Whiteboarding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whiteboarding.Tests
{
    [TestClass()]
    public class FeetToInchTests
    {
        [TestMethod()]
        public void ConvertFeetToInch1()
        {
            Assert.AreEqual(12, LengthConvert.ConvertFeetToInch(1));
        }
        [TestMethod()]
        public void ConvertFeetToInch2_5()
        {
            Assert.AreEqual(30, LengthConvert.ConvertFeetToInch(2.5));
        }
        [TestMethod()]
        public void ConvertInchToFeet48()
        {
            Assert.AreEqual(4, LengthConvert.ConvertInchToFeet(48));
        }
        [TestMethod()]
        public void ConvertInchToFeet30()
        {
            Assert.AreEqual(2.5, LengthConvert.ConvertInchToFeet(30));
        }
    }
}