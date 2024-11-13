using GestaoAlunos.API.Models;
using GestaoAlunos.Domain.Entidades;
using GestaoAlunos.Service.Interfaces;
using GestaoAlunos.Service.Servicos;
using Microsoft.AspNetCore.Mvc;

namespace GestaoAlunos.API.Controllers
{
    public class AlunoController : ControllerBase
    {

        private readonly IAlunoService _alunoService;
        
        public AlunoController(IAlunoService alunoservice)
        {
            _alunoService = alunoservice;
        }

        [HttpGet]
        public IActionResult ObterTodosAlunos()
        {
            return Ok(_alunoService.ObterTodos());
        }
        [HttpPost]
        public IActionResult Adicionar(NovoAlunoDTO novoAluno)

        {
           var flSucesso =  _alunoService.Adicionar(
             new Aluno(
                novoAluno.nome,
                novoAluno.email,
                novoAluno.telefone,
                novoAluno.cpf
                ));
         
            if(flSucesso)
                return Ok("Inserido com sucesso");

            return BadRequest("erro ao inserir");
        }
    }
}
