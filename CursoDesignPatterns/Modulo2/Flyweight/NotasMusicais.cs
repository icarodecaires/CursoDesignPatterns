using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Modulo2.Flyweight
{
	public class NotasMusicais
	{
		private static IDictionary<string, INota> notas = 
			new Dictionary<string, INota>()
			{
			{"do", new Do()},
			{"re", new Re()},
			{"mi", new Mi()},
			{"fa", new Fa()}
			};

		public INota pega(string nome)
		{
			return notas[nome];
		}
	}
}
