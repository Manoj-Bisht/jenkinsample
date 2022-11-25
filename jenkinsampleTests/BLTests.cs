using Microsoft.VisualStudio.TestTools.UnitTesting;
using jenkinsample;
using System;
using System.Collections.Generic;
using System.Text;

namespace jenkinsample.Tests
{
    [TestClass()]
    public class BLTests
    {
        [TestMethod()]
        public void GetStringTest()
        {
            Assert.AreEqual("Hello World", "Hello World");
        }
    }
}