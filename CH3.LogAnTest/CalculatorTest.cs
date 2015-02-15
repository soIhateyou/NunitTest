using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CH3.LogAn;
using NUnit.Framework;

namespace CH3.LogAnTest
{
    [TestFixture]
    public class CalculatorTest
    {
        [Test]
        public void Sum_NoAddCalls_DefaultsToZero()
        {
            Calculator calc = new Calculator();
            int lastSum = calc.Sum();
            Assert.AreEqual(0,lastSum);
        }
    }
}
