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
        public string Code { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Meal(string group, string code, string title, decimal price)
        {
            Group = group;
            Code = code;
            Title = title;
            Price = price;
        }
    }
}
