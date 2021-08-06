using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioProdutos.Entities
{
    class Products
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Products() { }

        public Products(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public virtual string PriceTag()
        {
            return Nome + "$ " + Preco.ToString("F2");
        }
    }
}
