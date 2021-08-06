using ExercicioProdutos.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Products> list = new List<Products>();

            Console.Write("Digite a quantidade de produtos: ");
            int quantidade = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantidade; i++)
            {
                Console.WriteLine($"Dados do protudo #{i}:");
                Console.Write("Comum, usado ou importado (c,u,i)? ");
                char tipo = char.Parse(Console.ReadLine());
                if (tipo == 'c')
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();

                    Console.Write("Preço: ");
                    double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Products(nome, preco));

                }
                else if (tipo == 'u')
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();

                    Console.Write("Preço: ");
                    double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Data de fabricação (DD/MM/YYYY): ");
                    DateTime fabricacao = DateTime.Parse(Console.ReadLine());

                    list.Add(new UsadosProdutos(nome, preco, fabricacao));

                }
                else if (tipo == 'i')
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();

                    Console.Write("Preço: ");
                    double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Taxa de alfandega: ");
                    double alfandega = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportadosProdutos(nome, preco, alfandega));


                }
            }
            Console.WriteLine("PREÇO TAGS");
            foreach (Products item in list)
            {
                Console.WriteLine(item.PriceTag());
            }
        }

    }
}
