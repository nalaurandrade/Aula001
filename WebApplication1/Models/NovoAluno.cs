using System.ComponentModel.DataAnnotations;
using WebApplication1.Validations;

namespace WebApplication1.Models
{
	public class NovoAluno
	{
		[Required(ErrorMessage = "Obrigatório")]
		[MaxLength(10, ErrorMessage = "Maximo 10 letras ")]
		public string nome { get; set; }
		[Required(ErrorMessage = "Obrigatório")]
		[EmailAddress(ErrorMessage = "Email invalido")]
		public string email { get; set; }
		[Required(ErrorMessage = "Obrigatório")]

		public string telefone { get; set; }
		[Required(ErrorMessage = "Obrigatório")]
		public string cpf { get; set; }
		[MaioridadeValidation( ErrorMessage = "Erro idade")]
		public int idade { get; set; }
        [Required(ErrorMessage = "RA é obrigatório")]
        [MinLength(5, ErrorMessage = "RA deve ter 5 caracteres")]
        [MaxLength(5, ErrorMessage = "RA deve ter 5 caracteres")]
        public string RA { get; set; }
        [Required(ErrorMessage = "Email é obrigatório")]
        [EmailAddress(ErrorMessage = "Formato de email inválido")]
        public string Email { get; set; }

        [Range(0, 100, ErrorMessage = "Frequência deve estar entre 0 e 100")]
        public double Frequencia { get; set; }
    }
}
