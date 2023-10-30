using HW10_1;
using HW10_1.Models;

namespace HW10_1.Tests
{
    [TestClass]
    public class PointTests
    {
        [TestMethod]
        public void DistanceBetweenPointsZeroZeroToPointThreeThree_Returned4Point242()
        {
            // Arrange
            Point a = new Point(0, 0);
            Point b = new Point(3, 3);
            double expected = 4.242;

            // Actual
            double actual = a.Distance(b);
            string str1 = $"Distance between points => {actual:F2}";
            string str2 = $"Distance between points => {expected:F2}";

            // Assert
            Assert.AreEqual(str1, str2);
        }
    }
}