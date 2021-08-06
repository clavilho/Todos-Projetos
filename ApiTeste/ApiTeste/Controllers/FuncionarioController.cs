using ApiTeste.Data;
using ApiTeste.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTeste.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FuncionarioController : ControllerBase
    {
        private FuncionarioContext _context;

        public FuncionarioController(FuncionarioContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult AdicionarFuncionario([FromBody] Funcionario funcionario)
        {
            _context.Add(funcionario);
            return Ok(funcionario);
        }

    }
}
