using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.CriacaoObjetosBuilder
{
	public class NotaFiscalDAO : AcaoAposCriarNota
	{
		public void Executa(NotaFiscal nf)
		{
			Console.WriteLine("Salvando nota em banco");
		}
	}
}
