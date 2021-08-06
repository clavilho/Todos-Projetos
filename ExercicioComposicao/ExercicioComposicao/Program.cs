using ExercicioComposicao.Entities;
using ExercicioComposicao.Entities.Enums;
using System;

namespace ExercicioComposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Trabalhador trabalhador;
            string departament;
            string name;
            NivelTrabalhador nivel;
            double salario;
            int contratos;


            Console.WriteLine("------------------------------------");
            Console.Write("DIGITE O NOME DO DEPARTAMENTO: ");
            departament = Console.ReadLine();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Entre com os dados do trabalhador: ");
            Console.WriteLine("------------------------------------");
            Console.Write("Nome: ");
            name = Console.ReadLine();
            Console.WriteLine("------------------------------------");
            Console.Write("Level (Junior/MidLevel/Senior): ");
            nivel = Enum.Parse<NivelTrabalhador>(Console.ReadLine());
            Console.WriteLine("------------------------------------");
            Console.Write("Salario base: ");
            salario = double.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------");

            Console.Write("Quantos contratos: ");
            contratos = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------");

            Departamento dept = new Departamento(departament);
            trabalhador = new Trabalhador(name, nivel, salario, dept);

            for (int i = 1; i <= contratos; i++)
            {
                Console.WriteLine($"Digite a data do #{i} contrato: ");
                Console.WriteLine("------------------------------------");
                Console.Write("Data (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("Valor por hora: ");
                double valorPorHora = double.Parse(Console.ReadLine());

                Console.Write("Duração (horas): ");
                int hours = int.Parse(Console.ReadLine());
                Console.WriteLine("------------------------------------");


                HorasContrato contrato = new HorasContrato(date, valorPorHora, hours);

                trabalhador.AddContract(contrato);

            }
            Console.Write("Entre com o mes e ano para calcular o ganho (MM/YYYY): ");
            string mesEano = Console.ReadLine();
            /*Substring utilizado para dividir a string*/
            int mes = int.Parse(mesEano.Substring(0, 2));
            int ano = int.Parse(mesEano.Substring(3));

            Console.WriteLine();
            Console.WriteLine("Nome: " + trabalhador.Name);
            Console.WriteLine("Departamento: " + trabalhador.Department.Name);
            Console.WriteLine("Recebeu no periodo de " + mesEano + ": " + trabalhador.Income(ano, mes).ToString("F2"));

        }
    }
}
