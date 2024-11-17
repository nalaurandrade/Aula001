using Aula001.Models;

namespace WebApplication1.Services
{
    public class DisciplinaService
    {
        private readonly IDisciplinaRepository _disciplinaRepository;

        public DisciplinaService(IDisciplinaRepository disciplinaRepository)
        {
            _disciplinaRepository = disciplinaRepository;
        }

        public string CriarDisciplina(Disciplina disciplina)
        {
            if (_disciplinaRepository.Nome(disciplina.Nome))
            {
                return "Já existe uma disciplina com esse nome.";
            }

            _disciplinaRepository.Add(disciplina);
            return null; 
        }

        public List<Disciplina> ObterTodasDisciplinas()
        {
            return _disciplinaRepository.GetAll();
        }
    }

}
