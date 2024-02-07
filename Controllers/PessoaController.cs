using APImodelo.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APImodelo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        [HttpGet("GetPessoa")]
        public Pessoa GetPessoa() 
        { 
            Pessoa VarPessoa = new Pessoa();

            VarPessoa.Id = 1;
            VarPessoa.Nome = "Alex";
            VarPessoa.NumeroDeCelular = "(18)999999999";
            

            return VarPessoa;
        }

        [HttpGet("GetPessoas")]

        public List<Pessoa> GetPessoas()
        {
            

            var VPessoa = new Pessoa();



            return VPessoa.Dados();
        }
    }
}
