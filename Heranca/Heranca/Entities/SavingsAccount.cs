using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca.Entities
{
    class SavingsAccount : Account
    {
        public double TaxaJuros { get; set; }

        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance, double taxaJuros) : base(number, holder, balance)
        {
            TaxaJuros = taxaJuros;
        }

        public void AtualizarSaldo()
        {
            Balance += Balance * TaxaJuros;
        }
        public sealed override void Saque(double quantia)
        {
            //Balance -= quantia;

            //Base voce utilza para reutilizar o metodo que sobrescreveu e fazer mais alterações depois
            //Nesse caso no saque voce cobra os 5 reais e mais 2 reais nesse tipo de conta
            base.Saque(quantia);
            Balance -= 2.0;
        }
    }
}
