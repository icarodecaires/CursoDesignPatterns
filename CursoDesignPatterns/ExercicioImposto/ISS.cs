using CursoDesignPatterns.ExercicioDesconto;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.ExercicioImposto
{
	public class ISS : Imposto
	{
		public double Calcula(Orcamento orcamento)
		{
			return orcamento.valor * 0.06;
		}
	}
}
