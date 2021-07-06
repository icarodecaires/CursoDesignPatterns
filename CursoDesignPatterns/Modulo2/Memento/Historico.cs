using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Modulo2.Memento
{
	public class Historico
	{
		private IList<Estado> Estados = new List<Estado>();

		public void Adiciona(Estado estado)
		{
			this.Estados.Add(estado);
		}

		public Estado Pega(int indice)
		{
			return Estados[indice];
		}
	}
}
