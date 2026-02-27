using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class ContatoRepository : IContatoRepository
    {
        private static List<DadosContato> dadosContatosList = new List<DadosContato>();

        public ContatoRepository() { }

        public void Inserir(DadosContato novoContato)
        {
            dadosContatosList.Add(novoContato);
        }

        public DadosContato obterContatosPorId(string id)
        {
            return dadosContatosList.Where(c => c.id == id).FirstOrDefault();
        }

        public List<DadosContato> obterTodosContatos()
        {
            return dadosContatosList;
        }
    }
}

