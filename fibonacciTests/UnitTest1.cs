using System;
using Fibonacci;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FibonacciTests
{
    [TestClass]
    public class UnitTest1
    {
        FibonacciCalculator calculator = new FibonacciCalculator();

        [TestMethod]
        public void TestBaseCases()
        {
            Assert.AreEqual(0, calculator.GetValue(0));
            Assert.AreEqual(1, calculator.GetValue(1));
        }
    
        [TestMethod]
        public void TestNonTrivialCases()
        {
            Assert.AreEqual(1, calculator.GetValue(2));
            Assert.AreEqual(2, calculator.GetValue(3));
            Assert.AreEqual(13, calculator.GetValue(7));
        }
    
        [TestMethod]
        public void TestDepthBaseCases()
        {
            calculator = new FibonacciCalculator();
            Assert.AreEqual(0, calculator.GetDepth(0));
        }

        [TestMethod]
        public void TestDepthNonTrivialCases()
        {
            calculator = new FibonacciCalculator();
            Assert.AreEqual(2, calculator.GetDepth(1));
            calculator = new FibonacciCalculator();
            Assert.AreEqual(3, calculator.GetDepth(2));
            calculator = new FibonacciCalculator();
            Assert.AreEqual(4, calculator.GetDepth(3));
        }

    }
}
