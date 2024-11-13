using GestaoAlunos.Domain.Entidades;
using GestaoAlunos.Domain.Interfaces;
using GestaoAlunos.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlunos.Service.Servicos
{
    private readonly IAlunoRepository _alunoRepository;
    public class AlunoService : IAlunoService
    {
        public bool Adicionar(Aluno entidade)
        {
            throw new NotImplementedException();
        }

        public Aluno ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Aluno> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
