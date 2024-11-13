using Microsoft.VisualStudio.TestTools.UnitTesting;
using PositiveNegativeNumbersZadacha;
using System;


namespace UnitMSTestPositiveNegativeNumbers
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsPositiveReturnsTrue()
        {
            //Arrange
            int number = 1;

            PositiveNegativeNumbers numbers = new PositiveNegativeNumbers();

            //Act
            bool result = numbers.IsPositive(number);

            //Assert
            Assert.IsTrue(result);
        }


        [TestMethod]
        public void TestIsPositiveReturnsFalse()
        {
            //Arrange
            int number = -2;
            PositiveNegativeNumbers numbers = new PositiveNegativeNumbers();

            //Act
            bool result = numbers.IsPositive(number);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestIsPositiveByZeroReturnsFalse()
        {
            //Arrange
            int number = 0;
            PositiveNegativeNumbers numbers = new PositiveNegativeNumbers();

            //Act
           // bool result = numbers.IsPositive(number);

            //Assert
           // Assert.IsFalse(result);
           Assert.ThrowsException<ArgumentException>(() => numbers.IsPositive(number));
        }
    }
}
