using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTeste.Model
{
    public class Funcionario
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Cpf { get; private set; }
        public int Idade { get; private set; }
        public string Cargo { get; private set; }
        public double Salario { get; private set; }

        public Funcionario(string name, int cpf, int idade, string cargo, double salario)
        {
            Name = name;
            Cpf = cpf;
            Idade = idade;
            Cargo = cargo;
            Salario = salario;
        }
       


    }
}
