using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.ExercicioContaBancaria
{
	public class RequisicaoConta
	{
		public string Requisicao(Formato formato, ContaBancaria conta)
		{
			IFormatoConta f1 = new FormatoCSV(new FormatoXML(null));

			return f1.RetornaConta(formato, conta);
		}
	}
}
