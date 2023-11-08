using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1_Restaurant
{
    public class Order : IPrint
    {

        public Order()
        {

        }
        

        public void PrintOrder(Table table)
        {
            Console.Clear();
            Console.WriteLine("________________KVITAS_________________");
            Console.WriteLine($"Data:{DateTime.Now}");
            Console.WriteLine($"Staliuko numeris: {table.TableName}");
            Console.WriteLine("---------------------------------------");
            ShowItems(table.OrderedMeals);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"MOKETI: {CalucalateTotal(table.OrderedMeals)} EUR");
            Console.ResetColor();
            CleanAfterPayment(table);

        }
        private void ShowOrder(List<Meal> meals)
        {
            ShowItems(meals);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"MOKETI: {CalucalateTotal(meals)} EUR");
            Console.ResetColor();
            Console.WriteLine("---------------------------------------");

        }

        private void ShowItems(List<Meal> meals)
        {
            if (meals.Count < 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Uzsakymas tuscias");
                Console.ResetColor();
            }
            else
            {
                foreach (var meal in meals)
                {
                    string itemLine = $"{meal.Title} ({meal.Price} EUR X {meal.Quantity})";
                    Console.Write(itemLine);
                    Console.WriteLine($"{meal.Price * meal.Quantity} EUR".PadLeft(60 - itemLine.Length));
                }
            }
        }

        public decimal CalucalateTotal(List<Meal> meals)
        {
            if (meals.Count < 1)
            {
                return 0;
            }
            return meals.Sum(x => x.Quantity * x.Price);
        }
        public void CreateOrder(Menu menu,Table table)
        {
            while (true)
            {
                menu.ShowMenu();

                ShowOrder(table.OrderedMeals);

                Console.WriteLine("Grizti atgal -> Q");

                Console.Write("Iveskite produkto koda:");

                string selectedProduct = Console.ReadLine().ToUpper();

                if (selectedProduct == "Q") { break; } //Back

                Console.Write("Iveskite produkto kieki:");
                int selectedQuantity = int.Parse(Console.ReadLine());

                table.AddProductToOrder(selectedProduct, menu, selectedQuantity);

                Console.Clear();
            }
        }
        public void CleanAfterPayment(Table table)
        {
            table.IsFree = true;
            table.OrderedMeals.Clear();
        }
    }
}
