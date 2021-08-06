using System;

namespace Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();

            Console.WriteLine("Digite as informações de um retangulo");
            Console.Write("Altura: ");
            ret.Altura = int.Parse(Console.ReadLine());

            Console.Write("Largura: ");
            ret.Largura = int.Parse(Console.ReadLine());

            Console.WriteLine("AREA: "+ret.Area());
            Console.WriteLine("PERIMETRO: "+ ret.Perimetro());
            Console.WriteLine("DIAGONAL: "+ ret.Diagonal());

        }
    }
}
