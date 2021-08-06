using PostagemsProgram.Entities;
using System;

namespace PostagemsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Comentario c1 = new Comentario("Have a nice trip");
            Comentario c2 = new Comentario("Wow thats awesome");
            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country",
                12
                );
            p1.AddComentario(c1);
            p1.AddComentario(c2);

            Console.WriteLine(c1);

        }
    }
}
