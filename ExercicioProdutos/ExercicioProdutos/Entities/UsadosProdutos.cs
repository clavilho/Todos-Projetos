using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioProdutos.Entities
{
    class UsadosProdutos : Products
    {
        public DateTime DataDeFabricacao { get; set; }

        public UsadosProdutos() { }

        public UsadosProdutos(string nome, double preco, DateTime dataDeFabricacao):base(nome,preco)
        {
            DataDeFabricacao = dataDeFabricacao;
        }

        public override string PriceTag()
        {
            return base.PriceTag() + " (usado) " + " (Data de fabricação: " + DataDeFabricacao.ToString() + ")";
        }
    }
}
