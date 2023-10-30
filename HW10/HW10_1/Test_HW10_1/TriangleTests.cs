using HW10_1;
using HW10_1.Models;

namespace HW10_1.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void TianglePerimeter_PointZeroZero_ThreeThree_FourZero_Returned11Point40()
        {
            // Arrange
            var triangle = new Triangle(
                new Point(0, 0),
                new Point(3, 3),
                new Point(4, 0)
                );
            double expected = 11.40;
            // Actual
            double actual = triangle.Perimeter();
            string str1 = $"Triangle perimeter => {expected:F1}";
            string str2 = $"Triangle perimeter => {actual:F1}";
            // Assert
            Assert.AreEqual(str1, str2);
        }
        [TestMethod]
        public void TriangleArea_PointZeroZero_FourFive_SixZero_Returned15Point0()
        {
            // Arrange
            var triangle = new Triangle(
                new Point(0, 0),
                new Point(4, 5),
                new Point(6, 0)
            );
            double expected = 15.0;
            // Actual
            double actual = triangle.Area();
            string str1 = $"Triangle area => {expected:F1}";
            string str2 = $"Triangle area => {actual:F1}";
            // Assert
            Assert.AreEqual(str1, str2);
        }
        [TestMethod]
        public void TrianglePointDistance_BetweenPointsZeroZeroToPointThreeThree_Returned4Point242()
        {
            // Arrange
            var triangle = new Triangle(
                new Point(0, 0),
                new Point(3, 3),
                new Point(5, 0)
            );
            double expected = 4.242;

            // Actual
            double actual = triangle.Distance(triangle.vertex1, triangle.vertex2);
            string str1 = $"Distance between points => {actual:F2}";
            string str2 = $"Distance between points => {expected:F2}";

            // Assert
            Assert.AreEqual(str1, str2);
        }
    }
}