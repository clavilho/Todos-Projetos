using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercicioProdutos.Entities
{
    class ImportadosProdutos : Products
    {
        public double CustomFee { get; set; }


        public ImportadosProdutos() { }

        public ImportadosProdutos(string nome, double preco, double customFee) : base(nome, preco)
        {
            CustomFee = customFee;
        }

        public double TotalPrice()
        {
            return Preco += CustomFee;
        }

        public override string PriceTag()
        {
            return base.PriceTag() + " (Taxa de alfandega: $ " + CustomFee.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }

    }
}
