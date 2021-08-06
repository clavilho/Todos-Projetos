using System;
using System.Collections.Generic;
using System.Text;

namespace CotacaoDolar
{
    class Cotador
    {
        public double Dolar;
        public double Quantidade;


        public double Pagamento()
        {
            return Dolar * Quantidade;
        }
    }
}
