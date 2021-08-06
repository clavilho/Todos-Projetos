using CalculandoArea.Entities;
using CalculandoArea.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace CalculandoArea
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Forma> list = new List<Forma>();
            Console.WriteLine("Entre com a quantidade de figuras: ");
            int qnt = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qnt; i++)
            {
                Console.WriteLine($"Digite as informações da forma #{i}: ");
                Console.Write("Retangulo ou circulo (r/c)? ");
                char forma = char.Parse(Console.ReadLine());

                Console.WriteLine("Cor (Preto/Azul/Vermelho): ");
                Cor cor = Enum.Parse<Cor>(Console.ReadLine());

                if (forma == 'r')
                {
                    Console.WriteLine("Altura: ");
                    double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.WriteLine("Largura: ");
                    double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Retangulo(cor, largura, altura));
                }
                else if (forma == 'c')
                {
                    Console.Write("Raio: ");
                    double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Circulo(cor, raio));

                }

            }
            Console.WriteLine();
            Console.WriteLine("Areas: ");

            foreach (Forma forma in list)
            {
                Console.WriteLine(forma.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
