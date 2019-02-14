using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConvertStringToMorse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertStringToMorse.Tests
{
    [TestClass()]
    public class ConvertStringToMorseTests
    {
        [TestMethod()]
        public void ConvertMorseTestBEAD()
        {
            Assert.AreEqual("-... . .- -.. ", ConvertStringToMorse.ConvertMorse("BEAD"));
        }

        [TestMethod()]
        public void ConvertMorseTestZeTa()
        {
            Assert.AreEqual("--.. . - .- ", ConvertStringToMorse.ConvertMorse("ZeTa"));
        }

        [TestMethod()]
        public void ConvertMorseTest12Hey34()
        {
            Assert.AreEqual(".---- ..--- .... . -.-- ...-- ....- ", ConvertStringToMorse.ConvertMorse("12Hey34"));
        }

        [TestMethod()]
        public void ConvertMorseTestPunctuation()
        {
            Assert.AreEqual("-- . .. , -. ! . ", ConvertStringToMorse.ConvertMorse("M.I,n!e"));
        }

        [TestMethod()]
        public void ConvertMorseTestSpaces()
        {
            Assert.AreEqual("-   . ...   - ", ConvertStringToMorse.ConvertMorse("t es t"));
        }

      
    }
}