using Aula001.Validations;
using System.ComponentModel.DataAnnotations;

namespace Aula001.Models
{
    public class Aluno
    {

        [Required(ErrorMessage = "Cpf é obrigatório")]
        [MinLength(11, ErrorMessage = "Cpf com no mínimo de 11 caracteres")]
        [MaxLength(11, ErrorMessage = "Cpf com no máximo de 11 caracteres")]
        public string Cpf { get; set; }



        [Required(ErrorMessage = "Nome é obrigatório")]
        [MinLength(3, ErrorMessage = "Nome com mínimo de 3 caracteres")]
        [MaxLength(50, ErrorMessage = "Nome com máximo de 50 caracteres")]
        public string Nome { get; set; }



        [Required(ErrorMessage = "Idade é obrigatória")]
        /*[Range(18, 80, ErrorMessage = "Intervalo de idade deve ser entre 18 e 20")]*/
        [MaioridadeValidation(
            ErrorMessage = "Idade deve ser maior ou igua 18")]
        public int Idade { get; set; }

        public string MyProperty { get; set; }
        [Compare(nameof(MyProperty), ErrorMessage = "Campos estao diferentes")]
        public string MyProperty2 { get; set; }
    }
}
