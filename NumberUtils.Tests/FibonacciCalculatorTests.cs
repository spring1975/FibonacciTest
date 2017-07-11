using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumberUtils.Tests
{
    [TestClass]
    public class FibonacciCalculatorTests
    {
        [TestMethod]
        public void ValueOfPositionFiveIsEightWithDefaultConstructor()
        {
            var x = new FibonacciCalculator();
            var y = x.CalculateValueOfPosition(5);
            Assert.AreEqual(8, y);
        }

        [TestMethod]
        public void ValueOfPositionFiveIsEightWithConstructorParam()
        {
            var x = new FibonacciCalculator(1);
            var y = x.CalculateValueOfPosition(5);
            Assert.AreEqual(8, y);
        }

        [TestMethod]
        public void CanFindPositionOfValueEightWithDefaultConstructor()
        {
            var x = new FibonacciCalculator();
            var y = x.CalculatePositionOfValue(8);
            Assert.AreEqual(5, y);
        }


        [TestMethod]
        public void CanFindPositionOfValueFortyWithConstructorParam()
        {
            var x = new FibonacciCalculator(5);
            var y = x.CalculatePositionOfValue(40);
            Assert.AreEqual(5, y);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void DoesThrowExeceptionWithInvalieValueAndConstructorParam()
        {
            var x = new FibonacciCalculator(5);
            x.CalculatePositionOfValue(31);
        }
    }
}
