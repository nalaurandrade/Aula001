namespace WebApplication1.Validations
{
    public class Notavalidation : ValidationAttribute
    {
        public List<AlunoNota> ListarAlunosAprovados()
        {
            return _alunoNotaRepository.GetAll()
                .Where(n => n.Nota >= 7 && n.Frequencia >= 75)
                .ToList();
        }

        public List<AlunoNota> ListarAlunosReprovados()
        {
            return _alunoNotaRepository.GetAll()
                .Where(n => n.Nota < 7 || n.Frequencia < 75)
                .ToList();
        }

    }
}
