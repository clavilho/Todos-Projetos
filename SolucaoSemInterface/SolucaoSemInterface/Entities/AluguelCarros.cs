using System;
using System.Collections.Generic;
using System.Text;

namespace SolucaoSemInterface.Entities
{
    class AluguelCarros
    {
        public DateTime Aluguel { get; set; }
        public DateTime Devolucao { get; set; }
        public Veiculo Veiculo { get; set; }
        public Fatura Fatura { get; set; }

        public AluguelCarros(DateTime aluguel, DateTime devolucao, Veiculo veiculo)
        {
            Aluguel = aluguel;
            Devolucao = devolucao;
            Veiculo = veiculo;
            Fatura = null;
        }
    }
}
