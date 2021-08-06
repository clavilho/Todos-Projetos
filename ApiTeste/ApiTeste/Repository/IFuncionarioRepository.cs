using ApiTeste.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTeste.Repository
{
    public interface IFuncionarioRepository
    {
        ValueTask<Funcionario> GetFuncById(int id);
        Task AddFuncionario(Funcionario func);
        Task UpdateFuncionario(Funcionario func, int id);
        Task RemoveFuncionario(int id);
        Task GetAllFuncionarios();
    }
}
