using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Modulo2.Command
{
	public class FilaDeTrabalho
	{
		private IList<IComando> Comandos = new List<IComando>();

		public void Adiciona(IComando comando)
		{
			Comandos.Add(comando);
		}

		public void Processa()
		{
			foreach(IComando comando in Comandos)
			{
				comando.Executa();
			}
		}
	}
}
