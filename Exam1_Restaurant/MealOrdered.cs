using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exam1_Restaurant
{
    public class MealOrdered : Meal
    {
        public int Quantity { get; set; }
        
        public MealOrdered(string group,string productNumber,string title, decimal price,int quantity) : base(group,productNumber, title, price)
        {
            Group = group;
            ProductNumber = productNumber;
            Title = title;
            Price = price;
            Quantity = quantity;
        }
    }
}
