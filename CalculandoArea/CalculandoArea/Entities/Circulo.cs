using CalculandoArea.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculandoArea.Entities
{
    class Circulo : Forma
    {
        public double Raio { get; set; }

        public Circulo(Cor color, double raio) : base(color)
        {
            Raio = raio;
        }

        public override double Area()
        {
            return Math.PI * Raio * Raio;
        }
    }
}
