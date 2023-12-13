using NUnit.Framework;
using Common;
using System;

namespace Common.Test
{
    public class PersonTest
    {
        private Person per01;

        [SetUp]
        public void Setup()
        {
            per01 = new Person("Tony", new System.DateTime(1960, 01, 01));
        }

        [Test]
        public void Age_20231231_return64()
        {
            int realAge = 0;

            if(per01 != null)
            {
                realAge = per01.Age(today());
            }

            Assert.AreEqual(64, realAge);
        }

        private DateTime today()
        {
            return new DateTime(2023, 12, 31);
        }
    }
}