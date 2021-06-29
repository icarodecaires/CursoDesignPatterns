using CursoDesignPatterns.ExercicioDesconto;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.EstadosQueVariam
{
	public interface IEstadoOrcamento
	{
		void AplicaDescontoExtra(Orcamento orcamento);

		void Aprova(Orcamento orcamento);
		void Reprova(Orcamento orcamento);
		void Finaliza(Orcamento orcamento);
	}
}
