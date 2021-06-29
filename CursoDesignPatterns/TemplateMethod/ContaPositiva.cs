using CursoDesignPatterns.ExercicioImposto;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.TemplateMethod
{
	public class ContaPositiva : IEstadoConta
	{
		public void Deposito(Conta conta, double valor)
		{
			conta.Saldo += valor * 0.98;
		}

		public void Saque(Conta conta, double valor)
		{
			conta.Saldo -= valor;
			if (conta.Saldo < 0)
			{
				conta.EstadoConta = new ContaNegativa();
			}
		}
	}
}
