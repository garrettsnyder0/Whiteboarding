using Microsoft.VisualStudio.TestTools.UnitTesting;
using Primes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primes.Tests
{
    [TestClass()]
    public class PrimesTests
    {
        [TestMethod()]
        public void IsPrimeTest0()
        {
            Assert.AreEqual(false, Primes.IsPrime(0));
        }

        [TestMethod()]
        public void IsPrimeTest1()
        {
            Assert.AreEqual(false, Primes.IsPrime(1));
        }

        [TestMethod()]
        public void IsPrimeTest2()
        {
            Assert.AreEqual(true, Primes.IsPrime(2));
        }

        [TestMethod()]
        public void IsPrimeTest49()
        {
            Assert.AreEqual(false, Primes.IsPrime(49));
        }

        [TestMethod()]
        public void IsPrimeTest15()
        {
            Assert.AreEqual(false, Primes.IsPrime(15));
        }

        [TestMethod()]
        public void IsPrimeTest13()
        {
            Assert.AreEqual(true, Primes.IsPrime(13));
        }

        [TestMethod()]
        public void IsPrimeTest41()
        {
            Assert.AreEqual(true, Primes.IsPrime(41));
        }
    }
}