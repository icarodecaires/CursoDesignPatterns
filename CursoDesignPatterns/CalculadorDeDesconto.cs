using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
	public class CalculadorDeDesconto
	{
		public double Calcula(Orcamento orcamento)
		{
			IDesconto d1 = new DescontoMaisQueCincoItens();
			IDesconto d2 = new DescontoMaiorQueQuinhetos();
			IDesconto d3 = new DescontoPorVendaCasada();

			d2.Proximo = d3;
			d1.Proximo = d2;


			return d1.Desconta(orcamento);
		}
	}
}
