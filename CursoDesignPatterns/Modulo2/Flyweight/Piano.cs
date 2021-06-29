using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Modulo2.Flyweight
{
	public class Piano
	{

		public void Toca(IList<INota> musica)
		{
			foreach(var nota in musica)
			{
				Console.Beep(nota.Frequencia,300);
			}

		}
	}
}
