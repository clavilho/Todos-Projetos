using System;

namespace CotacaoDolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Cotador dolares = new Cotador();

            Console.Write("Qual é a cotação do dolar: ");
            dolares.Dolar = double.Parse(Console.ReadLine());

            Console.Write("Qual a quantidade de dolar que deseja comprar: ");
            dolares.Quantidade = double.Parse(Console.ReadLine());


            Console.WriteLine("O valor a ser pago em reais é: R$" + dolares.Pagamento());
           
        }
    }
}
