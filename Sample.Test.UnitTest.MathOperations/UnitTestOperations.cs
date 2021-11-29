using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sample.UnitTest.MathOperations;
using System;

namespace Sample.Test.UnitTest.MathOperations
{
    [TestClass]
    public class UnitTestOperations
    {
        [TestMethod]
        public void Test_Add()
        {
            Operations operations = new Operations();

            double result = operations.Add(10, 10);
            Assert.AreEqual(result, 20);
        }

        [TestMethod]
        public void Test_Subtract()
        {
            Operations operations = new Operations();

            double result = operations.Subtract(20, 10);
            Assert.AreEqual(result, 10);
        }

        [TestMethod]
        public void Test_Divide()
        {
            Operations operations = new Operations();

            double result = operations.Divide(10, 10);
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void Test_Multiply()
        {
            Operations operations = new Operations();

            double result = operations.Multiply(5, 5);
            Assert.AreEqual(result, 25);
        }

        [TestMethod]
        public void Test_IsItPositive()
        {
            Operations operations = new Operations();

            bool result = operations.IsItPositive(1);
            Assert.IsTrue(result);
        }
    }
}
