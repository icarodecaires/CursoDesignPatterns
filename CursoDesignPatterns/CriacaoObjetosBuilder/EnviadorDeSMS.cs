using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.CriacaoObjetosBuilder
{
	public class EnviaSMS : AcaoAposCriarNota
	{
		public void Executa(NotaFiscal nf)
		{
			Console.WriteLine("enviando SMS");
		}
	}
}
