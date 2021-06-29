using CursoDesignPatterns.ExercicioDesconto;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.EstadosQueVariam
{
	public class Finalizado : IEstadoOrcamento
	{
		public void AplicaDescontoExtra(Orcamento orcamento)
		{
			throw new Exception("Orcamentos finalizados não recebem desconto extra");
		}



		public void Aprova(Orcamento orcamento)
		{
			throw new Exception("Orçamento ja finalizado");
		}

		public void Finaliza(Orcamento orcamento)
		{
			orcamento.EstadoOrcamento = new Finalizado();
		}

		public void Reprova(Orcamento orcamento)
		{
			throw new Exception("Orçamento ja finalizado");
		}
	}
}
