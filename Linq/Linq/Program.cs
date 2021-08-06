using System;
using System.Collections.Generic;
using System.Linq;
namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Specify the data source
            int[] numbers = new int[] { 2, 3, 4, 5, 6 };

            //Definir the query exoressions
            IEnumerable<int> result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            //Executar a consulta
            foreach (int n in result)
            {
                Console.WriteLine(n);
            }
        }
    }
}
