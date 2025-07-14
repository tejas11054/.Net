using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double DiscountPercentage { get; set; }

        public Product(int id, string name, double price, double discountPercentage)
        {
            Id = id;
            Name = name;
            Price = price;
            DiscountPercentage = discountPercentage;
        }

        public double GetPercentageDiscount()
        {
            return Price - (Price * DiscountPercentage / 100);
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"\nId = {Id}, Name = {Name}, Discount Percentage = {DiscountPercentage}, Original Price = {Price}, Discounted Price = {GetPercentageDiscount()}");
        }
    }
}
