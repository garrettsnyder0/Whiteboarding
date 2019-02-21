using Microsoft.VisualStudio.TestTools.UnitTesting;
using CheckingPalendromes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckingPalendromes.Tests
{
    [TestClass()]
    public class CheckingPalendromesTests
    {
        [TestMethod()]
        public void IsPalendromeTestracecar()
        {
            Assert.AreEqual(true, CheckingPalendromes.IsPalendrome("racecar"));
        }

        [TestMethod()]
        public void IsPalendromeTestrace_car()
        {
            Assert.AreEqual(false, CheckingPalendromes.IsPalendrome("race car"));
        }

        [TestMethod()]
        public void IsPalendromeTestaabccbaa()
        {
            Assert.AreEqual(true, CheckingPalendromes.IsPalendrome("aabccbaa"));
        }

        [TestMethod()]
        public void IsPalendromeTestadfefjvur()
        {
            Assert.AreEqual(false, CheckingPalendromes.IsPalendrome("adfefjvur"));
        }
    }
}