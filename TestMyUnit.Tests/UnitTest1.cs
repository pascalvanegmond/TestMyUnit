using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace TestMyUnit.Tests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            RandomInt random = new RandomInt();
            //Assert.Less(100000, 2);
        }
    }
}
