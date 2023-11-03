using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1_Restaurant
{
    public class Menu
    {
        public List<string> _MenuContent = new List<string>();
        public List<Meal> Meals { get; } = new List<Meal>();

        public Menu(List<string> menuContent) 
        {
            _MenuContent = menuContent;
            CreateMeals();
        }
        public void ShowMenu()
        {
            foreach(var item in Meals)
            {
                Console.WriteLine($"[{item.ProductNumber}] {item.Title}-{item.Price}EUR");
            }
        }
        private void CreateMeals()
        {
            foreach (string line in _MenuContent)
            {
                string[] parts = line.Split(';');
                string group = parts[0];
                string productNumber = parts[1];
                string title = parts[2];
                decimal cost = decimal.Parse(parts[3]);

                Meals.Add(new Meal(group, productNumber, title, cost));
            }
        }
    }
}
