using SolucaoSemInterface.Entities;
using SolucaoSemInterface.Services;
using System;
using System.Globalization;

namespace SolucaoSemInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do aluguel: ");
            Console.Write("Modelo do carro: ");
            string modelo = Console.ReadLine();

            Console.Write("Hora de retirada do veiculo (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Hora de devolução do veiculo (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Digite o preço por hora: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o preço por dia: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            AluguelCarros carroAlugado = new AluguelCarros(start, finish, new Veiculo(modelo));

            AluguelService aluguelService = new AluguelService(hour, day, new BrasilTaxService());

            aluguelService.ProcessoFatura(carroAlugado);

            Console.WriteLine("FATURA: ");
            Console.WriteLine(carroAlugado.Fatura);

        }
    }
}
