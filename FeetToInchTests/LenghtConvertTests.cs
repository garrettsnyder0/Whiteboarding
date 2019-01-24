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
    public class LengthConvertTests
    {
        [TestMethod()]
        public void ConvertFeetToInch1()
        {
            Assert.AreEqual(12.0, LengthConvert.ConvertFeetToInch(1.0));
        }

        [TestMethod()]
        public void ConvertFeetToInch2_5()
        {
            Assert.AreEqual(30.0, LengthConvert.ConvertFeetToInch(2.5));
        }

        [TestMethod()]
        public void ConvertFeetToInch0_5()
        {
            Assert.AreEqual(6.0, LengthConvert.ConvertFeetToInch(0.5));
        }

        [TestMethod()]
        public void ConvertInchToFeet48()
        {
            Assert.AreEqual(4.0, LengthConvert.ConvertInchToFeet(48.0));
        }

        [TestMethod()]
        public void ConvertInchToFeet30()
        {
            Assert.AreEqual(2.5, LengthConvert.ConvertInchToFeet(30.0));
        }

        [TestMethod()]
        public void ConvertInchToFeet6()
        {
            Assert.AreEqual(0.5, LengthConvert.ConvertInchToFeet(6.0));
        }
    }
}