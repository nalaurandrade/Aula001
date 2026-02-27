﻿using WebApplication1.Models;

namespace WebApplication1.Services
{
	public interface IContatoRepository
	{
		public List<DadosContato> obterTodosContatos();
		public DadosContato obterContatosPorId(string id);

		public void Inserir(DadosContato novoContato);
	}
} 