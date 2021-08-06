using System;
using System.Collections.Generic;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            /*Add adiciona no ultimo lugar da lista*/
            list.Add("João");
            list.Add("Raquel");
            list.Add("Maria");
            list.Add("Rogerio");

            /*Insert adiciona no lugar definido por você da lista*/
            list.Insert(2, "Marco");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            /*Count mostra a contagem que tem dentro da lista*/
            Console.WriteLine(list.Count);


            /*Find usado para poder achar o primeiro elemento que possui as diretrizes da expressão da lista*/
            string s1 = list.Find((x) => x[0] == 'R');
            Console.WriteLine(s1);


            /*FindLast usado para poder achar o ultimo elemento que possui as diretrizes da expressão da lista*/
            string s2 = list.FindLast(x => x[0] == 'R');
            Console.WriteLine(s2);

            /*O FindIndex é usado para achar a posição do elemento que nesse caso tenha a primeira letra R*/
            int pos1 = list.FindIndex(x => x[0] == 'R');
            Console.WriteLine(pos1);


            /*O FindIndex é usado para achar a ultima do elemento que nesse caso tenha a primeira letra R*/
            int pos2 = list.FindLastIndex(x => x[0] == 'R');
            Console.WriteLine(pos2);

            List<string> list2 = list.FindAll(x => x.Length > 4);
            Console.WriteLine("----------------------------------------");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }
            
            Console.WriteLine("----------------------");
            /*Remove usado para remover algum parametro da lista*/
            list.Remove("João");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-------------------------------");

            list.RemoveAt(2);
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-------------------------------");
            list.RemoveAll(x => x[0] == 'M');
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
           
        }
    }
}
