using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlphabetizeString;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphabetizeString.Tests
{
    [TestClass()]
    public class AlphabetizeStringTests
    {
        [TestMethod()]
        public void AlphabetizeTestGarrett()
        {
            Assert.AreEqual("aegrrtt", AlphabetizeString.Alphabetize("Garrett"));
        }

        [TestMethod()]
        public void AlphabetizeTestZaPatTo()
        {
            Assert.AreEqual("aaopttz", AlphabetizeString.Alphabetize("ZaPatTo"));
        }

        [TestMethod()]
        public void AlphabetizeTestIAmWorking()
        {
            Assert.AreEqual("agiikmnorw", AlphabetizeString.Alphabetize("IAmWorking"));
        }

    }
}