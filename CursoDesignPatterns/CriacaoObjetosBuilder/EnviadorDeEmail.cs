using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.CriacaoObjetosBuilder
{
	public class EnviadorDeEmail : AcaoAposCriarNota
	{
		public void Executa(NotaFiscal nf)
		{
			Console.WriteLine("Enviando Nota por email");
		}
	}
}
