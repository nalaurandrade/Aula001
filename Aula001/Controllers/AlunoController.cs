using Microsoft.AspNetCore.Mvc;

namespace Aula001.Controllers
{
    [ApiController]
    [Route("api/aluno")]
    public class AlunoController : ControllerBase
    {
        [HttpGet]
        [Route("Saudacao")]
        public IActionResult Saudacao()
        {
            return Ok("Olá mundo");
        }


        [HttpGet]
        [Route("SaudacaoNome")]
        public IActionResult SaudacaoNome(string nome)
        {
            return Ok("$Olá mundo {nome}");
        }
    }
}
