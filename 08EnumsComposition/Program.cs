using System;
using System.Globalization;
using EnumsComposition.Entities;
using EnumsComposition.Entities.Enums;

namespace EnumsComposition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string clientEmail = Console.ReadLine();
            Console.Write("BirthDate date (DD/MM/YYYY): ");
            DateTime clientBirthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter order data:");
            Console.Write("Status: ");
            OrderStatus status = new OrderStatus();
            Enum.TryParse(Console.ReadLine(), out status);

            Client client = new Client(clientName, clientEmail, clientBirthDate);
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nEnter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double priceProduct = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(productName, priceProduct);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, priceProduct, product);
                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY: ");
            Console.WriteLine(order);
        }
    }
}