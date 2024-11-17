using Aula001.Controllers;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class AlunoNotaService
    {
        private readonly IAlunoRepository _alunoRepository;

        public AlunoNotaService(IAlunoRepository alunoRepository, IDisciplinaRepository disciplinaRepository, IAlunoNotaRepository alunoNotaRepository)
        {
            _alunoRepository = alunoRepository;
            _disciplinaRepository = disciplinaRepository;
            _alunoNotaRepository = alunoNotaRepository;
        }

        public string InserirNota(NotaAluno notaAluno)
        {
            var aluno = _alunoRepository.GetByRa(notaAluno.RaAluno);
            var disciplina = _disciplinaRepository.GetById(notaAluno.IdDisciplina);

            if (aluno == null || disciplina == null)
            {
                return "Aluno ou disciplina não encontrados.";
            }

            if (_alunoNotaRepository.Exists(notaAluno.RaAluno, notaAluno.IdDisciplina))
            {
                return "Já existe uma nota para este aluno na disciplina.";
            }

            _alunoNotaRepository.Add(notaAluno);
            return null; 
        }

        internal object InserirNota(NotaAluno notaAluno)
        {
            throw new NotImplementedException();
        }

        internal object ListarAlunosAprovados()
        {
            throw new NotImplementedException();
        }

        internal object ListarAlunosReprovados()
        {
            throw new NotImplementedException();
        }
    }

}
