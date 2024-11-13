using GestaoAlunos.Domain.Entidades;
using GestaoAlunos.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlunos.Data.Repositorios
{
    public class AlunoRepository : IAlunoRepository
    {
        public void Adicionar(Aluno entidade)
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
