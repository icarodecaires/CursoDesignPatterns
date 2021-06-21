using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
	public class ISS : Imposto
	{
		public double Calcula(Orcamento orcamento)
		{
			return orcamento.valor * 0.06;
		}
	}
}
