using Exam1_Restaurant;

namespace TestRestaurant
{
    [TestClass]
    public class UnitTestRestaurant
    {
        [TestMethod]
        public void GetCurrentTable_ValidTableNumber_ReturnsTable()
        {
            // Arrange
            var restaurant = new Restaurant();
            var expectedTableNumber = "1"; 

            // Act
            Table resultTable = restaurant.GetCurrentTable(expectedTableNumber);

            // Assert
            Assert.IsNotNull(resultTable);
            Assert.AreEqual(expectedTableNumber, resultTable.TableName);
        }

        [TestMethod]
        public void GetCurrentTable_InvalidTableNumber_ReturnsNull()
        {
            // Arrange
            var restaurant = new Restaurant();
            var invalidTableNumber = "99";

            // Act
            Table resultTable = restaurant.GetCurrentTable(invalidTableNumber);

            // Assert
            Assert.IsNull(resultTable);
        }
    }
}