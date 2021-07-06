using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Modulo2.Bridge
{
	public interface IEnviador
	{
		void Envia(IMensagem mensagem);
	}
}
