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
            // Check of het getal positief is.
            RandomInts random = new RandomInts(new LoggerMock());

            var result = random.CreateRandomInt();

            Assert.Positive(result);
        }

        [Test]
        public void RandomInts_CreateRandomIntIsLowerThan99999_ReturnsTrue()
        {
            // check of het getal lager is dan 99999
            RandomInts random = new RandomInts(new LoggerMock());

            var result = random.CreateRandomInt();

            Assert.Less(result, 99999);
        }

        [Test]
        public void RandomInts_CheckIfIntIsUniqueInList_ReturnsTrue()
        {
            // check of het mogelijk is om een nieuw uniek number toe te voegen
            List<int> list = new List<int> { 1, 2, 3, 4, 5 };
            var newInt = 6;
            RandomInts random = new RandomInts(new LoggerMock());

            var result = random.CheckIfIntIsUnique(newInt, list);

            Assert.IsTrue(result);
        }

        [Test]
        public void RandomInts_CheckIfIntIsNotUniqueInList_ReturnsFalse()
        {
            // voeg een al bestaand nummer toe kijk of het stuk gaat.
            List<int> list = new List<int> { 1, 2, 3, 4, 5 };
            var alreadyUsedInt = 5;
            RandomInts random = new RandomInts(new LoggerMock());

            var result = random.CheckIfIntIsUnique(alreadyUsedInt, list);

            Assert.IsFalse(result);
        }

        [Test]
        public void RandomInts_CheckIfIsNUniqueDigitsLong_MustBeTheSame()
        {
            // bekijk of er geen dubbelen integers in de lijst zitten.
            int n = 100;
            RandomInts random = new RandomInts(new LoggerMock());
            random.MakeListNDigitsLong(n);

            var result = random.ListOfRandomInts.Distinct().Count();

            Assert.AreEqual(result, n);
        }

        [Test]
        public void RandomInts_CheckLogWhenCalled_MustBeTheSame()
        {
            // bekijk of de log gelijk is aan de log fake log.
            var mockLog = new FakeLoggerMock();

            var randomInts = new RandomInts(mockLog);
            randomInts.MakeListNDigitsLong(100);

            Assert.AreEqual("Loggin now", mockLog.Text);
        }
    }
}
