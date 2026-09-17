using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorCICD.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_TwoNumbers_ReturnsCorrectResult()
        {
            //Arrange
            Calculator calc = new Calculator();

            //Act
            double result = calc.Add(10, 20);
            
            //Assert
            Assert.Equal(30, result);
        }

        [Fact]
        public void Subtract_TwoNumbers_ReturnsCorrectResult()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            double result = calculator.Subtract(20, 10);

            // Assert
            Assert.Equal(10, result);
        }

        [Fact]
        public void Multiply_TwoNumbers_ReturnsCorrectResult()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            double result = calculator.Multiply(5, 4);

            // Assert
            Assert.Equal(20, result);
        }

        [Fact]
        public void Divide_TwoNumbers_ReturnsCorrectResult()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            double result = calculator.Divide(20, 4);

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void Square_Number_ReturnsCorrectResult()
        {
            Calculator calculator = new Calculator();
            double result = calculator.Square(5);
            Assert.Equal(25, result);
        }
    }
}
