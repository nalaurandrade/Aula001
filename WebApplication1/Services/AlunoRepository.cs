using WebApplication1.Models;

namespace WebApplication1.Services
{
	public class AlunoRepository : IAlunoRepository
	{
		private static List<DadosAluno> dadosAlunosList = new List<DadosAluno>();

		public AlunoRepository() { }

		public void Inserir(DadosAluno novoAluno)
		{
			dadosAlunosList.Add(novoAluno);
		}

		public DadosAluno obterAlunosPorCpf(string cpf)
		{
			return dadosAlunosList.Where(a => a.cpf == cpf).FirstOrDefault();
		}

		public List<DadosAluno> obterTodosAlunos()
		{
			return dadosAlunosList;
		}
        public string CriarAluno(Aluno aluno)
        {
            if (_alunoRepository.Exists(aluno.RA))
            {
                return "Já existe um aluno com esse RA.";
            }

            _alunoRepository.Add(aluno);
            return "Aluno criado com sucesso!";
        }
    }
}
