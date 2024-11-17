using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services;

namespace Aula001.Controllers
{
    [ApiController]
    [Route("api/notaaluno")]
    public class NotaAlunoController : ControllerBase
    {
        private readonly AlunoNotaService _alunoNotaService;

        public NotaAlunoController(AlunoNotaService alunoNotaService)
        {
            _alunoNotaService = alunoNotaService;
        }

        [HttpPost("InserirNota")]
        public IActionResult InserirNota(NotaAluno notaAluno)
        {
            var resultado = _alunoNotaService.InserirNota(notaAluno);
            if (resultado != null)
                return BadRequest(resultado);

            return Ok("Nota inserida com sucesso!");
        }

        [HttpGet("ListarAlunosAprovados")]
        public IActionResult ListarAlunosAprovados()
        {
            var alunosAprovados = _alunoNotaService.ListarAlunosAprovados();
            return Ok(alunosAprovados);
        }

        [HttpGet("ListarAlunosReprovados")]
        public IActionResult ListarAlunosReprovados()
        {
            var alunosReprovados = _alunoNotaService.ListarAlunosReprovados();
            return Ok(alunosReprovados);
        }
    }
}

