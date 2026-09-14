using Divide;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Cryptography;

namespace UnitTestRemember
{
    [TestClass]
    public class TDevide
    { 

        [TestMethod]
        public void TestDelenieTwoPositivNumbers()
        {

            double a = 10;
            double b = 5;
            double expected = 2;

            double? actual = Calculator.Divide(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDelenieOneNegativeNumbers()
        {

            double a = 10;
            double b = -5;
            double expected = -2;

            double? actual = Calculator.Divide(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDelenieTwoNegativeNumbers()
        {

            double a = -10;
            double b = -5;
            double expected = 2;

            double? actual = Calculator.Divide(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDelenieFractionalPart()
        {

            double a = 25;
            double b = 4;
            double expected = 6.25;

            double? actual = Calculator.Divide(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDelenieFractionalNumber()
        {

            double a = 25;
            double b = 12.5;
            double expected = 2;

            double? actual = Calculator.Divide(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDelenieNull()
        {

            double a = 0;
            double b = 25;
            double expected = 0;

            double? actual = Calculator.Divide(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDelenieFractionalTwoNumber()
        {

            double a = 5.5;
            double b = 2.75;
            double expected = 2;

            double? actual = Calculator.Divide(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDelenie()
        {

            double a = 5;
            double b = 0;
            double? expected = null;

            double? actual = Calculator.Divide(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(10.0, 5.0, 2.0)]
        [DataRow(10.0, -5.0, -2.0)]
        [DataRow(-10.0, -5.0, 2.0)]
        [DataRow(25.0, 4.0, 6.25)]
        [DataRow(25.0, 12.5, 2.0)]
        [DataRow(0.0, 25.0, 0.0)]
        [DataRow(5.5, 2.75, 2.0)]
        [DataRow(5.0, 0.0, null)]
        public void TestDataRowDelenie(double a, double b, double? expected)
        {

            double? actual = Calculator.Divide(a, b);
            Assert.AreEqual(expected, actual);
        }
        //имеется перечень авто, задача сохранить файл, тех автомобилей, которые попали в дтп
    }
}
