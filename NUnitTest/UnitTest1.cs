
using NUnitCode;

namespace NUnitTest
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator;
        [SetUp]
        public void Setup()
        {
            // Arrange: Initialize objects before each test
            _calculator = new Calculator();
        }

        [Test]
        public void Add_ShouldReturnSum_WhenGivenTwoNumbers()
        {
            // Act
            int result = _calculator.Add(5, 3);

            // Assert
            Assert.AreEqual(7, result);
        }

        [Test]
        public void Subtract_ShouldReturnDifference_WhenGivenTwoNumbers()
        {
            // Act
            int result = _calculator.Subtract(10, 4);

            // Assert
            Assert.AreEqual(6, result);
        }

        [Test]
        [TestCase(2, 3, 6)]
        [TestCase(-2, 3, -6)]
        [TestCase(0, 5, 0)]
        public void Multiply_ShouldReturnProduct(int a, int b, int expected)
        {
            // Act
            int result = _calculator.Multiply(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Divide_ShouldThrowException_WhenDividingByZero()
        {
            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(10, 0));
        }

        [Test]
        public void Divide_ShouldReturnQuotient_WhenGivenValidNumbers()
        {
            // Act
            double result = _calculator.Divide(10, 2);

            // Assert
            Assert.AreEqual(5.0, result);
        }

        [TearDown]
        public void Cleanup()
        {
            _calculator = null;
        }
    }
}