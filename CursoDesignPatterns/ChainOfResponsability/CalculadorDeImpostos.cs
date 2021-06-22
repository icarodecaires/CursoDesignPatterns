using CursoDesignPatterns.ExercicioDesconto;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.ExercicioImposto
{
	public class CalculadorDeImpostos
	{
		public void RealizaCalculo(Orcamento orcamento, Imposto imposto)
		{
			double imp = imposto.Calcula(orcamento);
			Console.WriteLine("IMPOSTO: "+imp);
		}
	}
}
