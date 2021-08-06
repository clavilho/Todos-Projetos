using CalculandoArea.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculandoArea.Entities
{
    class Retangulo : Forma
    {
        public double Largura { get; set; }
        public double Altura { get; set; }


        public Retangulo(Cor color, double largura, double altura) : base(color)
        {
            Largura = largura;
            Altura = altura;
        }

        public override double Area()
        {
            return Largura * Altura;
        }
    }
}
