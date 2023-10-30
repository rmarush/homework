using HW8;
using HW8.Classes;

namespace HW8.Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void CirclePerimeter()
        {
            // Arrange
            Circle circle = new Circle("Circle1", 4);
            double expected = 25.13;
            // Actual
            double actual = circle.CalculatePerimeter();
            string str1 = $"Cirlce perimeter => {actual:F2}";
            string str2 = $"Cirlce perimeter => {expected:F2}";
            // Assert
            Assert.AreEqual(str1, str2);
        }
        [TestMethod]
        public void CircleArea()
        {
            // Arrange
            Circle circle = new Circle("Circle1", 4);
            double expected = 50.27;
            // Actual
            double actual = circle.CalculateArea();
            string str1 = $"Cirlce area => {actual:F2}";
            string str2 = $"Cirlce area => {expected:F2}";
            // Assert
            Assert.AreEqual(str1, str2);
        }
    }
}
