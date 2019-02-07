using Microsoft.VisualStudio.TestTools.UnitTesting;
using CamelCase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamelCase.Tests
{
    [TestClass()]
    public class CamelCaseTests
    {
        [TestMethod()]
        public void convertToCamelTest1()
        {
            Assert.AreEqual("maryHadA", CamelCase.convertToCamel("Mary had A"));
        }

        [TestMethod()]
        public void convertToCamelTest2()
        {
            Assert.AreEqual("testTestTest", CamelCase.convertToCamel("test Test tEsT"));
        }

        [TestMethod()]
        public void convertToCamelTest3()
        {
            Assert.AreEqual("iAmWorkingNow", CamelCase.convertToCamel("I AM WORKING NOW"));
        }

        //has to strip punctuation too
        [TestMethod()]
        public void convertToCamelTest4()
        {
            Assert.AreEqual("imAJerkTest", CamelCase.convertToCamel("    I'm a jerk test."));
        }

        [TestMethod()]
        public void convertToCamelTest5()
        {
            Assert.AreEqual("manySpaces", CamelCase.convertToCamel("many         spaces"));
        }

        [TestMethod()]
        public void convertToCamelTest6()
        {
            Assert.AreEqual("4321", CamelCase.convertToCamel("4321"));
        }
    }
}