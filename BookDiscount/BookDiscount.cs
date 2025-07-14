using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDiscount
{
    internal class BookDiscount
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public bool IsBestSeller { get; set; }

        public BookDiscount(string title, string author, double price, bool isBestSeller)
        {
            Title = title;
            Author = author;
            Price = price;
            IsBestSeller = isBestSeller;
        }

        public double CalculateDiscountedPrice()
        {
            double discountedPrice = Price;
            if (IsBestSeller)
                discountedPrice *= 0.9;

            if (Price > 500)
                discountedPrice *= 0.95;

            return discountedPrice;
        }

        public void DisplayBookDetails()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, Best Seller: {(IsBestSeller ? "Yes" : "No")}, Original Price; {Price}, Discounted Price: {CalculateDiscountedPrice()}");
        }
    }

}
