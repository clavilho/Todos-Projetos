using System;

namespace PessoaMaisVelha
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa,pessoa1;
            pessoa = new Pessoa();
            pessoa1 = new Pessoa();

            Console.WriteLine("Dados Pessoa 1");
            Console.Write("Digite seu nome: ");
            pessoa.Nome = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            pessoa.Idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("-----------------");

            Console.WriteLine("Dados Pessoa 2");
            Console.Write("Digite seu nome: ");
            pessoa1.Nome = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            pessoa1.Idade = Convert.ToInt32(Console.ReadLine());


            if(pessoa1.Idade > pessoa.Idade)
            {
                Console.WriteLine($"{pessoa1.Nome} é mais velho(a)");
            }
            else{
                Console.WriteLine($"{pessoa.Nome} é mais velho(a)");

            }

        }
    }
}
