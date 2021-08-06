using System;

namespace Lojinha
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500,10);
            Console.WriteLine(p.Nome);

            p.Nome = "TV LED";

            Console.WriteLine(p.Nome);

            p.Nome = "t";
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);
           
        }
    }
}
