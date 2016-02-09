using Microsoft.VisualStudio.TestTools.UnitTesting;
using Demo8esim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo8esim.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            // arrange
            Calculator calc = new Calculator();
            int number1 = 12;
            int number2 = 643;
            int result = number1 + number2;

            // act
            int actual = calc.Add(number1, number2);

            // assert
            Assert.AreEqual(result, actual);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            // arrange
            Calculator calc = new Calculator();
            int number1 = 5;
            int number2 = 7;
            int result = number1 * number2;

            // act
            int actual = calc.Multiply(number1, number2);

            // assert
            Assert.AreEqual(result, actual);
        }

        [TestMethod()]
        public void DivideTest()
        {
            // arrange
            Calculator calc = new Calculator();
            int number1 = 50000;
            int number2 = 7;
            int result = number1 / number2;

            // act
            int actual = calc.Divide(number1, number2);

            // assert
            Assert.AreEqual(result, actual);
        }
    }
}