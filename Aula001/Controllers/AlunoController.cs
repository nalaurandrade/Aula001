using Aula001.Models;
using Microsoft.AspNetCore.Mvc;

namespace Aula001.Controllers
{
    [ApiController]
    [Route("api/aluno")]
    public class AlunoController : ControllerBase
    {
        private static List<Aluno> listaAlunos = new List<Aluno>();

        [HttpPost]
        [Route("CriarAluno")]

        public IActionResult CriarAluno (Aluno novoAluno)
        {
            if (ModelState.IsValid) 
            { 
                BadRequest(ModelState);
            }
            
            listaAlunos.Add(novoAluno);
            return Ok("Aluno Criado com sucesso!");
        }

        [HttpGet]
        [Route("ObterTodos")]
        public IActionResult ObterTodos()
        {
            return Ok(listaAlunos);
        }



        /*[HttpGet]
        [Route("SaudacaoNome")]
        public IActionResult SaudacaoNome(string nome)
        {
            return Ok($"Olá mundo {nome}");
        }

        [HttpPost]
        [Route("CriarAluno")]
        public IActionResult CriarAluno(Aluno aluno)
        {
            //depois vamos colocar aqui uma ação para um SD
            listaAlunos.Add(novoAluno);
            return Ok("Aluno Criado com sucesso!");
        }*/
    }
}
