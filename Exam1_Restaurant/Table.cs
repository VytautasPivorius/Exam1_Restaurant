using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1_Restaurant
{
    public class Table
    {
        public string TableName { get; set; }
        public bool IsFree { get; set; }
        public List<Meal> OrderedMeals { get; set; } = new List<Meal> ();

        public Table(string tableName, bool isFree)
        {
            TableName = tableName;
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
    }
}
