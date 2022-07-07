using System;
using DepartmentStore.Entities;
using DepartmentStore.Entities.Enum;
using System.Globalization;

namespace DepartmentStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name,email,date);

            Console.WriteLine("Enter Order Status: ");
            OrderStatus orderstatus = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order order = new Order(DateTime.Now, orderstatus, client);

            Console.Write("How many itens to this order? ");
            int amount = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= amount; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product Name: ");
                string nameItem = Console.ReadLine();

                Console.Write("Product Price: ");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Product product = new Product(nameItem, price);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, price, product);
                order.AddItem(orderItem);
            }
            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);


        }
    }
}