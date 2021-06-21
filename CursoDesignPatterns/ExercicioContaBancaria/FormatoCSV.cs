using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.ExercicioContaBancaria
{
	public class FormatoCSV : IFormatoConta
	{
		public IFormatoConta Proximo { get; set; }

		public FormatoCSV(IFormatoConta proximo)
		{
			Proximo = proximo;
		}

		public string RetornaConta(Formato formato, ContaBancaria conta)
		{

			if (formato == Formato.CSV)
			{
				return $"{conta.Agencia};{conta.Numero};{conta.NomeTitular}";
			}

			return Proximo.RetornaConta(formato, conta);
		}
	}
}
