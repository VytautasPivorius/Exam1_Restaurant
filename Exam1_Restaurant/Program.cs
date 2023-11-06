using System.Transactions;

namespace Exam1_Restaurant
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> menuContent = File.ReadLines(FilePaths.MenuPath).ToList();

            Restaurant restaurant = new Restaurant();
            while (true)
            {
                Console.Clear();
                restaurant.ShowTables();
                Console.WriteLine("Pasirinkite stala:");
                string tableSelection = Console.ReadLine();

                Table currentTable = restaurant.GetCurrentTable(tableSelection);
                while (true)
                {
                    Console.Clear();

                    Console.WriteLine("1-PRIIMTI UZSAKYMA");
                    Console.WriteLine("2-FORMUOTI SASKAITA");
                    Console.WriteLine("3-ATLAISVINTI STALIUKA");
                    string functionSelection = Console.ReadLine().ToUpper();

                    if (functionSelection == "Q")
                    {
                        break;
                    }

                    if (functionSelection == "1")
                    {
                        currentTable.IsFree = false;
                        Console.Clear();
                        Menu menu = new Menu(menuContent);
                        
                        currentTable.Order = new Order(currentTable.TableNumber, new List<Meal>(), DateTime.Now);
                        while (true)
                        {

                            menu.ShowMenu();
                            Console.WriteLine("------------------------------");
                            currentTable.Order.Show();
                            Console.Write("Iveskite produkto koda:");
                            string selectedProduct = Console.ReadLine().ToUpper();

                            if (selectedProduct == "Q")
                            {
                                break;
                            }

                            Console.Write("Iveskite produkto kieki:");
                            int selectedQuantity = int.Parse(Console.ReadLine());

                            currentTable.Order.AddProductToOrder(selectedProduct, menu, selectedQuantity);

                            Console.Clear();
                        }
                    }
                    else if (functionSelection == "2")
                    {
                        
                        currentTable.Order.Print();
                        currentTable.IsFree = true;
                        currentTable.Order.Meals.Clear();
                        functionSelection = Console.ReadLine();
                        if (functionSelection == "Q")
                        {
                            break;
                        }
                    }
                    else if(functionSelection == "3")
                    {
                        currentTable.IsFree=true;
                    }
                }
            }
        }

    }
}