using CalculandoArea.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculandoArea.Entities
{
    abstract class Forma
    {
        public Cor Color { get; set; }

        public Forma() { }

        public Forma(Cor color)
        {
            Color = color;
        }

        public abstract double Area();
       
    }
}
