using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestGitLibrary;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(420, calc.CalculateTotalPrice(10, 42));
        }
    }
}
