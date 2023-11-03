using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1_Restaurant
{
    public class Table
    {
        public string TableNumber { get; set; }
        public bool IsFree { get; set; }
        public Order Order { get; set; }

        public Table(string tableNumber, bool isFree)
        {
            TableNumber = tableNumber;
            IsFree = isFree;
        }

        public void AddProductToOrder()
        {

        }

    }
}
