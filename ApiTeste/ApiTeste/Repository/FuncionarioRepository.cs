using ApiTeste.Data;
using ApiTeste.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTeste.Repository
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        private FuncionarioContext _funcContext;


        public FuncionarioRepository(FuncionarioContext funcContext)
        {
            _funcContext = funcContext;
        }

        public async Task AddFuncionario(Funcionario func)
        {
            _funcContext.Add(func);


        }


        public Task GetAllFuncionarios()
        {
            throw new NotImplementedException();
        }

        public ValueTask<Funcionario> GetFuncById(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveFuncionario(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateFuncionario(Funcionario func, int id)
        {
            throw new NotImplementedException();
        }
    }
}
