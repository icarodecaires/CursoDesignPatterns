using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.CriacaoObjetosBuilder
{
	public interface AcaoAposCriarNota
	{
		public void Executa(NotaFiscal nf);
	}
}
