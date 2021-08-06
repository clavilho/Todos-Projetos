using ExercicioComposicao.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioComposicao.Entities
{
    class Trabalhador
    {
        public string Name { get; set; }
        public NivelTrabalhador Level { get; set; }
        public double BaseSalary { get; set; }
        public Departamento Department { get; set; }
        public List<HorasContrato> Contratos { get; set; } = new List<HorasContrato>();


        public Trabalhador() { }

        public Trabalhador(string name, NivelTrabalhador level, double baseSalary, Departamento department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HorasContrato contract)
        {
            Contratos.Add(contract);
        }

        public void RemoveContract(HorasContrato contrato)
        {
            Contratos.Remove(contrato);
        }

        public double Income(int ano, int mes)
        {
            double sum = BaseSalary;

            foreach (HorasContrato item in Contratos)
            {
                if( item.Date.Year == ano && item.Date.Month == mes)
                {
                    sum += item.totalValue();
                }
            }

            return sum;
        }
    }
}
