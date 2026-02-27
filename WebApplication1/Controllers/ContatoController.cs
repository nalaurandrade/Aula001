using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/contato")]
    public class ContatoController : ControllerBase
    {
        private readonly IContatoRepository _contatoRepository;

        public ContatoController(IContatoRepository contatoRepository)
        {
            _contatoRepository = contatoRepository;
        }

        [HttpGet]
        public IActionResult OlaContato()
        {
            return Ok("Ola Contato");
        }

        [HttpGet]
        [Route("ObterPorId")]
        public IActionResult ObterPorId(string id)
        {
            var contatoPesquisado = _contatoRepository.obterContatosPorId(id);

            if (contatoPesquisado is null)
                return NotFound($"Contato com id {id} não encontrado.");

            return Ok(contatoPesquisado);
        }

        [HttpGet]
        [Route("ObterTodos")]
        public IActionResult ObterTodos()
        {
            return Ok(_contatoRepository.obterTodosContatos());
        }

        [HttpPost]
        public IActionResult OlaContatoNome(string nome)
        {
            return Ok($"Ola Mundo {nome}");
        }
    }

}
