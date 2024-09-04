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

        [HttpGet]
        [Route("ObterPorCpf")]
        public IActionResult ObterPorCpf(string cpfBusca)
        {
            var resultadoBusca = listaAlunos
                                .Where(aluno => aluno.Cpf == cpfBusca)
                                .FirstOrDefault();
            if (resultadoBusca is null)
                return NotFound($"O cpf {cpfBusca} não encontrado");
                return Ok(resultadoBusca);
        }

        [HttpDelete]
        [Route("Remover")]
        public IActionResult Remover(string cpfBusca)
        {
            Aluno? resultadoBusca = listaAlunos
                                .Where(aluno => aluno.Cpf == cpfBusca)
                                .FirstOrDefault();

            if (resultadoBusca is null)
                return NotFound($"O cpf {cpfBusca} não encontrado");

            listaAlunos.Remove(resultadoBusca);

            return Ok("Aluno removido com sucesso!");
        }

        [HttpGet]
        [Route("Atualizar/{cpfBusca}")]
        public IActionResult Atualizar(string cpfBusca, 
                                                        Aluno alunoAtualizado)
        {
            Aluno? resultadoBusca = listaAlunos
                                .Where(aluno => aluno.Cpf == cpfBusca)
                                .FirstOrDefault();

            if (resultadoBusca is null)
                return NotFound($"O cpf {cpfBusca} não encontrado");


            resultadoBusca.Nome = alunoAtualizado.Nome;
            resultadoBusca.Idade = alunoAtualizado.Idade;

            return Ok("Atualizado");


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
