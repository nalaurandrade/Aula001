using Microsoft.AspNetCore.Mvc;
using Aula001.Models;
using WebApplication1.Services;

namespace Aula001.Controllers
{
    [ApiController]
    [Route("api/disciplina")]
    public class DisciplinaController : ControllerBase
    {
        private readonly DisciplinaService _disciplinaService;

        public DisciplinaController(DisciplinaService disciplinaService)
        {
            _disciplinaService = disciplinaService;
        }

        [HttpPost("Criar")]
        public IActionResult CriarDisciplina(Disciplina disciplina)
        {
            var resultado = _disciplinaService.CriarDisciplina(disciplina);
            if (resultado != null)
                return BadRequest(resultado);

            return Ok("Disciplina criada com sucesso!");
        }

        [HttpGet("BuscarTodas")]
        public IActionResult BuscarTodas()
        {
            var disciplinas = _disciplinaService.ObterTodasDisciplinas();
            return Ok(disciplinas);
        }
    }
}
