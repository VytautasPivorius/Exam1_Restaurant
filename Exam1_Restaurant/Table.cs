using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1_Restaurant
{
    public class Table
    {
        public string TableNumber { get; set; }
        public bool IsFree { get; set; }
        public List<Meal> OrderedMeals { get; set; } = new List<Meal> ();

        public Table(string tableNumber, bool isFree)
        {
            TableNumber = tableNumber;
            IsFree = isFree;
        }
        public void AddProductToOrder(string selection, Menu menu, int quantity)
        {
            foreach (Meal meal in menu.Products)
            {
                if (meal.Code == selection)
                {
                    Meal orderedMeal = new Meal(meal.Group, meal.Code, meal.Title, meal.Price);
                    orderedMeal.Quantity = quantity;
                    OrderedMeals.Add(orderedMeal);
                }
            }
        }
        public enum TableName
        {
            Table1,
            Table2,
            Table3,
            Table4,
            Table5,
            Table6
        }
    }
}
