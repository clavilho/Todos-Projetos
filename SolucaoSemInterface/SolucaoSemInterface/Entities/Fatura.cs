using System.Globalization;

namespace SolucaoSemInterface.Entities
{
    class Fatura
    {
        public double PagamentoBase { get; set; }
        public double Taxa { get; set; }

        public Fatura(double pagamentoBase, double taxa)
        {
            PagamentoBase = pagamentoBase;
            Taxa = taxa;
        }

        public double PagamentoTotal
        {
            get { return PagamentoBase + Taxa; }

        }
        public override string ToString()
        {
            return "Pagamento base: " +
                PagamentoBase.ToString("F2", CultureInfo.InvariantCulture) +
                "\nTax: " +
                Taxa.ToString("F2", CultureInfo.InvariantCulture) +
                "\nPagamento total: " +
                PagamentoTotal.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
