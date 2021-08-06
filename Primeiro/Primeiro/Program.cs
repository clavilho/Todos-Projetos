using System;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {

            Triangulo x, y;
            double p;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas A B e C do triangulo A: ");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());


            Console.WriteLine("Entre com as medidas A B e C do triangulo B: ");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            double areaX = x.Area();
            Console.WriteLine("A area do triangulo A é: " + areaX);

            double areaY = y.Area();
            Console.WriteLine("A area do triangulo B é: " + areaY);


        }

    }
}
