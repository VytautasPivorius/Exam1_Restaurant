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
        public List<Meal> Products { get; } = new List<Meal>();

        public Menu(List<string> menuContent) 
        {
            _MenuContent = menuContent;
            CreateProducts();
        }

        public void ShowMenu()
        {
            foreach(var item in Products)
            {
                Console.WriteLine($"[{item.Code}] {item.Title}-{item.Price}EUR");
            }
        }
        private void CreateProducts()
        {
            foreach (string line in _MenuContent)
            {
                string[] parts = line.Split(';');
                string group = parts[0];
                string productNumber = parts[1];
                string title = parts[2];
                decimal cost = decimal.Parse(parts[3]);

                Products.Add(new Meal(group, productNumber, title, cost));
            }
        }
    }
}
