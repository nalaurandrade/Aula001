using Aula001.Validations;
using System.ComponentModel.DataAnnotations;

namespace Aula001.Models
{
    public class Aluno
    {
        [Required(ErrorMessage = "Nome é obrigatório")]
        [MinLength(3, ErrorMessage = "Nome com mínimo de 3 caracteres")]
        [MaxLength(50, ErrorMessage = "Nome com máximo de 50 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        [MinLength(2, ErrorMessage = "Nome deve conter mais de 2 caracteres")]

        public string RA { get; set; }

        [Required(ErrorMessage = "RA é obrigatório")]
        [MinLength(5, ErrorMessage = "Nome com 6 caracteres")]
        [MaxLength(6, ErrorMessage = "Nome com 6 caracteres")]
        public string email { get; set; }

        [MinLength(5, ErrorMessage = "email com 6 caracteres")]
        [MaxLength(6, ErrorMessage = "email com 6 caracteres")]
        public string MyProperty { get; set; }
        [Compare(nameof(MyProperty), ErrorMessage = "Campos estao diferentes")]
        public string MyProperty2 { get; set; }
    }
}
