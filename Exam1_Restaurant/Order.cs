using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1_Restaurant
{
    public class Order : IPrint
    {
        public string TableNumber { get; set; }
        public List<Meal> Meals { get; set; } = new List<Meal>();
        public decimal TotalSum { get; private set; }
        public DateTime Date { get; set; }

        public Order(string tableNumber, List<Meal> products, DateTime dateTime)
        {
            TableNumber = tableNumber;
            Meals = products;
            Date = dateTime;

            TotalSum = CalucalateTotal();
        }
        public void AddProductToOrder(string selection, Menu menu, int quantity)
        {
            foreach (Meal meal in menu.Products)
            {
                if (meal.Code == selection)
                {
                    Meal orderedMeal = new Meal(meal.Group, meal.Code, meal.Title, meal.Price);
                    orderedMeal.Quantity = quantity;
                    Meals.Add(orderedMeal);
                }
            }
        }

        public void Print()
        {
            Console.WriteLine("----KVITAS----");
            Console.WriteLine($"Data:{Date}");
            Console.WriteLine($"Staliuko numeris: {TableNumber}");
            Console.WriteLine("--------------------------------");
            ShowItems();
            Console.WriteLine($"Bendra suma: {TotalSum}");
        }
        public void Show()
        {
            ShowItems();
            Console.WriteLine($"Bendra suma: {TotalSum}");
        }

        private void ShowItems()
        {
            if (Meals.Count < 1)
            {
                Console.WriteLine("Uzsakymas tuscias");
            }
            else
            {
                foreach (var meal in Meals)
                {

                    Console.Write($"{meal.Title} - ");
                    Console.WriteLine($"{meal.Price}EUR (X{meal.Quantity}) - SUMA:{meal.Price * meal.Quantity}EUR");

                }
            }
        }

        private decimal CalucalateTotal()
        {
            if (Meals.Count < 1)
            {
                return 0;
            }
            return Meals.Sum(x => x.Quantity * x.Price);
        }
    }
}
