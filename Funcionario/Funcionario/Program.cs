using System;

namespace Funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionarios joao = new Funcionarios();


            Console.WriteLine("Digite os dados do funcionario: ");

            Console.Write("Digite o nome: ");
            joao.Nome = Console.ReadLine();

            Console.Write("Digite o salario bruto: ");
            joao.Salario = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do imposto: ");
            joao.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("Funcionario: " + joao.ToString());


            Console.Write("Digite a porcentagem para aumentar o salario: ");
            double porcentagem = double.Parse(Console.ReadLine());

            joao.AumentarSalario(porcentagem);
            Console.WriteLine("Dados Atualizados: " + joao.ToString());




        }
    }
}
