using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace TestCalculator
{
    [TestClass]
    public class UnitTest1
    {
        Calculation cal;
        [TestInitialize]
        
        public void setup()
        {
            this.cal = new Calculation(10, 5);
        }
        [TestMethod]
        public void TestAdd()
        {
            Assert.AreEqual(15, cal.Execute("+"));
        }
        [TestMethod]
        public void TestSub()
        {
            Assert.AreEqual(5, cal.Execute("-"));
        }
        [TestMethod]
        public void TestMul()
        {
            Assert.AreEqual(50, cal.Execute("*"));
        }
        [TestMethod]
        public void TestDiv()
        {
            Assert.AreEqual(2, cal.Execute("/"));
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivByZero()
        {
            Calculation c = new Calculation(2, 0);
             cal.Execute("/");
        }
    }
}
