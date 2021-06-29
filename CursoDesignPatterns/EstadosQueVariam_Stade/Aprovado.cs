using CursoDesignPatterns.ExercicioDesconto;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.EstadosQueVariam
{
	public class Aprovado : IEstadoOrcamento
	{
		public void AplicaDescontoExtra(Orcamento orcamento)
		{
			orcamento.valor -= orcamento.valor * 0.05;
			orcamento.DescontoAplicado = true;
		}

		public void Aprova(Orcamento orcamento)
		{
			throw new Exception("Orçamento ja aprovado");
		}

		public void Finaliza(Orcamento orcamento)
		{
			orcamento.EstadoOrcamento = new Finalizado();
		}

		public void Reprova(Orcamento orcamento)
		{
			throw new Exception("Orçamento ja aprovado");
		}
	}
}
