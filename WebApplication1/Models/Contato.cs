using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    internal class Contato
    {
        [Required(ErrorMessage = "Nome do cliente é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Telefone do cliente é obrigatório")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Id do cliente é obrigatório")]
        public string Id { get; set; }
    }
}

