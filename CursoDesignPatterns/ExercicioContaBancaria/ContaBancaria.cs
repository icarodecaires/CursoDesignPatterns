using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.ExercicioContaBancaria
{
	public class ContaBancaria
	{
		public int Numero { get; private set; }
		public int Agencia { get; private set; }
		public string NomeTitular { get; private set; }

		public ContaBancaria(int numero, int agencia, string nomeTitular)
		{
			Numero = numero;
			Agencia = agencia;
			NomeTitular = nomeTitular;
		}
	}
}
