using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Common;
using System;

namespace Common.Test
{
    public class CalculateImplTest
    {
        [Test]
        public void add_2And3_Return5()
        {
            ICalculate cal = new CalculateImpl();
            int result = 0;

            result = cal.add(2, 3);

            Assert.AreEqual(5, result);
        }

        [Test]
        public void add_20And30_Return50()
        {
            ICalculate cal = new CalculateImpl();
            int result = 0;

            result = cal.add(20, 30);

            Assert.AreEqual(50, result);
        }
    }
}
