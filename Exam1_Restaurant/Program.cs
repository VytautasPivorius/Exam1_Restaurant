using System.Transactions;

namespace Exam1_Restaurant
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> menuContent = File.ReadLines(FilePaths.MenuPath).ToList();

            Menu menu = new Menu(menuContent);
            menu.ShowMenu();

            Restaurant restaurant = new Restaurant();

            restaurant.ShowTables();

        }

    }
}