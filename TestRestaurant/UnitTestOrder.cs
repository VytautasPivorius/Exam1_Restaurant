using Exam1_Restaurant;

namespace TestRestaurant
{
    [TestClass]
    public class UnitTestOrder
    {
        [TestMethod]
        public void CalculateTotal_WithoutQuantity_ReturnsZero()
        {
            // Arrange
            var meal = new Meal("Group1", "101", "Burgeris", 5.0m);
            List<Meal> meals = new List<Meal>() { meal };

            Order order = new Order();

            // Act
            decimal total = order.CalucalateTotal(meals);

            // Assert
            Assert.AreEqual(0, total);
        }

        [TestMethod]
        public void CalculateTotal_WithQuantity_ReturnsCorrectTotal()
        {
            // Arrange
            var meal = new Meal("Group1", "101", "Burgeris", 5.0m);
            meal.Quantity = 2;

            List<Meal> meals = new List<Meal>() { meal };

            Order order = new Order();

            // Act
            decimal total = order.CalucalateTotal(meals);

            // Assert
            Assert.AreEqual(10.0m, total);
        }

        [TestMethod]
        public void CalculateTotal_MultipleMeals_ReturnsCorrectTotal()
        {
            // Arrange;
            var meal1 = new Meal("Group1", "101", "Burgeris", 5.0m);
            meal1.Quantity = 2;

            var meal2 = new Meal("Group1", "102", "Bulvytes", 5.0m);
            meal2.Quantity = 1;

            List<Meal> meals = new List<Meal>() { meal1, meal2 };
            Order order = new Order();

            // Act
            decimal total = order.CalucalateTotal(meals);

            // Assert
            Assert.AreEqual(15.00m, total);
        }
        [TestMethod]
        public void CleanAfterPayment_ValidTable_CleanMealsAndFreeTable()
        {
            // Arrange
            var table = new Table("1", false);
            table.OrderedMeals.Add(new Meal("Group1", "101", "Burgeris", 5.0m) { Quantity = 2 });
            Order order = new Order();

            // Act
            order.CleanAfterPayment(table);

            // Assert
            Assert.IsTrue(table.IsFree);
            Assert.AreEqual(0, table.OrderedMeals.Count);
        }
    }
}
