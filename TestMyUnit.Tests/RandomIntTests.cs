using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace TestMyUnit.Tests
{
    [TestFixture]
    public class RandomIntTests
    {
        [Test]
        public void RandomInts_CreateRandomIntCantBeNegative_ReturnsTrue()
        {
            RandomInts random = new RandomInts(new LoggerMock());

            var result = random.CreatRandomInt();

            Assert.Positive(result);
        }

        [Test]
        public void RandomInts_CreateRandomIntIsLowerThan99999_ReturnsTrue()
        {
            RandomInts random = new RandomInts(new LoggerMock());

            var result = random.CreatRandomInt();

            Assert.Less(result, 99999);
        }

        [Test]
        public void RandomInts_CheckIfIntIsUniqueInList_ReturnsTrue()
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5 };
            var alreadyUsedInt = 6;
            RandomInts random = new RandomInts(new LoggerMock());

            var result = random.CheckIfIntIsUnique(alreadyUsedInt, list);

            Assert.IsTrue(result);
        }

        [Test]
        public void RandomInts_CheckIfIntIsNotUniqueInList_ReturnsFalse()
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5 };
            var alreadyUsedInt = 5;
            RandomInts random = new RandomInts(new LoggerMock());

            var result = random.CheckIfIntIsUnique(alreadyUsedInt, list);

            Assert.IsFalse(result);
        }

        [Test]
        public void RandomInts_CheckIfIsNUniqueDigitsLong_ReturnsTrue()
        {
            int n = 100;
            RandomInts random = new RandomInts(new LoggerMock());
            random.MakeListNDigitsLong(n);

            var result = random.ListOfRandomInts.Distinct().Count();

            Assert.AreEqual(result, n);
        }

        [Test]
        public void RandomInts_CheckLogWhenCalled_ReturnsTrue()
        {
            var mockLog = new FakeLoggerMock();

            var randomInts = new RandomInts(mockLog);
            randomInts.MakeListNDigitsLong(100);

            Assert.AreEqual("Loggin now", mockLog.Text);
        }
    }
}
