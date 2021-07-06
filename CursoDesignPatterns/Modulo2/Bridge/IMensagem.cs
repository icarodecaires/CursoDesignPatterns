using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Modulo2.Bridge
{
	public interface IMensagem
	{
		IEnviador Enviador { get; set; }
		void Envia();

		string Formata();
	}
}
