using System.ComponentModel.DataAnnotations;

namespace Aula001.Models
{
    public class Disciplina
    {
        [Required(ErrorMessage = "IdDisciplina é obrigatório")]
        public int IdDisciplina { get; set; }

        [Required(ErrorMessage = "Nome da disciplina é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Curso é obrigatório")]
        public string Curso { get; set; }
    }
}
