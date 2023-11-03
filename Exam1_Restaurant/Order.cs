using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1_Restaurant
{
    public class Order
    {
        public Table Table { get; set; }
        public List<MealOrdered> Products { get; set; } = new List<MealOrdered>();
        public DateTime DateTime { get; set; }

        public Order(Table table, List<MealOrdered> products, DateTime dateTime)
        {
            Table = table;
            Products = products;
            DateTime = dateTime;
        }

        public void AddProductToOrder()
        {

        }
    }
}
