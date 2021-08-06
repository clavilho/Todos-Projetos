using Empresa.Enteties;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Empresa
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Funcionario> list = new List<Funcionario>();


            Console.Write("Entre com o numero de funionarios: ");
            int funcionarios = int.Parse(Console.ReadLine());

            for (int i = 1; i <= funcionarios; i++)
            {
                Console.WriteLine($"Funcionario #{i} dados: ");
                Console.Write("Terceirizado (s/n)? ");
                string terceirizado = Console.ReadLine();

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Horas: ");
                int horas = int.Parse(Console.ReadLine());

                Console.Write("Valor por horas: ");
                double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (terceirizado == "s")
                {
                    Console.Write("Despesa adicional: ");
                    double despesas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Terceirizados(nome, horas, valorPorHora, despesas));

                }
                else
                {
                    list.Add(new Funcionario(nome, horas, valorPorHora));
                }


            }

            Console.WriteLine();
            Console.WriteLine("Pagamentos: ");
            foreach (var fun in list)
            {
                Console.WriteLine(fun.Nome + " - $ " + fun.Pagamento().ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
