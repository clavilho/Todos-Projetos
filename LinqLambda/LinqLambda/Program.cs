using LinqLambda.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
namespace LinqLambda
{
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Eletronics", Tier = 1 };

            List<Product> products = new List<Product>(){
                new Product(){Id =1, Name= "Computer",Price= 1100.00, Category =c2},
                new Product(){Id =2, Name= "Hamer",Price= 90.00, Category =c1},
                new Product(){Id =3, Name= "TV",Price= 1700.00, Category =c3},
                new Product(){Id =4, Name= "Notebook",Price= 1300.00, Category =c2},
                new Product(){Id =5, Name= "Saw",Price= 80.00, Category =c1},
                new Product(){Id =6, Name= "Tablet",Price= 700.00, Category =c2},
                new Product(){Id =7, Name= "Camera",Price= 700.00, Category =c3},
                new Product(){Id =8, Name= "Printer",Price= 350.00, Category =c3},
                new Product(){Id =9, Name= "MacBook",Price= 1800.00, Category =c2},
                new Product(){Id =10, Name= "Sound Bar",Price= 700.00, Category =c3},
                new Product(){Id =11, Name= "Level",Price= 70.00, Category =c1}

                };
            var r1 =
                from p in products
                where p.Category.Tier == 1 && p.Price < 900
                select p;
            Print("Tier 1 e Preço < 900", r1);

            // var r2 = products.Where(p => p.Category == c1).Select(p => p.Name);
            var r2 = from p in products
                     where p.Category == c1
                     select p.Name;
            Print("NAMES OF PRODUCTS FROM TOOLS", r2);


            // var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            var r3 = from p in products
                     where p.Name[0] == 'C'
                     select new { p.Name, p.Price, CategoryName = p.Category.Name };
            Print("Nomes começando com C", r3);


            var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("Tier 1 ordenado por preço e então ordenado por nome", r4);


            var r5 = r4.Skip(2).Take(4);
            Print("Tier 1 ordenado por preço e então ordenado por nome skip 2 take 4", r5);

            var r6 = products.First();
            Console.WriteLine("First teste 1: " + r6);

            var r7 = products.Where(p => p.Price > 3000.0).FirstOrDefault();
            Console.WriteLine("First teste 2" + r7);



        }
    }
}
