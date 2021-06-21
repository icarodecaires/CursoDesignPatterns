using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.ExercicioDesconto
{
	public interface IDesconto
	{
		IDesconto Proximo { get; set; }
		double Desconta(Orcamento orcamento);
	}
}
