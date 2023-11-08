using System.Transactions;

namespace Exam1_Restaurant
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> menuContent = FileReader.ReadContent(FilePaths.MenuPath);
            
            Restaurant restaurant = new Restaurant();
            while (true) // while skirtas stalui pasirinkti
            {
                Console.Clear();
                restaurant.ShowTables();
                Console.WriteLine("Iseiti -> Q");
                Console.Write("Pasirinkite stala: ");
                
                string tableSelection = Console.ReadLine().ToUpper();

                if (tableSelection == "Q") { break; } //Back

                Table currentTable = restaurant.GetCurrentTable(tableSelection);
                while (true) //while skirtas meniu konkretaus stalo
                {
                    Console.Clear();

                    Console.WriteLine("1-PRIIMTI UZSAKYMA");
                    Console.WriteLine("2-FORMUOTI SASKAITA");
                    Console.WriteLine("3-ATLAISVINTI STALIUKA");
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Grizti atgal -> Q");
                    Console.Write("Pasirinkite funkcija: ");
                    string functionSelection = Console.ReadLine().ToUpper();

                    if (functionSelection == "Q") { break; } //Back

                    if (functionSelection == "1") //Uzsakymo priemimas
                    {
                        currentTable.IsFree = false;
                        Console.Clear();
                        
                        Menu menu = new Menu(menuContent);
                        Order order = new Order();

                        order.CreateOrder(menu, currentTable);
                    }
                    else if (functionSelection == "2") //Saskaitos formavimas
                    {
                        Order order = new Order();
                        
                        order.PrintOrder(currentTable.OrderedMeals, currentTable);
                        Console.WriteLine("Grizti atgal -> Q");
                        functionSelection = Console.ReadLine();

                        if (functionSelection == "Q") { break; } //Back

                    }
                    else if(functionSelection == "3") //Staliuko atlaisvinimas
                    {
                        Console.WriteLine("Grizti atgal -> Q");
                        Order order = new Order();
                        order.CleanAfterPayment(currentTable);
                    }
                }
            }
        }

    }
}