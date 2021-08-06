using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa.Enteties
{
    class Terceirizados : Funcionario
    {
        public double DespesaAdicional { get; set; }


        public Terceirizados() { }

        public Terceirizados(string nome, int horas, double valorPorHora, double despesaAdicional) : base(nome, horas, valorPorHora)
        {
            DespesaAdicional = despesaAdicional;
        }

        public override double Pagamento()
        {
            return base.Pagamento() + 1.1 * DespesaAdicional;
        }
    }
}
