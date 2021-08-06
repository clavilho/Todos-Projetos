using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioComposicao.Entities
{
    class HorasContrato
    {
        private double valorPorHora;

        public HorasContrato(DateTime date, double valorPorHora, int hours)
        {
            Date = date;
            this.valorPorHora = valorPorHora;
            Hours = hours;
        }

        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public double totalValue()
        {
            return ValuePerHour * Hours;
        }
    }
}
