using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.ExercicioDesconto
{
	public class DescontoPorVendaCasada : IDesconto
	{
		public IDesconto Proximo { get; set; }

		public double Desconta(Orcamento orcamento)
		{
			if (orcamento.existe("LAPIS") && orcamento.existe("CANETA"))
			{
				return orcamento.valor * 0.05;
			}

			return Proximo.Desconta(orcamento);
		}
	}
}
