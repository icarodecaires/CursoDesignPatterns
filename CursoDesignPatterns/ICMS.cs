using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
	public class ICCC : Imposto
	{
		public double Calcula(Orcamento orcamento)
		{
			if (orcamento.valor < 1000)
			{
				return orcamento.valor * 0.05;
			}
			else if(orcamento.valor >= 1000 && orcamento.valor <= 3000)
			{
				return orcamento.valor * 0.07;
			}
			else
			{
				return orcamento.valor * 0.08;
			}	
		}
	}
}
