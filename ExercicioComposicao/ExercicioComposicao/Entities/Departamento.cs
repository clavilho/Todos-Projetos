using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioComposicao.Entities
{
    class Departamento
    {
        public string Name { get; set; }

        public Departamento() { }

        public Departamento(string name)
        {
            Name = name;
        }
    }
}
