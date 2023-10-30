using HW8;
using HW8.Classes;

namespace HW8.Tests
{
    [TestClass]
    public class SquareTests
    {
        [TestMethod]
        public void SquarePerimeter()
        {
            // Arrange
            Square square = new Square("Square1", 5);
            double expected = 20.0;
            // Actual
            double actual = square.CalculatePerimeter();
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SquareArea()
        {
            // Arrange
            Square square = new Square("Square1", 5);
            double expected = 25;
            // Actual
            double actual = square.CalculateArea();
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}