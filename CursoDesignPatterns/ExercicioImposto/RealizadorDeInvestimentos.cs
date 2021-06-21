using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.ExercicioImposto
{
	public class RealizadorDeInvestimentos
	{
		public Conta  RealizaInvestimento(Conta conta, IEstrategiaInvestimento estrategia)
		{
			return estrategia.Investir(conta);
		}
	}
}
