using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1_Restaurant
{
    public class Meal
    {
        public string Group { get; set; }
        public string ProductNumber { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }

        public Meal(string group, string productNumber, string title, decimal price)
        {
            Group = group;
            ProductNumber = productNumber;
            Title = title;
            Price = price;
        }
    }
}
