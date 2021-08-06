using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;


namespace Funcionario
{
    class Funcionarios
    {
        public string Nome;
        public double Salario;
        public double Imposto;



        public double SalarioLiquido()
        {
            return Salario -= Imposto;
        }

        public double AumentarSalario(double porcentagem) 
        {
            porcentagem *= Salario;
            return Salario += porcentagem;
            
        }

        public override string ToString()
        {
            return Nome + ", " +SalarioLiquido().ToString("F2");
        }
    }
}
