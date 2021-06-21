using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.ExercicioContaBancaria
{
	public class FormatoXML : IFormatoConta
	{
		public IFormatoConta Proximo { get; set; }

		public FormatoXML(IFormatoConta proximo)
		{
			Proximo = proximo;
		}

		public string RetornaConta(Formato formato, ContaBancaria conta)
		{

			if (formato == Formato.XML)
			{
				return $"<XML>" +
				   $"<Numero> {conta.Numero} </Numero>" +
				   $"<Agencia> {conta.Agencia} </Agencia>" +
				   $"<titular> {conta.NomeTitular} </Titular>" +
					"</XML>";
			}

			return Proximo.RetornaConta(formato, conta);
		}
	}
}
