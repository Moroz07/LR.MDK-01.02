using System;
using System.Security.Cryptography.X509Certificates;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TCalculator
{

    [TestClass]

    public class TCalculator
    {
        Calculatorr calculator = new Calculatorr();
        [TestMethod]
        public void TestSumma()
        {
            int x = 4;
            int y = 8;

            int expected = 12;
            double action = calculator.Summa(x, y);
            Assert.AreEqual(expected, action);
        }

        [TestMethod]
        public void TestSubtraction()
        {
            int x = 20;
            int y = 7;

            int expected = 13;
            double action = calculator.Subtraction(x, y);
            Assert.AreEqual(expected, action);
        }

        [TestMethod]
        public void TestMultiplication()
        {
            int x = 5;
            int y = 5;

            int expected = 25;
            double action = calculator.Multiplication(x, y);
            Assert.AreEqual(expected, action);
        }

        [TestMethod]
        public void TestDivideZero()
        {
            int x = 15;
            int y = 0;

            int expected = 0;
            double action = calculator.Divide(x, y);
            Assert.AreEqual(expected, action);
        }

        [TestMethod]
        public void TestDivide()
        {
            int x = 15;
            int y = 3;

            int expected = 5;
            double action = calculator.Divide(x, y);
            Assert.AreEqual(expected, action);
        }
    }
}
