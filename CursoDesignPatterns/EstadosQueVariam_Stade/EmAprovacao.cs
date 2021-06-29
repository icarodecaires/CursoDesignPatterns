using CursoDesignPatterns.ExercicioDesconto;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.EstadosQueVariam
{
	public class EmAprovacao : IEstadoOrcamento
	{
		public void AplicaDescontoExtra(Orcamento orcamento)
		{
			orcamento.valor -= orcamento.valor * 0.02;
			orcamento.DescontoAplicado = true;
		}

		public void Aprova(Orcamento orcamento)
		{
			orcamento.EstadoOrcamento = new Aprovado();
			orcamento.DescontoAplicado = true;
		}

		public void Finaliza(Orcamento orcamento)
		{
			throw new Exception("Orçamento em aprovação não pode ser movido para finalizado");
		}

		public void Reprova(Orcamento orcamento)
		{
			orcamento.EstadoOrcamento = new Finalizado();
		}
	}
}
