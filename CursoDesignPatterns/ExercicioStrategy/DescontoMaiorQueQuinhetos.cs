using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.ExercicioDesconto
{
	public class DescontoMaiorQueQuinhetos : IDesconto
	{
		public IDesconto Proximo { get; set; }

		public double Desconta(Orcamento orcamento)
		{
			if(orcamento.valor > 500)
			{
				return orcamento.valor * 0.07;
			}

			return Proximo.Desconta(orcamento);
		}
	}
}
