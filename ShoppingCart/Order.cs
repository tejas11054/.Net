using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public List<LineItem> Items { get; set; }

        public Order(int id, DateTime date)
        {
            Id = id;
            Date = date;
            Items = new List<LineItem>();
        }

        public void AddLineItem(LineItem item)
        {
            Items.Add(item);
        }

        public double CalculateOrdePrice()
        {
            double total = 0;
            foreach (LineItem item in Items)
            {
                total += item.CalculateLineItemCost();
            }
            return total;
        }
    }
}
