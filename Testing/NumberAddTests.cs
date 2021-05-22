using Microsoft.VisualStudio.TestTools.UnitTesting;
using OC_CMSC_5733_Assignment_1;

namespace Testing
{
    [TestClass]
    public class NumberAddTests
    {
        [TestMethod]
        public void PositiveOnly()
        {
            // Arrange
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int target = 14;

            // Act
            bool canAdd = NumberAddChecker.CanAddTo(numbers, target);

            // Assert
            Assert.AreEqual(true, canAdd);
        }

        [TestMethod]
        public void NegativeOnly()
        {
            // Arrange
            int[] numbers = { -1, -2, -3, -4, -5, -6, -7, -8 };
            int target = -13;

            // Act
            bool canAdd = NumberAddChecker.CanAddTo(numbers, target);

            // Assert
            Assert.AreEqual(true, canAdd);
        }

        [TestMethod]
        public void NegativeInputPositiveTarget()
        {
            // Arrange
            int[] numbers = { 1, 2, -3, 4, -5, 6 };
            int target = 1;

            // Act
            bool canAdd = NumberAddChecker.CanAddTo(numbers, target);

            // Assert
            Assert.AreEqual(true, canAdd);
        }

        [TestMethod]
        public void NegativeInputNegativeTarget()
        {
            // Arrange
            int[] numbers = { 1, 2, -3, 4, -5, 6 };
            int target = -3;

            // Act
            bool canAdd = NumberAddChecker.CanAddTo(numbers, target);

            // Assert
            Assert.AreEqual(true, canAdd);
        }

        [TestMethod]
        public void LargeInput()
        {
            // Arrange
            int[] numbers = { 279, 1230, 503, 458, 1555 };
            int target = 1834;

            // Act
            bool canAdd = NumberAddChecker.CanAddTo(numbers, target);

            // Assert
            Assert.AreEqual(true, canAdd);
        }
    }
}
