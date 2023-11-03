using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1_Restaurant
{
    public class Restaurant
    {
        public List<Table> Tables { get; } = new List<Table>();
        public Restaurant() 
        {
            Tables.Add(new Table("1", true));
            Tables.Add(new Table("2", true));
            Tables.Add(new Table("3", true));
            Tables.Add(new Table("4", true));
            Tables.Add(new Table("5", true));
            Tables.Add(new Table("6", true));

        }
        public void ShowTables()
        {
            foreach (var item in Tables)
            {
                Console.Write($"Staliukas Nr.{item.TableNumber}-");
                if (item.IsFree == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Laisvas");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Uzimtas");
                    Console.ResetColor();
                }
            }
        }
        public enum TableName//Gal panaudoti reiktu
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
