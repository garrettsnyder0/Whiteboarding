using Microsoft.VisualStudio.TestTools.UnitTesting;
using CeaserCypher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeaserCypher.Tests
{
    [TestClass()]
    public class CeaserCypherTests
    {
        [TestMethod()]
        public void De_EncodeTestCat()
        {
            Assert.AreEqual("CAT", CeaserCypher.Decode((CeaserCypher.Encode("cat", 2)), 2));
        }

        [TestMethod()]
        public void De_EncodeTestIamTeSting()
        {
            Assert.AreEqual("IAMTESTING", CeaserCypher.Decode((CeaserCypher.Encode("IamTeSting", 15)), 15));
        }

        [TestMethod()]
        public void De_EncodeTestIssssThissssThingWorking()
        {
            Assert.AreEqual("ISSSSTHISSSSTHINGWORKING", CeaserCypher.Decode((CeaserCypher.Encode("IssssThissssThingWorking", 26)), 26));
        }

        [TestMethod()]
        public void De_EncodeTesttaDa()
        {
            Assert.AreEqual("TADA", CeaserCypher.Decode((CeaserCypher.Encode("taDa", 27)), 27));
        }

        [TestMethod()]
        public void De_EncodeTestCatNeg()
        {
            Assert.AreEqual("CAT", CeaserCypher.Decode((CeaserCypher.Encode("cat", -2)), -2));
        }

        [TestMethod()]
        public void De_EncodeTestIamTeStingNeg()
        {
            Assert.AreEqual("IAMTESTING", CeaserCypher.Decode((CeaserCypher.Encode("IamTeSting", -15)), -15));
        }

        [TestMethod()]
        public void De_EncodeTestIssssThissssThingWorkingNeg()
        {
            Assert.AreEqual("ISSSSTHISSSSTHINGWORKING", CeaserCypher.Decode((CeaserCypher.Encode("IssssThissssThingWorking", -26)), -26));
        }

        [TestMethod()]
        public void De_EncodeTesttaDaNeg()
        {
            Assert.AreEqual("TADA", CeaserCypher.Decode((CeaserCypher.Encode("taDa", -27)), -27));
        }
    }
}