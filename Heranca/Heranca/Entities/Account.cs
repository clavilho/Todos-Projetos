using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca.Entities
{
    class Account
    {
        public int Number { get; protected set; }
        public string Holder { get; protected set; }
        public double Balance { get; protected set; }

        public Account() { }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Saque(double quantia)
        {
            Balance -= quantia + 5.0;
        }

        public void Deposito(double quantia)
        {
            Balance += quantia;
        }


    }
}
