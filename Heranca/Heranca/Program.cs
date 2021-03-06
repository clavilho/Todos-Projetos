using Heranca.Entities;
using System;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Account acc = new Account(1001, "Alex", 0.0);
             BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.00);


             //UPCASTING
             Account acc1 = bacc;
             Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
             Account acc3 = new SavingsAccount(1004, "Ana", 0.0, 0.01);


             //DOWNCASTING

             BusinessAccount acc4 = (BusinessAccount)acc2;
             acc4.Emprestimo(100.0);

             //BusinessAccount acc5 = (BusinessAccount)acc3;
             if (acc3 is BusinessAccount)
             {
                 // BusinessAccount acc5 = (BusinessAccount)acc3;
                 BusinessAccount acc5 = acc3 as BusinessAccount;
                 acc5.Emprestimo(200.0);
                 Console.WriteLine("Emprestado!");
             }
             if(acc3 is SavingsAccount)
             {
                 SavingsAccount acc5 = acc3 as SavingsAccount;
                 acc5.AtualizarSaldo();
                 Console.WriteLine("Atualizado!");
             }*/

            Account acc1 = new Account(1001, "Alex", 500);
            Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);


            acc1.Saque(10.0);
            acc2.Saque(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);

        }
    }
}
