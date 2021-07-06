using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Modulo2.Bridge
{
	public class EnviaPorSMS :IEnviador
	{
		public void Envia(IMensagem mensagem)
		{
			Console.WriteLine("Enviando mensagem por SMS");
			Console.WriteLine(mensagem.Formata());
		}
	}
}
