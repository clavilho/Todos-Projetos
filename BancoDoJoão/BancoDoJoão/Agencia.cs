using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
namespace BancoDoJoão
{
    class Agencia
    {
        private int _conta;
        public string Titular { get; set; }
        public double ValorConta { get; private set; }

        public int Conta
        {
            get { return _conta; }
            set
            {
                if (value != int.Parse(""))
                {
                    _conta = value;
                }

            }
        }

        public Agencia(int conta, string titular, double deposito)
        {
            _conta = conta;
            Titular = titular;
            ValorConta = deposito;
        }

        public Agencia(int conta, string titular)
        {
            _conta = conta;
            Titular = titular;
        }
        public double Depositar(double deposito)
        {
            return ValorConta += deposito;

        }

        public double Sacar(double saque)
        {
            return ValorConta -= saque + 5;
        }

        public override string ToString()
        {
            return "Conta: " + _conta + ", Titular: " + Titular + ", Saldo: $" + ValorConta.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
