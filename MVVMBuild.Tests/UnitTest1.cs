using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace MVVMBuild.Tests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            int x = 1;
            Assert.AreEqual(x,1);
        }

        [Test]
        public void TestMethod2()
        {
            int y = 2;
            Assert.AreEqual(y, 2);
        }
    }
}
