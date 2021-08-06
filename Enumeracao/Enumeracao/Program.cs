using Enumeracao.Entities;
using Enumeracao.Entities.Enums;
using System;

namespace Enumeracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            /*Conversão de enum para string*/
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);


            /*Conversão de string para enum*/
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);



        }
    }
}
