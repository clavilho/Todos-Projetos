using System;
using System.Globalization;
namespace BancoDoJoão
{
    class Program
    {
        static void Main(string[] args)
        {
            string titular;
            int conta;
            double deposito;
            string respostaInicial;

            Console.Write("Digite o número da conta: ");
            conta = int.Parse(Console.ReadLine());

            Console.Write("Titular da conta: ");
            titular = Console.ReadLine();

            Console.Write("Haverá  deposito inicial (s/n)?");
            respostaInicial = Console.ReadLine();
            Agencia contaCriada = new Agencia(conta, titular);

            if (respostaInicial == "s"  || respostaInicial == "S")
            {
                Console.Write("Entre com o valor do deposito inicial: ");
                deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                contaCriada.Depositar(deposito);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(contaCriada.ToString());

            Console.Write("Digite o valor do deposito: ");
            deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaCriada.Depositar(deposito);


            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(contaCriada.ToString());

            Console.Write("Digite o valor do saque: ");
            deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaCriada.Sacar(deposito);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(contaCriada.ToString());

        }


    }

}

