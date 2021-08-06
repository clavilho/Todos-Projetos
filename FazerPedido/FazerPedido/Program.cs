using FazerPedido.Entities;
using FazerPedido.Entities.Enums;
using System;

namespace FazerPedido
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Console.Write("How many items to this order?");
            int qtd = int.Parse(Console.ReadLine());

            Cliente cliente = new Cliente(name, email, birthDate);
            Order order = new Order(DateTime.Now, status, cliente);

            for (int i = 1; i <= qtd; i++)
            {
                Console.WriteLine($"Enter #{i} items data: ");
                Console.WriteLine("Product Name: ");
                string itemName = Console.ReadLine();

                Console.WriteLine("Product Price: ");
                double price = double.Parse(Console.ReadLine());

                Product product = new Product(itemName, price);


                Console.WriteLine("Qauntity: ");
                int quantityProduct = int.Parse(Console.ReadLine());

                OrdemItem orderItem = new OrdemItem(quantityProduct, price, product);
            }

            Console.WriteLine();
            Console.WriteLine("Order Sumary: ");
            Console.WriteLine(order);

        }

    }
}
