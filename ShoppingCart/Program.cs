namespace ShoppingCart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product laptop = new Product(101, "Laptop", 60000, 10);
            Product Smartphone = new Product(102, "Smartphone", 35000, 15);

            //create line item
            LineItem item1 = new LineItem(101, 2, laptop);
            LineItem item2 = new LineItem(102, 3, Smartphone);

            //create an order and add line items
            Order order = new Order(1, DateTime.Now);
            order.AddLineItem(item1);
            order.AddLineItem(item2);

            //create a customer and assign the order
            Customer c = new Customer(1001, "Tejas");
            c.AddOrder(order);

            //Display order summary
            Console.WriteLine($"Customer: {c.Name}, ID: {c.Id}");
            Console.WriteLine($"Order ID: {order.Id}, Date: {order.Date.ToShortDateString()}\n");

            Console.WriteLine($"{"ID",-5} {"Name",-10} {"Quantity",-5} {"UnitPrice",-12} {"Total",-10}");
            foreach(var item in order.Items)
            {
                Console.WriteLine($"{item.Id,-5} {item.Product.Name,-10} {item.Quantity,-5} {item.Product.GetPercentageDiscount(),-12:f2} {item.CalculateLineItemCost(),-10:F2}");
            }
            Console.WriteLine($"\nTotal Order Price: {order.CalculateOrdePrice():F2}");
        }
    }
}
