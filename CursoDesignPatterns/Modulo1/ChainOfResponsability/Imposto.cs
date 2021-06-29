using CursoDesignPatterns.ExercicioDesconto;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.ExercicioImposto
{
	public interface Imposto
	{
		double Calcula(Orcamento orcamento);
	}
}
