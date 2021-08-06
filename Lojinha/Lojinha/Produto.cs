using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Lojinha
{
    class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto(string nome, double preco, int qtd)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = qtd;
        }


        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }
        public void AdicionarPorduto(int quantidade)
        {
            Quantidade += quantidade;

        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;

        }
        public override string ToString()
        {
            return _nome + ": $" + Preco.ToString("F2") + ", " + Quantidade + " unidades, Total: " + ValorTotalEmEstoque().ToString("F2");

        }
    }
}
