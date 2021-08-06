using System;
using System.Globalization;
namespace SalarioMedio
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario1, funcionario2;
            double salarioMedio;

            funcionario1 = new Funcionario();
            funcionario2 = new Funcionario();


            Console.WriteLine("Dados do primeiro funcionario");
            Console.Write("Digite o nome: ");
            funcionario1.Nome = Console.ReadLine();

            Console.Write("Digite o salario: ");
            funcionario1.Salario = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Dados do segundo funcionario");
            Console.Write("Digite o nome: ");
            funcionario2.Nome = Console.ReadLine();

            Console.Write("Digite o salario: ");
            funcionario2.Salario = Convert.ToDouble(Console.ReadLine());

            salarioMedio = (funcionario2.Salario + funcionario1.Salario) / 2;

            Console.WriteLine($"A media salarial entre os funcionarios {funcionario1.Nome} e o {funcionario2.Nome} é de R${salarioMedio}");

        }
    }
}
