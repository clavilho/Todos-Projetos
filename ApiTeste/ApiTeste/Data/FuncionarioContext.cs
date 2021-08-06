using ApiTeste.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTeste.Data
{
    public class FuncionarioContext : DbContext
    {
        public FuncionarioContext(DbContextOptions<FuncionarioContext> opt) : base(opt)
        {

        }
        public DbSet<Funcionario> Funcionario { get; set; }
    }
}
