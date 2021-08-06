using SolucaoSemInterface.Entities;
using System;

namespace SolucaoSemInterface.Services
{
    class AluguelService
    {
        public double PrecoPorHora { get; private set; }
        public double PrecoPorDia { get; private set; }

        private ITaxService _taxService;

        public AluguelService(double precoPorHora, double precoPorDia, ITaxService taxService)
        {
            PrecoPorHora = precoPorHora;
            PrecoPorDia = precoPorDia;
            _taxService = taxService;
        }

        public void ProcessoFatura(AluguelCarros aluguelCarro)
        {
            TimeSpan duration = aluguelCarro.Devolucao.Subtract(aluguelCarro.Aluguel);

            double basicPayment = 0.0;
            if (duration.TotalHours <= 12)
            {
                basicPayment = PrecoPorHora * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PrecoPorDia * Math.Ceiling(duration.TotalDays);
            }
            double tax = _taxService.Tax(basicPayment);

            aluguelCarro.Fatura = new Fatura(basicPayment, tax);
        }
    }
}
